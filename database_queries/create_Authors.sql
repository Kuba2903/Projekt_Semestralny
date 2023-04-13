use Book_Library
go
create table Authors(
author_id int Primary Key Identity(1,1) not null,
first_name nvarchar(30) not null,
surname nvarchar(30) not null,
date_of_birth date check(date_of_birth < getdate()) not null,
)
go