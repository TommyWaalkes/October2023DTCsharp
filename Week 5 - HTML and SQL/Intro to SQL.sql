-- Create database MovieTheater;
--Create table Movies(
--id int primary key identity(1,1),
--[name] nvarchar(20), 
--runTime int, 
--releaseYear int,
--genre nvarchar(20)
--)

--insert into Movies 
--values('Shrek', 300, 2001, 'Comedy/Animated'),
--('Star Wars', 130, 1974, 'Sci-Fi'), 
--('The God Father', 180, 1970, 'Drama')



--update Movies 
--set [name]='Holiday Special' 
--where id = 2 

--delete from Movies 
--where [name] = 'holiday special';

 --drop table Movies;
 drop database MovieTheater;

--select * from Movies; -- Memorize this line, but we use a lot 