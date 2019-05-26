use bestowers;
select * from appuser;


INSERT INTO [Bestowers].[dbo].[AppUser]
           ([UserName]
           ,[Password]
           ,[FirstName]
           ,[LastName]
           ,[Email]
           ,[RoleID]
           ,[PasswordExpired])
     VALUES
           ('samah'
           ,'romangoddess72624'
           ,'Samah'
           ,'Nabi'
           ,'samah@bestowers.org'
           ,2, 0);
           
           
    INSERT INTO [Bestowers].[dbo].[AppUser]
           ([UserName]
           ,[Password]
           ,[FirstName]
           ,[LastName]
           ,[Email]
           ,[RoleID]
           ,[PasswordExpired])
     VALUES
           ('tahsin'
           ,'64683636'
           ,'Tahsin'
           ,'Nabi'
           ,'tahsin@bestowers.org'
           ,2, 0);

           
    INSERT INTO [Bestowers].[dbo].[AppUser]
           ([UserName]
           ,[Password]
           ,[FirstName]
           ,[LastName]
           ,[Email]
           ,[RoleID]
           ,[PasswordExpired])
     VALUES
           ('unur'
           ,'samahnabi2000'
           ,'Umme Safa'
           ,'Nur'
           ,'unur@bestowers.org'
           ,2, 0);

GO

select * from appuser;
go