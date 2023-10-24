create database db1

use db1

create table table1(ID int primary key not null identity(1,1),Fname varchar(30), Mname varchar(30),Lname varchar(30), age smallint, Occupation varchar(20))

select * from table1
--insert into table1 values('"+Fname+"','"+Mname+"','"+Lname+"',"+age+",'"+work+"');
