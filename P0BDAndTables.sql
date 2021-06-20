CREATE DATABASE P0DB; -- CREATED DB P0; done
-- DROP DATABASE databasename;

-- DROP TABLE table_name;
-- DROP TABLE Users;
-- User user = new User("Sekou", "Dosso", "qwer");
CREATE TABLE Users (
	UserId int PRIMARY KEY NOT NULL IDENTITY(1,1) ,
	fisrtName varchar(20) NOT NULL, lastName varchar(20) NOT NULL,
	UserPassWord varchar(20) NOT NULL,
	--CONSTRAINT CustomerPassWordLength CHECK (UserPassWord  > 3 ) 
);
-- INSERT INTO table_name VALUES (value1, value2, value3, ...);
INSERT INTO Users VALUES ('Sekou','Dosso', 'qwer');
INSERT INTO Users VALUES ('Mark','Moore', '1234');
Select * From Users;

-- DROP TABLE Locations;
CREATE TABLE Locations(
	locationId int PRIMARY KEY NOT NULL IDENTITY(1,1) ,
	locationName VARCHAR(20) NOT NULL,
	city VARCHAR(20) NOT NULL,
	locationState VARCHAR(20) NOT NULL,
	zipCode int NOT NULL,
	-- IventoryId;
);
INSERT INTO Locations VALUES('Soho', 'New York', 'NY', 10100);
INSERT INTO Locations VALUES ('Brooklyn', 'New York','NY', 20000);
Select * From Locations;

-- DROP TABLE Stores;
CREATE TABLE Stores(
	storeId int PRIMARY KEY NOT NULL IDENTITY(1,1) ,
	storeName  VARCHAR(20) NOT NULL,
	locationId int,
    FOREIGN KEY (locationId) REFERENCES Locations(locationId),	
);
INSERT INTO Stores VALUES ('berluti',1);
INSERT INTO Stores VALUES ('Rolex',1);
INSERT INTO Stores VALUES ('Dsquared2',2);
Select * From Stores;

-- DROP TABLE Products;
CREATE TABLE Products(
	ProductId int PRIMARY KEY NOT NULL IDENTITY(1,1) ,
	ProductName  VARCHAR(20) NOT NULL, 
	ProductDescription VARCHAR(20) NOT NULL,
	ProductPrice INT NULL, 
	Dispinibility  Bit NOT NULL DEFAULT(1),
	storeId int ,
	FOREIGN KEY (storeId) REFERENCES tores(storeId),	


	
);
-- seed products 
            Product p1 = new Product("Fast track", "Sport shoe", 1000, true, Berluti);
            Product p2 = new Product("Play time", "cusual shoe", 1400, true, Berluti);
            Product p3 = new Product("DateJust", "Sport watch", 40000, true, Rolex);
            Product p4 = new Product("Cellini", "Dress watch", 5000, true, Rolex);
            Product p5 = new Product(" Ripped wash", "Denim Jacket", 500, true, Dsquared2);
            Product p6 = new Product("Dark 3", "Staker Jeans", 300, true, Dsquared2);
-- DROP TABLE Orders;
CREATE TABLE Orders(
	OrderId int PRIMARY KEY NOT NULL IDENTITY(1,1), OrderNumber int NOT NULL, OderTime DATETIME NULL,
	ProductName  NVARCHAR(20) NOT NULL, ProductQuantity INT NULL, 
	StoreId int FOREIGN KEY REFERENCES Stores(StoreId), -- FOREIGN KEY
	CustomerId int FOREIGN KEY REFERENCES CUstomers(CustomerId),  -- FOREIGN KEY
);
-- DROP TABLE Inventory;
CREATE TABLE Inventories(
	InventoryId int PRIMARY KEY NOT NULL IDENTITY(1,1) ,
	ProductId INT NULL, ProductQuantity INT NULL,
	CONSTRAINT ProductQuantity CHECK (ProductQuantity  > 0 ) 
);









