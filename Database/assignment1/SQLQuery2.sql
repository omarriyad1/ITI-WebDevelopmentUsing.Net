USE Company_SD
--Q1
SELECT * from Employee
--Q2
select Fname , Lname,Salary,Dno
from Employee
--Q3
select Pname,Plocation,Dnum
FROM Project
--Q4
select (Fname+''+Lname) as FullName ,(Salary*12)*0.1 as  ANNUAL_COMM
from Employee
--Q5
SELECT SSN,Fname,Lname
FROM Employee
WHERE Salary>1000
--Q6
select SSN,Fname,Lname
FROM Employee
WHERE Salary*12 >10000
--Q7
SELECT Fname,Lname,Salary
FROM Employee
WHERE Sex='F'
--Q8
select Dnum,Dname
from Departments
where MGRSSN=968574
--Q9
SELECT Pnumber , Pname , Plocation
FROM Project
WHERE Dnum=10
--------------------------------------------------
--assignment2


--Q1
