CREATE DATABASE TecnoRepuestosDB;
GO
use TecnoRepuestosDB

--tabla roles
create table Role(
Id int identity(1,1) primary key,
RoleType varchar(45)
)
 --table users--
create table Users(
Id int identity(1,1) primary key,
RoleId int not null,
Name varchar(45) not null,
LastName varchar(45) not null,
UserName varchar(45) not null,
Password varchar(45) not null,
Email varchar(45) not null,
Telephone varchar(20) not null,
DUI varchar(10) not null,
Foreign key (RoleId) references Role(Id)
)

--table clientes--
create table Customers(
Id int identity(1,1) primary key,
Name varchar(45) not null,
LastName varchar(45) not null,
Address varchar(50) not null,
DUI varchar(10) not null,
Email varchar(45) not null,
Telephone varchar(20) not null,
NRC varchar(20),
CustomerType varchar(45)
)

--table de datos de la empresa--
create table CompanyData(
Id int identity(1,1) primary key,
Name varchar(45) not null,
Address varchar(50) not null,
BusinessName varchar(50) not null,
TypeBusiness varchar(50) not null,
NRC varchar(20) not null,
NIT  varchar(20) not null,
Telephone varchar(20) not null,
Email varchar(45) not null,
)

--tabla de proveedores--
create table Suppliers(
Id int identity(1,1) primary key,
SupplierName varchar(45) not null,
ContacName varchar(45) not null,
NIT  varchar(20) not null,
NRC varchar(20),
Telephone varchar(20) not null,
Email varchar(45) not null,
Address varchar(50) not null,
IsTaxPayer bit not null
)

--tabla de categoria de productos--
create table CategoryProducts(
Id int identity(1,1) primary key,
CategoryName varchar(45) not null,
)

--tabla productos--
create table Products(
Id int identity(1,1) primary key,
CategoryId int not null,
Code varchar(45) not null,
Brand varchar(45) not null,
ProductName varchar(45),
Model varchar(45),
UnitCost decimal (12,2) not null,
UnitPrice decimal (12,2) not null,
Quantity int not null ,
IsAvailable bit not null,
ImgPath varchar 
)

--tabla compras--
create table Purchases(
Id int identity(1,1) primary key,
SupplierId int not null,
Date date not null,
InvoiceNumber varchar(45) not null,
PurchaseType varchar(45) not null,
PaymentType varchar(45) not null,
Foreign key (SupplierId) References Suppliers(Id)
)

--tabla detalles de compras--
create table PurchaseDetails(
Id int identity(1,1) primary key,
PurchaseId int not null,
ProductId int not null,
Quantity int not null ,
UnitCost decimal (12,2) not null,
SubTotal decimal (12,2) not null,
IVA decimal (12,2) not null,
Total decimal (12,2) not null,
Foreign key (PurchaseId) References Purchases(Id),
Foreign key (ProductId)  References Products(Id)
)

--secuencia para numero de ventas--
CREATE SEQUENCE SaleNumberSequence
    AS INT
    START WITH 100    -- número inicial (puedes cambiarlo)
    INCREMENT BY 1;    -- incremento entre cada valor
GO

--tabla ventas--
create table Sales(
Id int identity(1,1) primary key,
UserId int not null,
CompanyDataId int not null,
CustomerId int not null,
SaleDate date not null,
PaymentMethod varchar(50) not null,
Status varchar(45) not null,
SaleNumber INT default(NEXT VALUE FOR SaleNumberSequence),
UpdateAt datetime not null,
Foreign key (UserId) References Users(Id),
Foreign key (CompanyDataId) References CompanyData(Id),
Foreign key (CustomerId) References Customers(Id),
)

--tabla detalles de ventas--
create table SaleDetails(
Id int identity(1,1) primary key,
SaleId int not null,
ProductId int not null,
Quantity int not null,
UnitPrice decimal(12,2) not null,
SubTotal decimal(12,2) not null,
IVA decimal(12,2) not null,
Total decimal(12,2) not null,
Foreign key (SaleId) References Sales(Id),
Foreign key (ProductId) References Products(Id)
)

--tabla cuentas por pagar--
create table AccountPaybles(
Id int identity(1,1) primary key,
PurchaseId int not null,
StartDate date not null,
EndDate date not null,
TotalAmount decimal(12,2) not null,
PaidAmount decimal(12,2) not null,
Status varchar(45) not null,
UpdateAt datetime not null,
Foreign key (PurchaseId) References Purchases(Id)
)

--tabla cuentas por cobrar--
create table AccountsReceivable(
Id int identity(1,1) primary key,
SaleId int not null,
CustomerId int not null,
StartDate date not null,
EndDate date not null,
TotalAmount decimal(12,2) not null,
PaidAmount decimal(12,2) not null,
Status varchar(45) not null,
UpdateAt datetime not null,
Foreign key (SaleId) References Sales(Id),
Foreign key (CustomerId) References Customers(Id)
)

--tabla devoluciones a proveedores--
create table SupplierReturns(
Id int identity(1,1) primary key,
PurchaseId int not null,
ProductId int not null,
DateReturn date not null,
Quantity int not null,
Reaseon text not null,
Foreign key (PurchaseId) References Purchases(Id),
Foreign key (ProductId) References Products(Id)
)

--tabla devoluciones a clientes--
create table CustomerReturns(
Id int identity(1,1) primary key,
SaleId int not null,
ProductId int not null,
DateReturn date not null,
Quantity int not null,
Reaseon text not null,
Foreign key (SaleId) References Sales(Id),
Foreign key (ProductId) References Products(Id)
)

--tabla de notas de credito--
create table CreditNotes(
Id int identity(1,1) primary key,
CustomerReturnId int not null,
DocumentType varchar(45) not null,
DateGeneration date not null,
Observation varchar(45) not null
)

--catalogo de cuentas--
create table AccountCatalog(
Id int identity(1,1) primary key,
AccountName varchar(45) not null,
TypeAccount varchar(45) not null
)

--catalogo de subcuentas--
create table SubAccountsCatalog(
Id int identity(1,1) primary key,
AccountCatalogId int not null,
SubAccountName varchar(45) not null,
Amount decimal(12,2) not null,
Foreign key (AccountCatalogId) References AccountCatalog(Id)
)

--libro diario--
create table JournalEntries(
Id int identity(1,1) primary key,
EntryDate date not null,
Description varchar(45) NOT NULL,
BatchNumber int not null
)

--detalles diarios--
create table JournalEntrieDetails(
Id int identity(1,1) primary key,
JournalEntrieId int not null,
AccountCatalogId int not null,
Debit decimal(12,2) not null,
Credit decimal(12,2) not null,
Foreign key (JournalEntrieId) References JournalEntries(Id)
)

--libroMayor
create table Ledger(
Id int identity(1,1) primary key,
JournalEntrieId int not null,
Balance decimal(12,2) not null,
Status varchar(45) not null
)

--balance general--
create table GeneralBalance(
Id int identity(1,1) primary key,
dateBalance date not null,
LeadgerId int not null,
Foreign key (LeadgerId) References Ledger(Id)
)

CREATE TYPE PurchaseItemType AS TABLE
(
    ProductId INT,
    Quantity INT,
    UnitCost DECIMAL(12,2),
    UnitPrice DECIMAL(12,2)
);
GO


select * from AccountPaybles
select * from JournalEntrieDetails