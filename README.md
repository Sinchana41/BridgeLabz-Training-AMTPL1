# Employee Management System – ADO.NET Console Application

##  Overview
This project is a **C# Console Application** that demonstrates **CRUD (Create, Read, Update, Delete)** operations using **ADO.NET** with **SQL Server**.

The application provides a **menu-driven interface** that allows users to manage employee records stored in a SQL Server database.

---

##  Database Details
**Database Name:** `Employees_DB`  
**Table Used:** `Employee`

### Employee Table Structure
| Column Name | Data Type |
|------------|----------|
| EmployeeID | INT (Primary Key) |
| Name | VARCHAR |
| Age | INT |
| Dept | VARCHAR |
| Salary | DECIMAL |

---

##  Technologies Used
- C#
- .NET Console Application
- ADO.NET
- SQL Server

---

##  Features Implemented

###  Insert Employee
- Takes employee details from user
- Uses **parameterized queries** to prevent SQL Injection

###  Display All Employees
- Reads data using `SqlDataReader`
- Displays employee details in tabular format

###  Update Employee Salary
- Updates salary using **EmployeeID**
- Validates input before updating

###  Delete Employee
- Deletes employee record using **EmployeeID**

###  Input Validation
- Uses `TryParse` for numeric inputs
- Handles invalid input gracefully

---

##  Menu Options
