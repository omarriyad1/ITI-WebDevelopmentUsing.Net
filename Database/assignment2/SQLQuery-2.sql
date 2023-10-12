use day3
create table Instructor(
ID int primary key identity (1,1),
hirdate date default CURRENT_TIMESTAMP,
Address varchar(20),
BD date,
Salary int default 3000,
Overtime int ,
Age as (2023-BD )persisted,
Netsalary as (Salary+Overtime)persisted,
First varchar(20),
last varchar(20),
constraint c7 unique (Overtime),
constraint c5 check (Address in ( 'alex' , 'cairo')) ,

constraint c4 check (Salary between 1000 and 5000 ) 
)
create table Course(
CID int primary key identity (1,1),
CName varchar(20),
Duration int
constraint c10 unique (Duration),
)
create table Tech(
id int ,
Cid int,
constraint c6 primary key (id,cid),
constraint c3 foreign Key( Cid ) references Course(CID) on delete cascade on update cascade  ,
constraint c2 foreign Key( id ) references Instructor(ID) on delete cascade on update cascade 
)
create table Lab(
LID int ,
Cid int,
constraint c16 primary key (LID,Cid),
Location Varchar(20),
Capacity int,
constraint c8 check (Capacity<20) ,
constraint c1 foreign Key(Cid) references Course(CID) on delete cascade on update cascade 
)
