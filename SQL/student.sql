create database Sample
use Sample;
create table student(rollno int, name varchar(200), gender varchar(200),class varchar(200))
insert into student values(11,'Jahnavi','female','Post graduation')
insert into student values(12,'YAsaswini','female','Bachelor')
select * from student 

create table course(courseID int, courseName varchar(200))
insert into course values(1201,'Computer science')
insert into course values(1202,'Finance')
select * from course