CREATE FUNCTION [dbo].[fnSamoGodinaRodjenja]
(
	@DatumRodjenja DATE
)
RETURNS INT
AS
BEGIN
DECLARE @GodineDecimal DECIMAL,
		@GodineZaokruzeno INT

	SET @GodineDecimal = DATEDIFF(hour, @DatumRodjenja, GETDATE()) / 8766.0
	SET @GodineZaokruzeno = CONVERT(int, ROUND(DATEDIFF(hour, @DatumRodjenja, GETDATE()) / 8766.0,0))

RETURN @GodineZaokruzeno
END
