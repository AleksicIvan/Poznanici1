CREATE FUNCTION [dbo].[fnSrednjaStarost]()
RETURNS @SrednjaStarost TABLE 
(
	SrednjaStarost INT
)
AS
BEGIN
	INSERT @SrednjaStarost
	SELECT AVG([dbo].[fnStarost]([dbo].[Osoba].[Rodjendan])) AS SrednjaStarost FROM [dbo].[Osoba]
	RETURN
END
