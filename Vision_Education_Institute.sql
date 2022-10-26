create database Vision_Education_Institute;

use Vision_Education_Institute;

create table Login
(Login_ID int primary key,
User_Names varchar (20),Passwords nvarchar (8)
);


create table Students 
(Student_No varchar (10) primary key, 
Student_Name varchar (50) not null,
Birthday date not null,
NIC_No varchar (12) not null, 
Gender varchar (10) not null,
Address varchar (100) not null,
Contact_No int not null,
Gmail varchar (25) not null, 
Grade varchar (10) not null,
Subject_1 varchar (20) not null,
Subject_2 varchar (20) not null,
Subject_3 varchar (20) not null);




create table Staff 
(Staff_No varchar (10) primary key,
Staff_Name varchar (50) not null, 
Birthday date not null, 
NIC_No varchar (12) not null,
Gender varchar (10) not null, 
Address varchar (100) not null,
Contact_No int not null, 
Position varchar (20) not null);



create table Teachers 
(Teacher_No varchar (10) primary key, 
Teacher_Name varchar (50) not null,
Birthday date not null, 
NIC_No varchar (12) not null, 
Gender varchar (10) not null,
Address varchar (100) not null,
Contact_No int not null,
Gmail varchar (25) not null,
Subject varchar (10)not null);



create table Students_Attendence
(Student_No varchar (10) references Students (Student_No),
Date date default getdate());

create table  Teachers_Attendence
(Teacher_No varchar (10) references Teachers (Teacher_No),
Date date default getdate());

create table Staff_Attendence
(Staff_No varchar (10) references Staff (Staff_No),
Date date default getdate());



create table Class_Fees
(Recipt_No varchar (10) primary key,
Student_no varchar (10),
Date date not null,
Description nvarchar (100) not null,
Amount decimal (6,2) not null);

create table Payment
(Cheque_No varchar (10) primary key,
Description nvarchar (100) not null,
Date date not null, 
Amount decimal (6,2) not null);

insert into Login (Login_ID ,User_Names,Passwords )
values (01,'Admin',N'Ad@123');




