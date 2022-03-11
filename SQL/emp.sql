use Sample;

create table EmployeeDetail(id int,employeename varchar(200))
select * from EmployeeDetail
insert into EmployeeDetail values(1, 'Jahnavi 1');
insert into EmployeeDetail values(2, 'Jahnavi 2');
insert into EmployeeDetail values(3, 'Jahnavi 3');
insert into EmployeeDetail(ID,employeename, gender,Salary) values(5, 'Jahnavi 4','Female', 20000);
alter table EmployeeDetail add gender varchar(30)
alter table EmployeeDetail add Salary int

update EmployeeDetail set gender='Male'
update EmployeeDetail set gender='Female' where ID in (2,4)

select * from EmployeeDetail order by ID desc

update EmployeeDetail set Salary=16000 where ID in(1)

select sum(Salary) from EmployeeDetail

select avg(Salary) from EmployeeDetail
select Max(Salary) from EmployeeDetail
select min(Salary) from EmployeeDetail