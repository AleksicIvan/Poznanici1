CREATE PROCEDURE [dbo].[delOSOBA]
	@Id int
AS
	DELETE FROM [dbo].[Osoba]
	WHERE [dbo].[Osoba].Id = @Id
RETURN 0
