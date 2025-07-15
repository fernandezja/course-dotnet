CREATE OR ALTER PROCEDURE dbo.Jedi_Search
	@Name VARCHAR(250),
	@PageIndex INT,
	@PageSize INT
AS
BEGIN
	
	DECLARE	@FirstRecord INT = (@PageIndex - 1) * @PageSize

	SELECT
		J.JediId,
		J.[Name], 
		J.[Height], 
		J.[Created], 
		J.[Edited],
		RowIndex = ROW_NUMBER() OVER (ORDER BY J.[Name] ASC),
		RowTotal = COUNT(*) OVER()

	FROM dbo.Jedi J
	WHERE
		(@Name IS NULL 
			OR @Name = ''
			OR J.Name LIKE '%'+@Name+'%')

	ORDER BY RowIndex 
	OFFSET @FirstRecord ROWS
	FETCH NEXT @PageSize ROWS ONLY;

END
GO
/*
--------------------------------------------------------------
-- TEST
--------------------------------------------------------------

EXEC dbo.Jedi_Search
	@Name = '0001',
	@PageIndex = 1,
	@PageSize = 10


--------------------------------------------------------------
*/
