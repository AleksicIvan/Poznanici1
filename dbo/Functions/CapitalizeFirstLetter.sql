CREATE FUNCTION [dbo].[CapitalizeFirstLetter] 
(
	@word nvarchar(100)
)
RETURNS nvarchar(100)
AS
BEGIN
DECLARE 
@Index int,
@Result nvarchar(100)

SET @Index = 1
SET @Result = ''

WHILE (@Index < LEN(@word) + 1)
BEGIN
	IF (@Index = 1)
		BEGIN
		SET @Result = @Result + UPPER(SUBSTRING(@word, @Index, 1))
		SET @Index = @Index + 1
		END
	ELSE
		BEGIN
		SET @Result = @Result + LOWER(SUBSTRING(@word, @Index, 1))
		SET @Index = @Index + 1
		END
END

RETURN @Result
END