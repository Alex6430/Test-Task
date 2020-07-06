CREATE DATABASE TestTaskNew
GO
USE TestTaskNew

CREATE TABLE Pays
(
	PaysId INT PRIMARY KEY IDENTITY,
	PaysDate Date,
	PaysSumm Money,
);

CREATE TABLE Orders
(
	OrdersId INT PRIMARY KEY IDENTITY,
    OrdersDate Date,
	OrdersSumm Money,
	OrdersSummPay Money
);

CREATE TABLE Moneys
(
	MoneysId INT PRIMARY KEY IDENTITY,
	OrdersId INT,
	PaysId INT,
	MoneysSumm Money,
	CONSTRAINT FK_Moneys_To_Pays FOREIGN KEY (PaysId)  REFERENCES Pays (PaysId),
	CONSTRAINT FK_Moneys_To_Orders FOREIGN KEY (OrdersId)  REFERENCES Orders (OrdersId),
);

CREATE TABLE Users
(
	UsersId INT PRIMARY KEY IDENTITY,
	UsersName NVARCHAR(20) NOT NULL,
	UsersPhone VARCHAR(20) UNIQUE NOT NULL,
    UsersLogin NVARCHAR(20) UNIQUE  NOT NULL,
    UsersPass NVARCHAR(20)  NOT NULL
);

SELECT top 1 PaysSumm FROM Pays order by PaysId desc

USE TestTaskNew
GO
CREATE TRIGGER Moneys_Insert_Pays
ON Moneys
AFTER INSERT
AS
UPDATE Pays
SET PaysSumm = PaysSumm - (select Top 1 MoneysSumm From Moneys order by MoneysId desc) where PaysId = (select top 1 PaysId From Moneys order by MoneysId desc)

GO
CREATE TRIGGER Moneys_Insert_Orders
ON Moneys
AFTER INSERT
AS
UPDATE Orders
SET OrdersSumm = OrdersSumm - (select Top 1 MoneysSumm From Moneys order by MoneysId desc), OrdersSummPay = OrdersSummPay + (select Top 1 MoneysSumm From Moneys order by MoneysId desc)  where OrdersId = (select top 1 OrdersId From Moneys order by MoneysId desc)



