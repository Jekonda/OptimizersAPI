/*
   4 липня 2021 р.12:01:48
   User: 
   Server: (LocalDB)\MSSQLLocalDB
   Database: Optimizers
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Orders
	DROP CONSTRAINT FK_Orders_Users
GO
ALTER TABLE dbo.Users SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Orders
	DROP CONSTRAINT DF_Orders_Id
GO
ALTER TABLE dbo.Orders ADD CONSTRAINT
	DF_Orders_Id DEFAULT newid() FOR Id
GO
ALTER TABLE dbo.Orders
	DROP CONSTRAINT PK_Orders
GO
ALTER TABLE dbo.Orders ADD CONSTRAINT
	PK_Orders PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Orders ADD CONSTRAINT
	FK_Orders_Users FOREIGN KEY
	(
	UserId
	) REFERENCES dbo.Users
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Orders SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.OrderLine
	(
	Id uniqueidentifier NOT NULL,
	OrderId uniqueidentifier NOT NULL,
	LineNumber int NULL,
	ItemCode nvarchar(250) NOT NULL,
	Quantity decimal(18, 3) NOT NULL,
	Price decimal(18, 9) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.OrderLine ADD CONSTRAINT
	DF_OrderLine_Id DEFAULT newid() FOR Id
GO
ALTER TABLE dbo.OrderLine ADD CONSTRAINT
	PK_OrderLine PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.OrderLine ADD CONSTRAINT
	FK_OrderLine_Orders FOREIGN KEY
	(
	OrderId
	) REFERENCES dbo.Orders
	(
	Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.OrderLine SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
