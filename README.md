# 🎓 Student Management System

A full-stack ASP.NET Core MVC application that allows users to manage student records efficiently. The system supports creating, viewing, updating, deleting, searching, sorting, and validating student information using SQL Server and Entity Framework Core.

---

## 🚀 Features

### Student Management

* Add New Student
* View Student List
* Update Student Details
* Delete Student Records

### Search Functionality

* Search students by:

  * Name
  * Email
  * Course

### Sorting

* Sort by:

  * Name
  * Email
  * Course

### Validation

* Required field validation
* Email validation
* Form validation using Data Annotations

### Pagination

* Display students page-wise
* Improved performance for large datasets

---

## 🛠️ Technologies Used

### Backend

* ASP.NET Core MVC (.NET 10)
* C#
* Entity Framework Core

### Database

* SQL Server Express
* SQL Server Management Studio (SSMS)

### Frontend

* Razor Views
* HTML5
* CSS3
* Bootstrap 5

### Development Tools

* Visual Studio Code
* Git
* GitHub

---

## 📂 Project Structure

StudentManagementSystem

├── Controllers

├── Models

├── Views

├── Data

├── Migrations

├── wwwroot

├── Program.cs

└── appsettings.json

---

## ⚙️ Database Configuration

Update the connection string in:

appsettings.json

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

---

## 🔧 Installation Steps

### Clone Repository

```bash
git clone https://github.com/yourusername/StudentManagementSystem.git
```

### Navigate to Project

```bash
cd StudentManagementSystem
```

### Restore Packages

```bash
dotnet restore
```

### Apply Migrations

```bash
dotnet ef database update
```

### Run Application

```bash
dotnet run
```

---

## 📸 Screenshots

### Student List Page

<img width="1266" height="654" alt="image" src="https://github.com/user-attachments/assets/38c82299-d2c8-468e-b4cc-a106a53da94a" />


* Search functionality
* Sorting functionality
* Edit/Delete actions

### Add Student Page

* Form validation
* Student registration

---

## 🎯 Learning Outcomes

This project demonstrates:

* ASP.NET Core MVC Architecture
* CRUD Operations
* Entity Framework Core
* SQL Server Integration
* Razor Views
* Data Validation
* Search & Sorting
* Pagination
* Git & GitHub Workflow

---

## 👨‍💻 Author

Dev Ram

Aspiring .NET Full Stack Developer

GitHub: https://github.com/Devram0799

---

## ⭐ Future Enhancements

* Authentication & Authorization
* User Roles (Admin/User)
* Dashboard Analytics
* Export Data to Excel/PDF
* REST API Integration
* Deployment on Azure
