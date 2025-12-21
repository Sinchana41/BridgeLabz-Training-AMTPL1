# Student Database – SQL Basic Operations

##  Overview
This project demonstrates **basic to intermediate SQL operations** using a **Student Database**.  
It covers **DDL, DML, DQL, transactions, triggers, and stored procedures** with practical examples.

The script is designed for **learning SQL fundamentals** and understanding how database objects work together.

---

##  Database Details
**Database Name:** `Student_DB`

---

##  Tables Created

###  Student Table
Stores student details such as name and marks.

**Columns:**
- `StudentId` (Primary Key, Identity)
- `StudentName`
- `StudentMarks`

---

###  Department Table
Stores department information.

**Columns:**
- `DeptID` (Primary Key)
- `DeptName`

---

###  StudentAudit Table
Used to track insert operations on the `Student` table.

**Columns:**
- `AuditId`
- `StudentId`
- `StudentName`
- `StudentMarks`
- `ActionType`
- `ActionDate`

---

##  SQL Concepts Covered

###  DDL (Data Definition Language)
- `CREATE DATABASE`
- `CREATE TABLE`
- `ALTER TABLE` (Add / Modify / Rename / Drop column)
- `DROP TRIGGER`

---

###  DML (Data Manipulation Language)
- `INSERT`
- `UPDATE`
- `DELETE`

---

###  DQL (Data Query Language)
- `SELECT`
- `WHERE`, `AND`, `NOT`
- `IN`, `BETWEEN`
- `LIKE`, `NOT LIKE`
- `ORDER BY`

---

###  String Functions
- `SUBSTRING()`
- `LEN()`
- `LEFT()`, `RIGHT()`
- `REPLACE()`
- `CHARINDEX()`
- `UPPER()`, `LOWER()`
- `CONCAT()`
- `REVERSE()`

---

###  Transactions
- `BEGIN TRANSACTION`
- `SAVE TRANSACTION`
- `ROLLBACK`
- `COMMIT`

Demonstrates how to **maintain data consistency**.

---

###  Triggers
- `AFTER INSERT` trigger on `Student` table
- Automatically logs inserted records into `StudentAudit`

---

###  Stored Procedures
- `GetAllStudents`
- Demonstrates reusable SQL logic


