CREATE PROCEDURE [dbo].[selOSOBA]
	@Id INT
AS
	SELECT * FROM [dbo].[Osoba]
	WHERE [dbo].[Osoba].Id = @Id
RETURN 0
