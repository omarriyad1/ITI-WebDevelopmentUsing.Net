use ASS1DB
--Q1
select * from PROJECT
--Q2
select FNAME,LNAME,SALARY,DNO
FROM EMOLYEE
--Q3
select PNAME,PLOCATION,DNUM
FROM PROJECT
--Q4

--Q5
SELECT SSN,FNAME,LNAME
FROM EMOLYEE
WHERE SALARY>1000
--Q6


--Q7
SELECT FNAME,LNAME,SALARY
FROM EMOLYEE
WHERE SEX='F'
--Q8


--Q9
SELECT PNUMBER , PNAME , PLOCATION
FROM PROJECT
WHERE DNUM=10