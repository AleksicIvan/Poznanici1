CREATE TABLE [dbo].[Osoba]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [JMBG] NCHAR(13) NOT NULL UNIQUE, 
    [Ime] NVARCHAR(100) NOT NULL, 
    [Prezime] NVARCHAR(100) NOT NULL, 
    [Visina] SMALLINT NULL CHECK ([Visina] > 35), 
    [Tezina] SMALLINT NULL CHECK ([Tezina] > 0 AND [Tezina] < 250), 
    [BojaOciju] NCHAR(11) NULL CHECK ([BojaOciju] IN('Kestenjaste','Plave','Zelene')), 
    [Telefon] NVARCHAR(30) NOT NULL, 
    [E-posta] NVARCHAR(100) NOT NULL, 
    [Rodjendan] DATE NULL DEFAULT getdate(), 
    [Adresa] NVARCHAR(100) NULL, 
    [Prebivaliste] NCHAR(9) NULL CHECK ([Prebivaliste] IN('Beograd','Smederevo','Pirot','Sombor','Bor','Prokuplje'))
)