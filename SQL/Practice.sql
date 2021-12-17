CREATE DATABASE Practice;

CREATE TABLE Department(
    ID INT NOT NULL PRIMARY KEY,
    DeptName VARCHAR(32) NOT NULL,
    DeptLocation VARCHAR(128) NOT NULL
);

CREATE TABLE Employee(
    ID INT NOT NULL PRIMARY KEY,
    FirstName VARCHAR(16) NOT NULL,
    LastName VARCHAR(16) NOT NULL,
    SSN INT NOT NULL,
    DeptID INT NOT NULL
    FOREIGN KEY (DeptID) REFERENCES Department(ID)
)

CREATE TABLE EmpDetails(
    ID INT NOT NULL,
    EmployeeID INT NOT NULL,
    Salary MONEY NOT NULL,
    Address1 VARCHAR(128) NOT NULL,
    Address2 VARCHAR(128) NOT NULL,
    City VARCHAR(16) NOT NULL,
    State VARCHAR(16) NOT NULL,
    Country VARCHAR(16) NOT NULL,
    PRIMARY KEY (ID, EmployeeID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(ID)
);

ALTER TABLE EmpDetails ALTER COLUMN Address2 VARCHAR(128);

INSERT Department VALUES (1, 'Marketing', '203A'), (2, 'Finance', '309A'), (3, 'Human Resource', '101B');
SELECT * FROM Department;

INSERT Employee 
VALUES 
(100, 'Tina', 'Smith', 123957890, 1),
(101, 'John', 'Doe', 112891594, 1),
(102, 'Jane', 'Smith', 122898404, 3),
(103, 'Daniel', 'Zheng', 14884651, 2),
(104, 'Donald', 'Milier', 1174581533, 3),
(105, 'James', 'Davis', 135445536, 2);
SELECT * FROM Employee;

INSERT EmpDetails
VALUES
(1, 100, 50000, '123 45th ST', NULL, 'Queens', 'NY', 'USA'),
(2, 101, 52000, '75 20th ST', NULL, 'Flushing', 'NY', 'USA'),
(3, 102, 45000, '123 45th ST', NULL, 'Queens', 'NY', 'USA'),
(4, 103, 45000, '893 88th ST', NULL, 'Brooklyn', 'NY', 'USA'),
(5, 104, 43000, '200 78th ST', NULL, 'New York', 'NY', 'USA'),
(6, 105, 51000, '111 Canal ST', NULL, 'New York', 'NY', 'USA');
SELECT * FROM Department;
SELECT * FROM Employee;
SELECT * FROM EmpDetails;

-- DELETE FROM EmpDetails WHERE ID = 5 OR ID = 6;

-- List all employees in Marketing
SELECT Employee.ID AS EmplyeeID, (FirstName +' ' + LastName) AS EmployeeName, DeptName
FROM Employee 
INNER JOIN Department ON DeptID = Department.ID
WHERE DeptName='Marketing';

-- Report total salary of Marketing
SELECT SUM(Salary) AS MarketingTotalSalary
FROM EmpDetails 
INNER JOIN Employee ON EmployeeID = Employee.ID
INNER JOIN Department ON DeptID = Department.ID
WHERE DeptName='Marketing';

-- Report total employees by department
SELECT COUNT(Employee.ID) AS MarketingTotalEmployee,
(SELECT COUNT(Employee.ID) AS FinanceTotalEmployee FROM Employee
INNER JOIN Department ON DeptID = Department.ID
WHERE DeptName='Finance') AS FinanceTotalEmployee,
(SELECT COUNT(Employee.ID) AS HRTotalEmployee FROM Employee
INNER JOIN Department ON DeptID = Department.ID
WHERE DeptName='Human Resource') AS HRTotalEmployee
FROM Employee
INNER JOIN Department ON DeptID = Department.ID
WHERE DeptName='Marketing';

-- Increase salary of Tina Smith to $90,000
UPDATE EmpDetails set Salary=90000 
WHERE EmployeeID = (SELECT ID FROM Employee WHERE FirstName='Tina' AND LastName='Smith');

SELECT EmployeeID, (FirstName +' ' + LastName) AS EmployeeName, Salary 
FROM EmpDetails
INNER JOIN Employee 
ON EmployeeID = Employee.ID -- connction btw two table
WHERE FirstName='Tina' AND LastName='Smith';