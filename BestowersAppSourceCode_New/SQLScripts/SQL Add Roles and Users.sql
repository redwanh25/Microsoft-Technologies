-- scripts to create role table and app users

USE [Bestowers]
GO


INSERT INTO [Bestowers].[dbo].[Role]
           ([Name])
           
     VALUES
           ('Directors');
           
           INSERT INTO [Bestowers].[dbo].[Role]
           ([Name])
           
     VALUES
           ('Affiliate');

INSERT INTO [Bestowers].[dbo].[Role]
           ([Name])
           
     VALUES
           ('Guest');
           
go

INSERT INTO [Bestowers].[dbo].[AppUser]
           ([UserName]
           ,[Password]
           ,[FirstName]
           ,[LastName]
           ,[Email]
           ,[RoleID]
           ,[PasswordExpired])
     VALUES
           ('rnabi'
           ,'apollo'
           ,'Reza'
           ,'Nabi'
           ,'reza@bestowers.org'
           ,1, 0);
           
           
    INSERT INTO [Bestowers].[dbo].[AppUser]
           ([UserName]
           ,[Password]
           ,[FirstName]
           ,[LastName]
           ,[Email]
           ,[RoleID]
           ,[PasswordExpired])
     VALUES
           ('tamjid'
           ,'apollo'
           ,'Tamjidur'
           ,'Choudhury'
           ,'tamjid@bestowers.org'
           ,1, 0);

           
    INSERT INTO [Bestowers].[dbo].[AppUser]
           ([UserName]
           ,[Password]
           ,[FirstName]
           ,[LastName]
           ,[Email]
           ,[RoleID]
           ,[PasswordExpired])
     VALUES
           ('mahalim'
           ,'apollo'
           ,'MA Halim'
           ,'Miah'
           ,'mahalim@bestowers.org'
           ,1, 0);

GO

select * from appuser;
go
