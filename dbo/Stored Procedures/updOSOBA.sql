CREATE PROCEDURE [dbo].[updOSOBA]
	@Id INT,
	@JMBG NCHAR(13),
	@Ime NVARCHAR(100),
	@Prezime NVARCHAR(100),
	@Visina SMALLINT,
	@Tezina SMALLINT,
	@BojaOciju NCHAR(11),
	@Telefon NVARCHAR(30),
	@Eposta NVARCHAR(100),
	@Rodjendan DATE,
	@Adresa NVARCHAR(100),
	@Prebivaliste NCHAR(9)
AS
UPDATE [dbo].[Osoba]  
SET		JMBG = @JMBG,  
		Ime = [dbo].[fnPrvoSlovoVeliko](@Ime),  
		Prezime = [dbo].[fnPrvoSlovoVeliko](@Prezime),  
		Visina = @Visina,
		Tezina = @Tezina,
		BojaOciju = @BojaOciju,
		Telefon = @Telefon,
		[E-posta] = @Eposta,
		Rodjendan = @Rodjendan,
		Adresa = @Adresa,
		Prebivaliste = [dbo].[fnPrvoSlovoVeliko](@Prebivaliste)
WHERE  Id = @Id  
RETURN 0
