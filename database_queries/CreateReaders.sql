USE [Book_Library]
GO

/****** Object:  Table [dbo].[Readers]    Script Date: 20.05.2023 11:54:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Readers](
	[reader_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](30) NOT NULL,
	[last_name] [nvarchar](30) NOT NULL,
	[phone_number] [char](9) NOT NULL,
	[return_date] [date] NOT NULL,
	[book_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[reader_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Readers]  WITH CHECK ADD FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO

ALTER TABLE [dbo].[Readers]  WITH CHECK ADD  CONSTRAINT [chk_phone_number] CHECK  ((len([phone_number])=(9)))
GO

ALTER TABLE [dbo].[Readers] CHECK CONSTRAINT [chk_phone_number]
GO

ALTER TABLE [dbo].[Readers]  WITH CHECK ADD CHECK  (([return_date]>getdate() AND [return_date]<dateadd(month,(3),getdate())))
GO

