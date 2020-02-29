CREATE FUNCTION [dbo].[testJMBG] 
(
	@JMBG NVARCHAR(MAX)
)
RETURNS BIT
AS 
BEGIN
 
	DECLARE @greska NVARCHAR(MAX);
	DECLARE @rezultat BIT;
 
	IF @JMBG IS NULL OR @JMBG = ''
	SET @rezultat = 0;
	SET @greska = 'Prazan JMBG';
 
	IF @JMBG IS NULL AND LEN(@JMBG) > 13 
	SET @rezultat = 0;
	SET @greska = 'JMBG ima vise od 13 brojki';
	
	IF @JMBG IS NULL AND LEN(@JMBG) < 13 
	SET @rezultat = 0;
	SET @greska = 'JMBG ima manje od 13 brojki';
 
	IF (@greska IS NOT NULL)
	BEGIN  
 
		SET @rezultat = 1;
		
		DECLARE @Dan NVARCHAR(2);
		DECLARE @Mesec NVARCHAR(2);
		DECLARE @Godina NVARCHAR(4);
 
		SELECT @Dan = SUBSTRING(@JMBG,1,2);
		SELECT @Mesec = SUBSTRING(@JMBG,3,2);
		SELECT @Godina = SUBSTRING(@JMBG,5,3);
 
		IF @Godina<800 SET @Godina = @Godina + 2000;
		ELSE SET @Godina = @Godina + 1000;	
 
		IF ISDATE(@Godina + @Mesec + @Dan) <> 1 
		BEGIN 
			SET @rezultat = 0;
		END;
		ELSE
		BEGIN
			DECLARE @DatumRodj DATE;
			SELECT @DatumRodj = CONVERT(DATE,@Godina + @Mesec + @Dan,112);
			IF @DatumRodj > GETDATE() 
			BEGIN
				SET @rezultat = 0;
			END;
		END;
  
		DECLARE @A INT; 
		DECLARE @B INT; 
		DECLARE @C INT; 
		DECLARE @D INT; 
		DECLARE @E INT; 
		DECLARE @F INT; 
		DECLARE @G INT;
		DECLARE @H INT;
		DECLARE @I INT;
		DECLARE @J INT;
		DECLARE @K INT;
		DECLARE @L INT;
		DECLARE @M INT;
 
		SELECT @A = SUBSTRING(@JMBG,1,1);
		SELECT @B = SUBSTRING(@JMBG,2,1);
		SELECT @C = SUBSTRING(@JMBG,3,1);
		SELECT @D = SUBSTRING(@JMBG,4,1);
		SELECT @E = SUBSTRING(@JMBG,5,1);
		SELECT @F = SUBSTRING(@JMBG,6,1);
		SELECT @G = SUBSTRING(@JMBG,7,1);
		SELECT @H = SUBSTRING(@JMBG,8,1);
		SELECT @I = SUBSTRING(@JMBG,9,1);
		SELECT @J = SUBSTRING(@JMBG,10,1);
		SELECT @K = SUBSTRING(@JMBG,11,1);
		SELECT @L = SUBSTRING(@JMBG,12,1);
		SELECT @M = SUBSTRING(@JMBG,13,1);
 
		DECLARE @Provera INT;
 
		SELECT @Provera =  11 - (( 7*(@A+@G) + 6*(@B+@H) + 5*(@C+@I) + 4*(@D+@J) + 3*(@E+@K) + 2*(@F+@L) ) % 11);
		IF (@Provera > 9) SET @Provera = 0;
 
		IF @Provera <> @M 
		BEGIN 
			SET @rezultat = 0;
		END
	END;
 
	RETURN @rezultat;
END
GO