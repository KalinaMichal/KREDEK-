USE [Test]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[StudentIdent] [numeric](6, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](63) NULL,
	[Autor] [nvarchar](255) NULL,
	[Book] [numeric](3, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IndexPosition]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndexPosition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[BookID] [int] NULL,
	[MovieID] [int] NULL,
	[SongID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[SongsView]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SongsView] 
AS
SELECT c.Name, s.StudentIdent, i.SongID
  FROM IndexPosition i
    JOIN Books c on i.BookID = c.ID
    JOIN Students s on i.StudentID = s.ID;
GO
/****** Object:  View [dbo].[BooksView]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BooksView] 
AS
SELECT c.Name, s.StudentIdent, i.SongID
  FROM IndexPosition i
    JOIN Books c on i.BookID = c.ID
    JOIN Students s on i.StudentID = s.ID;
GO
/****** Object:  View [dbo].[MoviesView]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE VIEW [dbo].[MoviesView] 
AS
SELECT c.Name, s.StudentIdent, i.SongID
  FROM IndexPosition i
    JOIN Books c on i.BookID = c.ID
    JOIN Students s on i.StudentID = s.ID;
GO
/****** Object:  View [dbo].[SongtsView]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE VIEW [dbo].[SongtsView] 
AS
SELECT c.Name, s.StudentIdent, i.SongID
  FROM IndexPosition i
    JOIN Books c on i.BookID = c.ID
    JOIN Students s on i.StudentID = s.ID;
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](63) NULL,
	[Autor] [nvarchar](255) NULL,
	[Movie] [numeric](3, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentIndex]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentIndex](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[BookID] [int] NULL,
	[MovieID] [int] NULL,
	[SongID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Songs]    Script Date: 2018-12-03 15:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Songs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](63) NULL,
	[Autor] [nvarchar](255) NULL,
	[Song] [numeric](3, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[IndexPosition]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([ID])
GO
ALTER TABLE [dbo].[IndexPosition]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([ID])
GO
ALTER TABLE [dbo].[IndexPosition]  WITH CHECK ADD FOREIGN KEY([SongID])
REFERENCES [dbo].[Songs] ([ID])
GO
ALTER TABLE [dbo].[IndexPosition]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[RentIndex]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([ID])
GO
ALTER TABLE [dbo].[RentIndex]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([ID])
GO
ALTER TABLE [dbo].[RentIndex]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
