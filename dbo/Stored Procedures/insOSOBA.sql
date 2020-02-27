CREATE PROCEDURE [dbo].[insOSOBA] 
	@JMBG nchar(13),
	@Ime nvarchar(100),
	@Prezime nvarchar(100),
	@Visina smallint,
	@Tezina smallint,
	@BojaOciju nchar(11),
	@Telefon nvarchar(30),
	@Eposta nvarchar(100),
	@Rodjendan date,
	@Adresa nvarchar(100),
	@Prebivaliste nchar(9)
	AS
	INSERT INTO [dbo].[Osoba] (
		JMBG, 
		Ime, 
		Prezime, 
		Visina, 
		Tezina, 
		BojaOciju, 
		Telefon, 
		[E-posta], 
		Rodjendan, 
		Adresa, 
		Prebivaliste
	)
	VALUES (
		@JMBG, 
		[dbo].[fnPrvoSlovoVeliko](@Ime), 
		[dbo].[fnPrvoSlovoVeliko](@Prezime), 
		@Visina, 
		@Tezina, 
		@BojaOciju, 
		@Telefon, 
		@Eposta, 
		@Rodjendan, 
		@Adresa, 
		[dbo].[fnPrvoSlovoVeliko](@Prebivaliste)
	)

GO
