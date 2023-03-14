USE [MyLibrary]
GO

-- OrderStatus table manipulations
INSERT INTO [dbo].[OrderStatus] (StatusName)
VALUES ('In use'), ('Returned')
GO


-- Role table manipulations
INSERT INTO [dbo].[Role] (RoleName)
VALUES ('User'), ('Admin')
GO


--Genre table manipulation
INSERT INTO [dbo].[Genre] (Genre)
VALUES ('Dystopia'), ('Fantasy')
GO




--Publisher table manipulation
INSERT INTO [dbo].[Publisher] (PublisherName)
VALUES ('Ecsmo'), ('ACT'), ('HarperCollins'), ('Macmillan Publishers'), ('Hachette Book Group')
GO


--Author table manipulations
INSERT INTO [dbo].[Author] (FirstName, LastName, Birthday)
VALUES 
	('Arthur', 'Conan Doyle', '1859-05-22')
GO

--Person table manipulations
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
	('Admin',
	 'Adminov',
	 '1978-04-13',
	 'admin4ik@gmail.com',
	 'admin',
	 (SELECT TOP 1 RoleId FROM [dbo].[Role] WHERE RoleName = 'Admin'),
	 GETDATE()
	)
GO



----------------------------------------------------------

