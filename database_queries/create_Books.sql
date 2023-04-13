use Book_Library
go
create table Books(
book_id int Primary Key Identity(1,1) not null,
title varchar(50) not null,
date_release date check(date_release <= getdate()) not null,
genre varchar(20) not null,
quantity_left smallint not null,
author_id int not null Foreign Key References Authors(author_id)
)
go