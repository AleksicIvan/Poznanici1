CREATE VIEW [dbo].[PunoletniSmederevci]
	AS SELECT * FROM [dbo].[Osoba]
	WHERE [dbo].[fnGetPunoletneOsobe]([dbo].[Osoba].[Rodjendan]) = 1 AND [dbo].[Osoba].[Prebivaliste] = 'Smederevo'
