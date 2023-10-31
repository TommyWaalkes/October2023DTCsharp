 --create database School; 
--drop table Students; 
--drop table Teachers; 

----One to Many 
--  --Make the table you wish to reference first. 
--create table Teachers(
--	id int primary key identity(1,1), 
--	[name] nvarchar(25) not null, 
--	yearsTaught int
--);

--create table Students(
--	id int primary key identity(1,1), 
--	[name] nvarchar(25),
--	teacherId int foreign key references Teachers(id)
--);

--insert into Teachers
--values('Mr. Clean', 50),
--('Mr. Mean', 300),  
--('Mrs. Banks', 15),
--('Mr. Bean', 25)

--insert into Students
--values('Sneezey', 4), 
--('Frankie', 4), 
--('Sporkboy', 5), 
--('Sarah', 6), 
--('Sally', 5),
--('Larva Girl', 6); 

--select * from Teachers; 
--select * from Students; 

--One to Ones 
--True one to ones aren't possible since both sides would need a foreign, 
--but how you make foreign for 2 tables at the same time and how 
--do you fill out rows without rows in the other table?
--create table Room(
--	id int primary key identity(1,1), 
--	teacherId int unique foreign key references Teachers(id)
--);

--insert into Room
--values(4),  
--(5) 

--select * from Room; 
--select * from Teachers

-- Many to Many Relationship 
-- Make 2 tables and make a 3rd with foreign keys acting 
-- as the overlap between the 2. Values may repeat in a many to 
-- many as much you want. 

--create table Subs(
--	id int primary key identity(1,1), 
--	[name] nvarchar(25)
--);

--create table Schools(
--	id int primary key identity(1,1), 
--	[name] nvarchar(20)
--);

--create table SubSchoolsDates(
--	id int primary key identity(1,1), 
--	schoolId int foreign key references Schools(id), 
--	subId int foreign key references Subs(id), 
--	dateTaught date 
--); 

--insert into Schools
--values('Hope College'),
--('Calvin College'), 
--('Clown School');

--insert into Subs 
--values('Mr. Hairtree'), 
--('Dr. Peaches'), 
--('Dr. Phil');

--insert into SubSchoolsDates
--values(1,1, '2019-04-11'),
--(3,3, '2021-5-3'),
--(1, 2, '2022-12-7')

--select * from Subs; 
--select * from Schools
--select * from SubSchoolsDates;