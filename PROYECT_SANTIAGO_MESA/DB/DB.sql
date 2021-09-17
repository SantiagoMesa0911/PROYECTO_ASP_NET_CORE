/*CREACION DE BASE DE DATOS*/
Create database Venta
Use Venta

/*CREACION DE TABLAS */
Create table Customer(
Id int NOT NULL PRIMARY KEY,
CreateDate datetime2(7),
UpdateDate datetime2(7),
Isdelete bit,
Name varchar(max),
Email varchar(max) null,
Phone varchar(max),
Adrress varchar(max) null,
Notes varchar(max) null,
)

Create table Product(
Id int NOT NULL PRIMARY KEY,
CreateDate datetime2(7),
UpdateDate datetime2(7),
Isdelete bit,
Name varchar(max),
Code varchar(max),
stock int,
Precio float,
Descripcion varchar(max) null,
Notes varchar(max) null,
)

Create table Provider(
Id int NOT NULL PRIMARY KEY,
CreateDate datetime2(7),
UpdateDate datetime2(7),
Isdelete bit,
Name varchar(max),
Email varchar(max) null,
Phone varchar(max),
Adrress varchar(max) null,
Notes varchar(max) null,
)

Create Table Sales(
Id int NOT NULL PRIMARY KEY,
CreateDate datetime2(7),
UpdateDate datetime2(7),
Isdelete bit,
SalesDate datetime2(7),
SaleCode varchar(max),
Notes varchar(max),
Total float,
Status varchar(max) null,
Discount float null,
GrandTotal float,
PaymentMethod varchar(max) null,
Customerid int
)


Create table Salesitems(
Id int NOT NULL PRIMARY KEY,
CreateDate datetime2(7),
UpdateDate datetime2(7),
IsDelete  bit,
Productid int,
Name varchar(max) null,
Price float,
Quantity int,
Amount float,
Salesid int
)

Create table StoreSetting(
Id int NOT NULL PRIMARY KEY,
CreateDate datetime2(7),
UpdateDate datetime2(7),
IsDelete bit,
Logo varchar(max) null,
StoreName varchar(max),
Email varchar(max),
Web varchar(max),
Phone varchar(max),
Currency varchar(max),
Adrress varchar(max),
)


Create table Users(
Id int NOT NULL PRIMARY KEY,
CreateDate datetime2(7),
UpdateDate datetime2(7),
IsDelete bit,
Email varchar(max),
Password varchar(50),
ConfirmPassword varchar(max)
)

/* FOREIGN KEY */

ALTER TABLE customer
ADD FOREIGN KEY (id) REFERENCES sales(id);

ALTER TABLE sales
ADD FOREIGN KEY (id) REFERENCES salesitems(id);


