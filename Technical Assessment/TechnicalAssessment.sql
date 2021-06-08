--delete from [dbo].[Users]
--delete from [dbo].[BlogPost]
--delete from [dbo].[BlogPostComment]

--DBCC CHECKIDENT ('[dbo].[BlogPostComment]', RESEED, 0)
--DBCC CHECKIDENT ('[dbo].[Users]', RESEED, 0)
--DBCC CHECKIDENT ('[dbo].[BlogPost]', RESEED, 0)


CREATE TABLE dbo.[Users]
(
  [Id] int primary key identity,
  [UserName] nvarchar(100),
  [FullName] nvarchar(100),
  [Email] nvarchar(100),
  [PhoneNumber] nvarchar(100),
)
GO


CREATE TABLE dbo.[BlogPost]
(
  [Id] int primary key identity,
  [Title] varchar(1000),
  [Text] nvarchar(max),
  [Date] datetime,
  [UserId] int foreign key references dbo.[Users](Id)
)
GO

CREATE TABLE dbo.[BlogPostComment]
(
  [Id] int primary key identity,
  [Text] nvarchar(max),
  [Like] int,
  [Dislike] int,
  [Date] datetime,
  [BlogPostId] int foreign key references [dbo].[BlogPost](Id),
  [UserId] int foreign key references dbo.[Users](Id)
)

GO


insert into dbo.[Users] values ('Admin' , null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 1', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 2', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 3', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 4', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 5', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 6', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 7', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 8', null, 'abc@xyz.com', '01767409798')
insert into dbo.[Users] values ('User 9', null, 'abc@xyz.com', '01767409798')


insert into dbo.[BlogPost] values ('Blog 1', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 2', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 3', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 4', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 5', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 6', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 7', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 8', null, '01-03-2021', 1)
insert into dbo.[BlogPost] values ('Blog 9', null, '01-03-2021', 1)


insert into dbo.[BlogPostComment] values ('Comment 1', 300, 120, '01-03-2021', 1, 2)
insert into dbo.[BlogPostComment] values ('Comment 2', 300, 120, '01-03-2021', 1, 3)
insert into dbo.[BlogPostComment] values ('Comment 3', 300, 120, '01-03-2021', 1, 2)
insert into dbo.[BlogPostComment] values ('Comment 4', 300, 120, '01-03-2021', 2, 4)
insert into dbo.[BlogPostComment] values ('Comment 5', 300, 120, '01-03-2021', 2, 5)
insert into dbo.[BlogPostComment] values ('Comment 6', 300, 120, '01-03-2021', 3, 6)
insert into dbo.[BlogPostComment] values ('Comment 7', 300, 120, '01-03-2021', 3, 7)
insert into dbo.[BlogPostComment] values ('Comment 8', 300, 120, '01-03-2021', 4, 8)



select * from [dbo].[Users]
select * from [dbo].[BlogPost]
select * from [dbo].[BlogPostComment]



