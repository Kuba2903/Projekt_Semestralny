USE [Book_Library]
GO

/****** Object:  Table [dbo].[Rentals]    Script Date: 20.05.2023 11:57:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rentals](
	[rental_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NOT NULL,
	[reader_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rental_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO

ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD FOREIGN KEY([reader_id])
REFERENCES [dbo].[Readers] ([reader_id])
GO

