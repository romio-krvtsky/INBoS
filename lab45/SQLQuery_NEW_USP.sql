USE [MyLibrary]
GO

/****** Object:  StoredProcedure [dbo].[usp_UpdateUser]    Script Date: 11/3/2021 6:14:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_UpdateUser]
	@Id INT,
	@firstName NVARCHAR(100),
	@lastName NVARCHAR(100),
	@email NVARCHAR(100),
	@password NVARCHAR(100),
	@date DATE,
	@roleId INT
AS
BEGIN
UPDATE [Person]
SET 
	FirstName = @firstName,
	LastName = @lastName,
	Birthday = @date,
	Email = @email,
	Password = @password,
	RoleId = @roleId
WHERE PersonId = @Id
END
GO


CREATE PROCEDURE [dbo].[usp_UpdateBook]
	@id INT,
	@name VARCHAR(255),
	@authorId INT,
	@publisherId INT,
	@ISBN NVARCHAR(10),
	@year int
AS
BEGIN
UPDATE [dbo].[Book]
SET 
	Name = @name,
	AuthorId = @authorId,
	PublisherId = @publisherId,
	Year = @year,
	ISBN = @ISBN
WHERE BookId = @id

INSERT INTO [dbo].[BookJournal] (ActionId, BookName, AuthorName, Date)
VALUES (
	(SELECT ActionId FROM Action WHERE ActionName = 'Updated'),
	@name,
	(SELECT FirstName + ' ' + LastName FROM [Author] WHERE AuthorId = @authorId),
	GETDATE()); 
END
GO

CREATE PROC [dbo].[usp_TakeBook]
	@bookId INT,
	@userId INT
AS
BEGIN

DECLARE @newStatusId AS INT
SELECT @newStatusId = [StatusId]
FROM [OrderStatus]
WHERE StatusName = 'In use'

IF (SELECT COUNT(*) FROM [BookOrder] WHERE BookId = @bookId AND PersonId = @userId) > 0
	UPDATE [BookOrder]
	SET 
		StatusId = @newStatusId, 
		OrderDate = GETDATE()
	WHERE BookId = @bookId AND PersonId = @userId
ELSE
	INSERT INTO [BookOrder] (BookId, PersonId, StatusId, OrderDate)
	VALUES(@bookId, @userId, @newStatusId, GETDATE())
INSERT INTO [dbo].[BookJournal] (ActionId, BookName, AuthorName, Date)
VALUES (
	(SELECT ActionId FROM Action WHERE ActionName = 'In use'),
	(SELECT Name FROM [Book] WHERE BookId = @bookId),
	(SELECT FirstName + ' ' + LastName FROM [Book] b JOIN [Author] a ON b.AuthorId = a.AuthorId WHERE b.BookId = @bookId),
	GETDATE()); 
END
GO

CREATE PROC [dbo].[usp_ReturnBook]
	@id INT
AS
BEGIN
UPDATE [BookOrder]
SET StatusId = (SELECT TOP 1 StatusId FROM [OrderStatus] WHERE StatusName = 'Returned')
WHERE BookId = @id

INSERT INTO [dbo].[BookJournal] (ActionId, BookName, AuthorName, Date)
VALUES (
	(SELECT ActionId FROM [Action] WHERE ActionName = 'Returned'),
	(SELECT Name FROM [Book] WHERE BookId = @id),
	(SELECT TOP 1 FirstName + ' ' + LastName FROM [Book] INNER JOIN [Author] ON Book.AuthorId = Author.AuthorId WHERE BookId = @id),
	GETDATE()
);
END
GO

CREATE PROC [dbo].[usp_RegisterUser]
	@firstName NVARCHAR(100),
	@lastName NVARCHAR(100),
	@email NVARCHAR(100),
	@password NVARCHAR(100),
	@date DATE,
	@roleId INT
AS
BEGIN
INSERT INTO [dbo].[Person]
	(FirstName,
	 LastName,
	 Birthday,
	 Email,
	 Password,
	 RoleId,
	 RegistrationDate
)
VALUES
	(@firstName,
	 @lastName,
	 @date,
	 @email,
	 @password,
	 @roleId,
	 GETDATE()
	)
END
GO

CREATE PROCEDURE [dbo].[usp_LoginUser]
	@email NVARCHAR(100),
	@password NVARCHAR(100)
AS
BEGIN
	SELECT PersonId AS Id, FirstName, LastName, RoleName
	FROM [Person] JOIN [Role] ON Person.RoleId = Role.RoleId
	WHERE Email = @email AND Password = @password
END
GO

CREATE PROC [dbo].[usp_GetUsers]
AS
BEGIN
SELECT PersonId AS Id, FirstName, LastName, Email, Password, RoleName 
FROM [Person] JOIN [Role] ON Person.RoleId = Role.RoleId
END
GO

CREATE PROC [dbo].[usp_GetUser]
	@Id INT
AS
BEGIN
SELECT PersonId AS Id, FirstName, LastName, Email, Password, Birthday, RoleName 
FROM [Person] JOIN [Role] ON Person.RoleId = Role.RoleId
WHERE PersonId = @Id
END
GO

CREATE PROC [dbo].[usp_GetBooksForUser]
	@id INT
AS
BEGIN
SELECT 
	b.BookId AS Id,
	Name,
	(FirstName + ' ' + LastName) AS Author,
	PublisherName AS Publisher,
	Year,
	ISBN,
	IIF(StatusName IS NULL, 'Returned', StatusName) AS StatusName
FROM [Book] b JOIN [Author] ON b.AuthorId = Author.AuthorId 
			JOIN [Publisher] ON b.PublisherId = Publisher.PublisherId
			LEFT JOIN ([BookOrder] bo JOIN [OrderStatus] bs ON bo.StatusId = bs.StatusId)
			ON b.BookId = bo.BookId
WHERE bo.PersonId = @id AND bs.StatusName = 'In use'
END
GO

CREATE PROC [dbo].[usp_GetBooks]
AS
BEGIN
SELECT 
	b.BookId AS Id,
	Name,
	(FirstName + ' ' + LastName) AS Author,
	PublisherName AS Publisher,
	Year,
	ISBN,
	IIF(StatusName IS NULL, 'Returned', StatusName) AS StatusName
FROM [Book] b JOIN [Author] ON b.AuthorId = Author.AuthorId 
			JOIN [Publisher] ON b.PublisherId = Publisher.PublisherId
			LEFT JOIN ([BookOrder] bo JOIN [OrderStatus] bs ON bo.StatusId = bs.StatusId)
			ON b.BookId = bo.BookId
END
GO

CREATE PROC [dbo].[usp_GetAllPublishers]
AS
BEGIN
	SELECT PublisherId, PublisherName
	FROM [Publisher]
END
GO

CREATE PROC [dbo].[usp_GetAllAuthors]
AS
BEGIN
	SELECT AuthorId, (FirstName + ' ' + LastName) As Name
	FROM [Author]
END
GO

CREATE PROC [dbo].[usp_DeleteUser]
	@Id INT
AS
BEGIN

DELETE FROM [BookOrder]
WHERE PersonId = @Id
	
DELETE FROM [Person]
WHERE PersonId = @Id

END
GO

CREATE PROCEDURE [dbo].[usp_DeleteBook]
	@id INT
AS
BEGIN
IF (SELECT COUNT(*) FROM [BookOrder] WHERE BookId = @id) != 0
	EXEC usp_ReturnBook @id;
INSERT INTO [dbo].[BookJournal] (ActionId, BookName, AuthorName, Date)
VALUES (
	(SELECT ActionId FROM [Action] WHERE ActionName = 'Deleted'),
	(SELECT Name FROM [Book] WHERE BookId = @id),
	(SELECT TOP 1 FirstName + ' ' + LastName FROM [Book] INNER JOIN [Author] ON Book.AuthorId = Author.AuthorId WHERE BookId = @id),
	GETDATE()
);

DELETE FROM [BookGenre] 
WHERE BookId = @id

DELETE FROM [dbo].[Book]
WHERE BookId = @id;

END
GO

CREATE PROCEDURE [dbo].[usp_AddNewBook]
	@name VARCHAR(255),
	@authorId INT,
	@publisherId INT,
	@ISBN NVARCHAR(10),
	@year int
AS
BEGIN
INSERT INTO [Book] (Name, ISBN, AuthorId, PublisherId, Year)
VALUES 
	(@name,
	@ISBN,
	@authorId,
	@publisherId,
	@year);
INSERT INTO [BookJournal] (ActionId, BookName, AuthorName, Date)
VALUES (
	(SELECT ActionId FROM Action WHERE ActionName = 'Added'),
	@name,
	(SELECT FirstName + ' ' + LastName FROM [Author] WHERE AuthorId = @authorId),
	GETDATE());
END
GO