# Practical_13 - ASP.NET MVC with Entity Framework Code First

This project demonstrates how to use **Entity Framework Code First with Migrations** in an ASP.NET MVC application. It includes two database tables: **Designation** and **Employee**, with a one-to-many relationship.

---

## 🛠 Technologies Used

- ASP.NET MVC
- Entity Framework 6
- SQL Server LocalDB
- Bootstrap (auto-included in MVC template)

---

## 📦 Installation Steps

1. Clone or download this repository.
2. Open the solution in **Visual Studio**.
3. Open **Package Manager Console** (Tools > NuGet Package Manager).
4. Run the following commands to enable and apply migrations:

   ```bash
   Enable-Migrations
   Add-Migration InitialCreate
   Update-Database
