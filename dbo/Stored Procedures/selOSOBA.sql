CREATE PROCEDURE [dbo].[selOSOBA]
	@Id int
AS
	SELECT * FROM [dbo].[Osoba]
	WHERE [dbo].[Osoba].Id = @Id
RETURN 0
