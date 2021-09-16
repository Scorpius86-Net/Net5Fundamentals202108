CREATE DATABASE Pharmacy;
USE Pharmacy;

CREATE TABLE Customer(
	CustomerCode VARCHAR(8) PRIMARY KEY NOT NULL,
	CustomerName VARCHAR(40) NOT NULL,
	CustomerAddress VARCHAR(40) NULL,
	DistrictCode VARCHAR(8) NULL,
	Sex VARCHAR(1) NOT NULL,
	DNI VARCHAR(8) NULL,
	RUC VARCHAR(11) NULL,
	Telephone INT NULL,
	Mobile INT NULL
);

CREATE TABLE [Order](
	OrderNumber VARCHAR(8) PRIMARY KEY NOT NULL,
	[Date] DATETIME NOT NULL,
	CustomerCode VARCHAR(8) NOT NULL,
	EmployeeCode VARCHAR(8) NOT NULL,
	PaymentTypeCode VARCHAR(8) NULL,
	Total int NULL
)

INSERT INTO Customer (CustomerCode,CustomerName,CustomerAddress,DistrictCode,Sex,DNI,RUC,Telephone,Mobile)
VALUES
('CUS00001','Erick Aróstegui Cunza','Av la Gardenias S/N','L041','M',13213213,12345678901,3333333,9999999),
('CUS00002','Juan Perez','Av la Dalias S/N','L042','M',23213213,22345678901,2333333,2999999),
('CUS00003','Jose Lopez','Av los Fresnos S/N','L043','M',33213213,32345678901,3333333,3999999),
('CUS00004','Daniel Aguilar','Av los Jasmines S/N','L044','M',43213213,42345678901,4333333,4999999),
('CUS00005','Raul Chato Padilla','Av las Orquideas S/N','L045','M',53213213,52345678901,5333333,5999999);


SELECT  
	CustomerCode,
	CustomerName,
	CustomerAddress,
	DistrictCode,
	Sex,
	DNI,
	RUC,
	Telephone,
	Mobile
FROM Customer