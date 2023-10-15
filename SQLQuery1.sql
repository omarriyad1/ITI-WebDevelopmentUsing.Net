create table department(
id int primary key,
name varchar(50),
location varchar(50),
)
create Table Student (
id int primary key,
name varchar(50),
Addresse varchar(50),
Deptid int references department Not Null,
)
