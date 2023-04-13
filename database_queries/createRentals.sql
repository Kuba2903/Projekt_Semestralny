use Book_Library
go
create table Rentals(
book_id int Foreign Key References Books(book_id),
reader_id int Foreign Key References Readers(reader_id)
)
go