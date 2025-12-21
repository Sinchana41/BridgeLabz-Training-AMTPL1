# Employee Admin Portal – ASP.NET Core Web API

##  Overview
This project is an **ASP.NET Core Web API** that performs **CRUD operations** on employee data using **Entity Framework Core**.  
It exposes RESTful endpoints to **create, read, update, and delete employees** from a database.

The application follows **clean API design practices** using **DTOs**, **dependency injection**, and **controller-based routing**.

---

##  Architecture
- **Controller**: Handles HTTP requests
- **DTOs**: Used for request and response models
- **Entity Models**: Represents database tables
- **DbContext**: Handles database operations using EF Core

---

##  Technologies Used
- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- REST API
- Dependency Injection

---

##  Key Components

###  EmployeesController
Handles all API requests related to employees.

###  ApplicationDBContext
- Manages database connections
- Interacts with the `Employees` table

###  DTOs
- `AddEmployeeDto`
- `UpdateEmployeeDto`  
Used to separate API models from database entities.

---

