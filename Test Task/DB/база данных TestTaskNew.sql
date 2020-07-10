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


USE [TestTaskNew]
GO
CREATE TRIGGER [Moneys_Insert_Pays]
ON [Moneys]
AFTER INSERT
AS
UPDATE Pays
SET PaysSumm = PaysSumm - (select MoneysSumm From inserted) where PaysId = (select PaysId From inserted)


GO
CREATE TRIGGER [Moneys_Insert_Orders]
ON [Moneys]
AFTER INSERT
AS
UPDATE Orders
SET OrdersSumm = OrdersSumm - (select MoneysSumm From INSERTED) , OrdersSummPay = OrdersSummPay + (select MoneysSumm From inserted)  where OrdersId = (select OrdersId From inserted)
