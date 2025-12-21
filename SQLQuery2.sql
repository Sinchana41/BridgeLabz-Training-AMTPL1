CREATE DATABASE Student_DB;

USE Student_DB;

CREATE TABLE Student(
StudentId INT PRIMARY KEY IDENTITY(1,1),
StudentName VARCHAR(20) NOT NULL,
StudentMarks INT NOT NULL);

SELECT * FROM Student;

INSERT INTO Student(StudentName,StudentMarks) VALUES 
('Seetha', 98),
('Ram', 95),
('Radha', 90),
('Rukumini', 99);


CREATE TABLE Department(
DeptID INT PRIMARY KEY,
DeptName VARCHAR(20));

INSERT INTO Department(DeptID,DeptName) VALUES 
(1,'CS'),
(2,'IS'),
(3,'EC');

SELECT * FROM Department;

-- TO ADD EXTRA COLUMN
ALTER TABLE Student
ADD [Address] VARCHAR(30);

-- TO ALTER THE DATA TYPE OF THE COLUMN
ALTER TABLE Student
ALTER COLUMN [Address] CHAR(30); 

-- TO RENAME COLUMN NAME
EXEC sp_rename 'Student.[Address]','StudentAddress','COLUMN';

SELECT * FROM Student;

-- TO DROP COLUMN NAME
ALTER TABLE Student
DROP COLUMN StudentAddress;

-- TO CHECK TABLE STRUCTURE
SP_HELP Student;

INSERT INTO Student VALUES('Krishna',91);

SELECT StudentName,StudentMarks FROM Student;

SELECT * FROM Student
WHERE StudentId < 5;


SELECT * FROM Student
WHERE StudentId < 4 AND StudentName = 'Seetha';

SELECT * FROM Student
WHERE NOT StudentId = 1;

SELECT * FROM Student
WHERE StudentId BETWEEN 1 AND 3;

SELECT * FROM Student
WHERE StudentId NOT BETWEEN 1 AND 3;

SELECT * FROM Student
WHERE StudentId IN (1,2,3);

SELECT * FROM Student
WHERE StudentId NOT IN (1,2,3);

SELECT * FROM Student
WHERE StudentName LIKE '___';

SELECT * FROM Student
WHERE StudentName NOT LIKE '___';

SELECT * FROM Student
WHERE StudentName LIKE 'S%';

SELECT * FROM Student
WHERE StudentName NOT LIKE 'S%';

SELECT * FROM Student
WHERE StudentName LIKE '%S%';

INSERT INTO Student VALUES('Sathis',90);

SELECT * FROM Student
WHERE StudentName LIKE '%S%S%';

-- TO DELETE A ROW
DELETE FROM Student WHERE StudentId = 6;

SELECT * FROM Student;

-- MODIFY
UPDATE Student
SET StudentMarks = 86
WHERE StudentId = 3;

-- SUBSTRING(expression, start, length)
SELECT SUBSTRING(StudentName,1,3) AS FirstThreeLetters FROM Student;
SELECT SUBSTRING(StudentName,LEN(StudentName)-2,3) AS LastThreeLetters FROM Student;

-- TO DELETE ALL THE ROWS
DELETE FROM Student;

-- REPLACE(string, old_value, new_value)
SELECT REPLACE(StudentName,'a','aa') AS REPLACEDNAME FROM Student;

-- LEN()
SELECT StudentName, LEN(StudentName) AS NameLength
FROM Student;

-- LEFT()
SELECT LEFT(StudentName, 2)
FROM Student;

-- RIGHT()
SELECT RIGHT(StudentName, 2)
FROM Student;

-- CHARINDEX()
SELECT StudentName, CHARINDEX('a',StudentName) AS IndexOfA
FROM Student;

-- UPPER() & LOWER()
SELECT UPPER(StudentName) AS NameInUpperCase, LOWER(StudentName) AS NameInLowerCase
FROM Student;

-- CONCAT()
SELECT CONCAT(StudentName,' Hi') FROM Student;

-- REVERSE()
SELECT REVERSE(StudentName) AS ReversedName FROM Student;

SELECT * FROM Student;

-- TRANSACTIONBEGIN TRANSACTION;

BEGIN TRANSACTION;

INSERT INTO Student VALUES ('Shiva',78);

SAVE TRANSACTION Save1;

INSERT INTO Student VALUES ('Sathi',89);

ROLLBACK TRANSACTION Save1;

COMMIT;

DELETE FROM Student WHERE StudentId = 9;

CREATE TABLE StudentAudit(
AuditId INT IDENTITY(1,1) PRIMARY KEY,
StudentId INT,
StudentName VARCHAR(20),
StudentMarks INT,
ActionType VARCHAR(10),
ActionDate DATETIME);

-- TO DROP TRIGGER
DROP TRIGGER trgAfterInsertStudent;
GO

-- TRIGGERS
CREATE TRIGGER trgStudent
ON Student
AFTER INSERT
AS
BEGIN
    INSERT INTO StudentAudit (StudentId, StudentName, StudentMarks, ActionType, ActionDate)
    SELECT StudentId, StudentName, StudentMarks, 'INSERT', GETDATE()
    FROM inserted;
END

INSERT INTO Student(StudentName, StudentMarks)
VALUES ('Shiva', 88);

SELECT * FROM Student;

-- STORED PROCEDURE
GO
CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SELECT * FROM Student;
END

EXEC GetAllStudents;
