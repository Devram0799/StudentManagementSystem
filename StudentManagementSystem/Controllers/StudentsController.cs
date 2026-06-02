using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers;

public class StudentsController : Controller
{
private readonly ApplicationDbContext _context;

public StudentsController(ApplicationDbContext context)
{
    _context = context;
}

// Student List + Search + Sort + Pagination
public IActionResult Index(string searchString, string sortOrder, int page = 1)
{
    int pageSize = 5;

    ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
    ViewBag.EmailSort = sortOrder == "email" ? "email_desc" : "email";
    ViewBag.CourseSort = sortOrder == "course" ? "course_desc" : "course";

    var students = _context.Students.AsQueryable();

    if (!string.IsNullOrEmpty(searchString))
    {
        students = students.Where(s =>
            s.Name.Contains(searchString) ||
            s.Email.Contains(searchString) ||
            s.Course.Contains(searchString));
    }

    switch (sortOrder)
    {
        case "name_desc":
            students = students.OrderByDescending(s => s.Name);
            break;

        case "email":
            students = students.OrderBy(s => s.Email);
            break;

        case "email_desc":
            students = students.OrderByDescending(s => s.Email);
            break;

        case "course":
            students = students.OrderBy(s => s.Course);
            break;

        case "course_desc":
            students = students.OrderByDescending(s => s.Course);
            break;

        default:
            students = students.OrderBy(s => s.Name);
            break;
    }

    int totalStudents = students.Count();

    var pagedStudents = students
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();

    ViewBag.CurrentPage = page;
    ViewBag.TotalPages =
        (int)Math.Ceiling(totalStudents / (double)pageSize);

    return View(pagedStudents);
}

// GET Create
public IActionResult Create()
{
    return View();
}

// POST Create
[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Create(Student student)
{
    if (ModelState.IsValid)
    {
        _context.Students.Add(student);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    return View(student);
}

// GET Edit
public IActionResult Edit(int id)
{
    var student = _context.Students.Find(id);

    if (student == null)
        return NotFound();

    return View(student);
}

// POST Edit
[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Edit(Student student)
{
    if (ModelState.IsValid)
    {
        _context.Students.Update(student);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    return View(student);
}

// GET Delete
public IActionResult Delete(int id)
{
    var student = _context.Students.Find(id);

    if (student == null)
        return NotFound();

    return View(student);
}

// POST Delete
[HttpPost]
[ValidateAntiForgeryToken]
[ActionName("Delete")]
public IActionResult DeleteConfirmed(int id)
{
    var student = _context.Students.Find(id);

    if (student != null)
    {
        _context.Students.Remove(student);
        _context.SaveChanges();
    }

    return RedirectToAction(nameof(Index));
}


}
