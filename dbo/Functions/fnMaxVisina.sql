CREATE FUNCTION [dbo].[fnMaxVisina]()
RETURNS @MaxVisina TABLE
(
	MaxVisina int
)
AS
BEGIN
	INSERT @MaxVisina
	SELECT MAX([dbo].[Osoba].[Visina]) AS MaxVisina FROM [dbo].[Osoba]
	RETURN
END
