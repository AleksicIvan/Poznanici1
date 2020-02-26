CREATE PROCEDURE [dbo].[updOSOBA]
	@Id int,
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
UPDATE [dbo].[Osoba]  
SET		JMBG = @JMBG,  
		Ime = @Ime,  
		Prezime = @Prezime,  
		Visina = @Visina,
		Tezina = @Tezina,
		BojaOciju = @BojaOciju,
		Telefon = @Telefon,
		[E-posta] = @Eposta,
		Rodjendan = @Rodjendan,
		Adresa = @Adresa,
		Prebivaliste = @Prebivaliste
WHERE  id = @id  
RETURN 0
