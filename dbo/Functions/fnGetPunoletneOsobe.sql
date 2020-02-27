CREATE FUNCTION [dbo].[fnGetPunoletneOsobe]
(
	@DatumRodjenja DATE
)
RETURNS BIT
AS
BEGIN
DECLARE @GodineDecimal DECIMAL,
		@GodineZaokruzeno INT,
		@Punoletan BIT

	SET @GodineDecimal = DATEDIFF(hour, @DatumRodjenja, GETDATE()) / 8766.0
	SET @GodineZaokruzeno = CONVERT(int, ROUND(DATEDIFF(hour, @DatumRodjenja, GETDATE()) / 8766.0,0))

	IF (@GodineZaokruzeno >= 18)
		SET @Punoletan = 1
	ELSE
		SET @Punoletan = -0
RETURN @Punoletan
END
