use Book_Library
go
CREATE TABLE Rentals (
    book_id int,
    reader_id int Identity(1,1),
    PRIMARY KEY (book_id, reader_id),
    FOREIGN KEY (book_id) REFERENCES Books(book_id),
    FOREIGN KEY (reader_id) REFERENCES Readers(reader_id)
)
go