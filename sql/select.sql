--create database test;
--go

--use test
--go

---- продукты
--create table [dbo].[Products](
--	[ID] tinyint constraint PK_Products primary key, 
--	[Name] varchar(32) not null,
--)
--go

---- категории
--create table [dbo].[Categories](
--	[ID] tinyint constraint PK_Categories primary key, 
--	[Name] varchar(32) not null
--)
--go

---- категории - продукты
--create table [dbo].[CategoryProducts](
--	[CategoryID] tinyint
--		constraint FK_CategoryID_Categories foreign key references [dbo].[Categories] ([ID]),
--	[ProductID] tinyint
--		constraint FK_ProductID_Products foreign key references [dbo].[Products] ([ID]) 
--		constraint PK_CategoryProducts primary key ([CategoryID], [ProductID])
--)
--go

---- тестовые данные
--insert into [dbo].[Products]
--select 1, 'Продукт 1'
--union all
--select 2, 'Продукт 2'
--union all
--select 3, 'Продукт 3'
--union all
--select 4, 'Продукт 4'
--union all
--select 5, 'Продукт 5'


--insert into Categories
--select 1, 'Категоия 1'
--union all
--select 2, 'Категоия 2'
--union all
--select 3, 'Категоия 3'

--insert into [dbo].[CategoryProducts]
--select 1, 1
--union all
--select 2, 1
--union all
--select 2, 2
--union all
--select 3, 3
--union all
--select 1, 4
--go

select p.[Name] as ProductName, isnull(c.[Name],'Без категории') as CategoryName
from [dbo].[Products] p
		left join [dbo].[CategoryProducts] cp on p.[ID] = cp.[ProductID] 
		left join [dbo].[Categories] c on c.[ID] = cp.[CategoryID]  
go