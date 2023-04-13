use Book_Library
go
Alter table Readers
Add date_of_loan date check(date_of_loan <= getdate()) not null
go