	create table Admins
	(
		AdminID varchar(50) not null Primary Key,
		AdminName varchar(50) not null,
		Username varchar(50) not null,
		AdminPassword varchar(50) not null,
		Position varchar(50) not null,
		EmailAddress varchar(50) not null,
		PhoneNumber varchar(50) not null,
		NRC varchar (50) not null,
		Address varchar(100) not null,
	);

create table Category
(
	CategoryID varchar(50) not null Primary Key,
	CategoryName varchar(50) not null
);	

create table Brand
(
	BrandID varchar(50) not null Primary Key,
	BrandName varchar (50) not null,
	ModelNumber Varchar (50) not null,
	Color Varchar (50) not null
);

create table Appliances
(
	ApplianceID varchar(50) not null Primary Key,
	ApplianceName varchar(50) not null,
	BrandID varchar (50) not null,
	CategoryID varchar(50) not null,
	MonthlyFees int,
	PowerUsage varchar(50) not null,
	TypicalUsage varchar(50) not null,
	YearlyFees int,
	EnergyConsumption varchar(50) not null,
	Description varchar(50) not null,
	Picture image,
	Foreign Key (CategoryID) references Category(CategoryID),
	Foreign Key (BrandID) references Brand(BrandID),
);

create table Customers
(
	CustomerID varchar(50) not null Primary Key,
	CustomerName varchar(50) not null,
	Username varchar(50) not null,
	CustomerPassword varchar(50) not null,
	Gender varchar(50) not null,
	PhoneNumber varchar(50) not null,
	EmailAddress varchar(50) not null,
	Address varchar(100) not null,
);

Create Table Rent
(
	RentID varchar(50) not null Primary Key,
	RentMonth int not null,
	TotalAmount int,
	RentDate varchar(50) not null,
	CustomerID varchar(50) not null,
	Foreign Key (CustomerID) references Customers (CustomerID)
);

Create Table RentDetails
(
	RentID varchar (50) not null,
	ApplianceID varchar(50) not null,
	RentTotalMonth int,
	RentAmount int,
	Primary key (RentID,ApplianceID),
	Foreign Key (RentID) References Rent(RentID),
	Foreign Key (ApplianceID) References Appliances (ApplianceID)
);
	
Create Table Review
(
	ReviewID varchar (50) not null Primary Key,
	ReviewDate varchar (50),
	ApplianceID varchar(50),
	CustomerID varchar(50),
	Rating int,
	Feedback varchar(100),
	Foreign Key (ApplianceID) references Appliances (ApplianceID),
	Foreign Key (CustomerID) references Customers(CustomerID)
);

Select * from Customers
