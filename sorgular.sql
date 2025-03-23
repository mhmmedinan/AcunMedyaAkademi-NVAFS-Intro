--yeni bir db oluştur

Create Database CarRentalDb;

--Kullanılacak db'ye geçiş

Use CarRentalDb

Create Table Brands (
  Id INT primary key identity(1,1),
  Name varchar(50) NOT NULL Unique
);


Create Table Models (
  Id INT primary key identity(1,1),
  Name varchar(50) NOT NULL Unique,
  BrandId INT foreign key references Brands(Id)
);


Create Table Transmissions (
  Id INT primary key identity(1,1),
  Name varchar(50) NOT NULL Unique
);

Create Table Fuels (
  Id INT primary key identity(1,1),
  Name varchar(50) NOT NULL Unique
);

Create Table Colors (
  Id INT primary key identity(1,1),
  Name varchar(50) NOT NULL Unique
);

Create Table ModelTransmissions (
  Id INT primary key identity(1,1),
  ModelId Int foreign key references Models(Id),
  TransmissionId Int foreign key references Transmissions(Id)
);

Create Table ModelFuels (
  Id INT primary key identity(1,1),
  ModelId Int foreign key references Models(Id),
  FuelId Int foreign key references Fuels(Id)
);

Create Table Cars (
  Id INT primary key identity(1,1),
  ModelId Int foreign key references Models(Id),
  ColorId Int foreign key references Colors(Id),
  Plate varchar(20) Not Null unique,
  Kilometer Int not null,
  ModelYear Int not null
);



Insert Into Brands (Name) Values ('Toyota'),('Honda'),('BMW'),('Mercedes'),('Ford'),('Audi'),
('Hyundai'),('Nissan'),('Peugeot'),('Volkswagen');

INSERT INTO Models (Name, BrandId) VALUES 
('Corolla', 1), ('Civic', 2), ('320i', 3), ('C200', 4), ('Focus', 5),
('A4', 6), ('i30', 7), ('Qashqai', 8), ('208', 9), ('Golf', 10);


INSERT INTO Transmissions (Name) VALUES ('Manual'), ('Automatic'), ('CVT'),
('Semi-Automatic'), ('Dual-Clutch'), ('Tiptronic'), ('Electric'), ('Hybrid'), ('7-Speed'), ('8-Speed');


INSERT INTO Fuels (Name) VALUES ('Gasoline'), ('Diesel'), ('Electric'), ('Hybrid'),
('LPG'), ('Hydrogen'), ('Ethanol'), ('CNG'), ('Bio-Diesel'), ('Methanol');

INSERT INTO Colors (Name) VALUES ('Red'), ('Blue'), ('Black'),
('White'), ('Grey'), ('Silver'), ('Green'), ('Yellow'), ('Orange'), ('Purple');

INSERT INTO ModelTransmissions (ModelId, TransmissionId) VALUES 
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);


INSERT INTO ModelFuels (ModelId, FuelId) VALUES 
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);



INSERT INTO Cars (Plate, Kilometer, ModelYear, ColorId, ModelId) VALUES 
('34ABC123', 50000, 2020, 1, 1),
('06DEF456', 60000, 2019, 2, 2),
('35GHI789', 70000, 2021, 3, 3),
('16JKL012', 80000, 2018, 4, 4),
('07MNO345', 90000, 2022, 5, 5),
('44PQR678', 40000, 2023, 6, 6),
('22STU901', 55000, 2020, 7, 7),
('09VWX234', 30000, 2019, 8, 8),
('01YZA567', 20000, 2021, 9, 9),
('45BCD890', 10000, 2022, 10, 10);



--Select (Db'deki verileri sorgulama)

--Tüm arabaları getir
Select * from Cars;

Select Id,Plate,ModelId,ModelYear from Cars;

-- Tüm markaları getir

Select * from Brands

--where (koşul)

Select * from Cars where Id=2;

Select * from Brands where Name='Audi'

--2018 sonrası için üretilen arabaları getir
Select * from Cars where ModelYear>2018


--Order By (sorgu sonuçlarını artan veya azalan sırada sıralamak için kullanılır)

--ASC => Ascending => Artan
--DESC => Descending => Azalan


--Kilometresi en düşük arabaları getir
Select * from Cars Order By Kilometer ASC;

-- en yeni arabaları listele
Select * from Cars Order By Kilometer DESC;

--Group By

--Model yılına göre araba sayısını getir

Select ModelYear,Count(*) as ArabaSayısı From Cars
Group By ModelYear


--Join 
--Inner join => iki tabloda eşleşen verileri döndürür
--Left Join,Right Join,Full outer join => Araştırma ödevi

-- Arabaları marka ve modeline göre listele
Select c.Id,c.Plate,b.Name as MarkaAdı,m.Name as ModelAdı from Cars as c
inner join Models as m on c.ModelId=m.Id
inner join Brands as b on m.BrandId=b.Id

--Arabaları markası,modeli,rengi ve yakıt tipine göre listele
Select c.Id,c.Plate,b.Name as MarkaAdı,m.Name as ModelAdı,cl.Name as Renk,f.Name as Yakıt from Cars as c
inner join Models as m on c.ModelId=m.Id
inner join Brands as b on m.BrandId=b.Id
inner join Colors as cl on c.ColorId=cl.Id
inner join ModelFuels as mf on m.Id=mf.ModelId
inner join Fuels as f on mf.FuelId=f.Id


--Markalara göre model sayısını getir
Select b.Name as Marka,Count(m.Id) as ModelSayısı from Brands as b
inner join Models as m on b.Id=m.BrandId
Group By b.Name

--Having (group by ile oluşturulan gruplar üzerinde filtreleme yapmak için kullanılır)
--where yalnızca satırlara uygulanırken , having ise gruplara uygulanır

-- En az 1 modeli olan markaları getir
Select b.Name,count(m.Id) from Brands as b
inner join Models as m on b.Id=m.BrandId
Group By b.Name
Having count(m.Id)>=1;

-- Farklı vites türlerini destekleyen modelleri listele
-- En az 1 farklı vites türü olanları göster

Select m.Name,Count(Distinct mt.TransmissionId) as VitesTürü from Models as m
inner join ModelTransmissions as mt on m.Id=mt.ModelId
Group by m.Name
Having Count(m.Id)>=1
