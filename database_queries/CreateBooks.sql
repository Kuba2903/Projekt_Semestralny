USE [Book_Library]
GO

/****** Object:  Table [dbo].[Books]    Script Date: 20.05.2023 11:52:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[date_release] [date] NOT NULL,
	[genre] [varchar](20) NOT NULL,
	[author_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD FOREIGN KEY([author_id])
REFERENCES [dbo].[Authors] ([author_id])
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD CHECK  (([date_release]<=getdate()))
GO

