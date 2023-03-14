GO

USE [MyLibrary]

CREATE TABLE [dbo].[Genre](
	[GenreId] [int] NOT NULL IDENTITY(1, 1),
	[Genre] [nvarchar](255) NOT NULL,
	CONSTRAINT [PK_Genre] PRIMARY KEY ([GenreId] ASC)
)
GO

CREATE TABLE [dbo].[Action] (
	[ActionId] [int] IDENTITY(1,1) NOT NULL,
	[ActionName] [nvarchar](20) NOT NULL,
	CONSTRAINT [PK_Action] PRIMARY KEY CLUSTERED ([ActionId] ASC)
)
GO

CREATE TABLE [dbo].[OrderStatus](
	[StatusId] [int] NOT NULL IDENTITY(1, 1),
	[StatusName] [nvarchar](50) NOT NULL,
	CONSTRAINT [PK_OrderStatus] PRIMARY KEY ([StatusId] ASC)
)
GO

CREATE TABLE [dbo].[Publisher](
	[PublisherId] [int] NOT NULL IDENTITY(1, 1),
	[PublisherName] [nvarchar](255) NOT NULL,
	CONSTRAINT [PK_Publiser] PRIMARY KEY ([PublisherId] ASC)
)
GO

CREATE TABLE [dbo].[Role](
	[RoleId] [int] NOT NULL IDENTITY(1, 1),
	[RoleName] [nvarchar](255) NOT NULL,
	CONSTRAINT [PK_Role] PRIMARY KEY ([RoleId] ASC)
)
GO

CREATE TABLE [dbo].[Author](
	[AuthorId] INT NOT NULL IDENTITY(1, 1),
	[FirstName] NVARCHAR(255) NOT NULL,
	[LastName] NVARCHAR(255) NOT NULL,
	[Birthday] DATE NULL,
	CONSTRAINT [PK_Author] PRIMARY KEY ([AuthorId] ASC)
)
GO

CREATE TABLE [dbo].[Book](
	[BookId] INT NOT NULL IDENTITY(1, 1),
	[Name] VARCHAR(255) NOT NULL,
	[AuthorId] INT NOT NULL,
	[PublisherId] INT NULL,
	[Year] INT NOT NULL,
	[ISBN] NVARCHAR(10) NOT NULL,
	CONSTRAINT [PK_Book] PRIMARY KEY ([BookId] ASC),
	CONSTRAINT [IX_Book_ISBN] UNIQUE NONCLUSTERED ([ISBN] ASC),
	CONSTRAINT FK_Book_Author FOREIGN KEY (AuthorId) REFERENCES [dbo].[Author](AuthorId) 
	ON UPDATE CASCADE
	ON DELETE CASCADE,
	CONSTRAINT FK_Book_Publisher FOREIGN KEY (PublisherId) REFERENCES [dbo].[Publisher](PublisherId)
)
GO

--CREATE UNIQUE NONCLUSTERED INDEX [IX_Book_ISBN] ON [dbo].[Book]([BookId] ASC)
--GO

CREATE TABLE [dbo].[BookGenre](
	[BookId] [int] NOT NULL,
	[GenreId] [int] NOT NULL,
	CONSTRAINT [FK_BookGenre_Book] FOREIGN KEY([BookId]) REFERENCES [dbo].[Book] ([BookId])
	ON UPDATE CASCADE
	ON DELETE CASCADE,
	CONSTRAINT [FK_BookGenre_Genre] FOREIGN KEY([GenreId]) REFERENCES [dbo].[Genre] ([GenreId])
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO

CREATE TABLE [dbo].[Person](
	[PersonId] [int] NOT NULL IDENTITY(1, 1),
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[Birthday] [date] NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[RoleId] [int] NOT NULL,
	[IdentificationNumber] [nchar](14) NULL,
	[RegistrationDate] [date] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	CONSTRAINT [PK_Person] PRIMARY KEY ([PersonId] ASC),
	CONSTRAINT [FK_Person_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([RoleId])
)
GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Person_Email] ON [dbo].[Person]
([Email] ASC)
GO

CREATE TABLE [dbo].[BookJournal](
	[RecordId] [int] IDENTITY(1,1) NOT NULL,
	[ActionId] [int] NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[AuthorName] [nvarchar](100) NOT NULL,
	[Date] [date] NOT NULL,
	CONSTRAINT [PK_BookJournal] PRIMARY KEY CLUSTERED ([RecordId] ASC),
	CONSTRAINT [FK_BookJournal_Action] FOREIGN KEY([ActionId]) REFERENCES [dbo].[Action] ([ActionId])
)
GO

CREATE TABLE [dbo].[BookOrder](
	[BookOrderId] [int] NOT NULL IDENTITY(1, 1),
	[PersonId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[StatusId] [int] NOT NULL,
	CONSTRAINT [PK_BookOrder] PRIMARY KEY ([BookOrderId] ASC),
	CONSTRAINT [FK_BookOrder_Book] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Book] ([BookId]),
	CONSTRAINT [FK_BookOrder_OrderStatus] FOREIGN KEY ([StatusId]) REFERENCES  [dbo].[OrderStatus] ([StatusId]),
	CONSTRAINT [FK_BookOrder_Person] FOREIGN KEY ([PersonId]) REFERENCES  [dbo].[Person] ([PersonId])
) 
GO