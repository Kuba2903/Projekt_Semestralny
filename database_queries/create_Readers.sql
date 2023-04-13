use Book_Library
go
create table Readers(
reader_id int Primary Key Identity(1,1) not null,
first_name nvarchar(30) not null,
last_name nvarchar(30) not null,
phone_number char(9) not null,
book_id int not null Foreign Key References Books(book_id),
return_date date check(return_date > getdate()) not null,
penalty_amount smallmoney
)
go