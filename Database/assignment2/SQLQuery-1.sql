use Company_SD
--Q1
select d.Dname,d.Dname,e.Superssn,e.Fname+' '+e.Lname as manger_name
from Departments d , Employee e
where d.MGRSSN = e.Superssn
--------------
--Q2
select d.Dname , p.Pname
from Departments d , Project p
where d.Dnum = p.Dnum
---------------
--Q3
select Fname+''+Lname as EmpName ,Dependent_name ,d.Sex,d.Bdate
from Employee e , Dependent d
where e.SSN=  d.ESSN 
----------------
--Q4
select Pnumber , Pname , Plocation
from Project
where Plocation like '%Cairo%' Or Plocation like '%Alex%'
-----------------
--Q5
select Pname,Pnumber  , Plocation
from Project
where Pname like 'a%' 
------------------
--Q6
select Fname+''+Lname as EmpName,e.SSN,Salary
from Employee e 
where e.Dno=30 and  Salary < 2000 or Salary>1000

-------------------
--Q7
select e.Fname+''+e.Lname as EmpName  
from Employee e , Works_for w, Project p
where w.ESSn=e.SSN and w.Pno =p.Pnumber and  w.Hours>=10 and e.Dno=10 and P.Pname='%Rabwah%'
--------------------
--Q8
select o1.Fname+' '+o1.Lname as EmpName  
from Employee o1 ,Employee o2
where o2.SSN=o1.Superssn and o2.Fname='Kamel'
---------------------
--Q9
select e.Fname+''+e.Lname as EmpName ,p.Pname
from Employee e , Works_for w ,Project p
where w.ESSn=e.SSN and w.Pno =p.Pnumber 
ORDER BY(p.Pname) 
----------------------
--Q10
select p.Pnumber ,d.Dname,e.Lname ,e.Address ,e.Bdate
from project p ,Departments d,Employee e
where p.Dnum=d.Dnum and d.MGRSSN=e.Superssn and p.City='Cairo'
-----------------------
--Q11
select o2.Superssn, o2.Fname+''+o2.Lname as ManagerName,o2.Sex,o2.Salary,o2.Dno,o2.Address,o2.Bdate
from Employee o1 ,Employee o2
where o1.SSN=o2.Superssn
------------------------
--Q12
select e.*,d.*
from Employee e left outer join Dependent d
on e.SSN=d.ESSN
------------------------
--Q13
insert into Employee(Dno,SSN,Superssn,Salary,Fname,Lname,Sex)
values(30,102672,112233,3000,'omar','riyad','m')
-------------------------
--Q14
insert into Employee(Dno,SSN,Fname,Lname,Sex)
values(30,102660,'osama','wakeed','m')
-------------------------
--Q15
update Employee
set Salary=Salary*1.2
where SSN=102672
