create database sample

use sample;
create table Employee(empID int,empName varchar(2000),gender varchar(200),Salary int)
insert into Employee values(1, 'Jahnavi', 'Female',30000)
insert into Employee values(2, 'Yasaswini', 'Female',30000)
select * from Employee

create table department(deptID int,deptname varchar(2000))
insert into department values(10,'Jahnavi')
insert into department values(20,'Yasaswini')
select * from department


