
DECLARE @ToGenerate INT = 1000,
		@HeightMin INT = 70,
		@HeightMax INT = 200


--SELECT ABS(CHECKSUM(NEWID()) % (@HeightMax - @HeightMin + 1)) + @HeightMin

DECLARE @JediTEMP TABLE (
	[Name] [varchar](250) NOT NULL,
	[Height] [int] NULL,
	[Created] [datetime2](7) NOT NULL,
	[Edited] [datetime2](7) NOT NULL,
	[RowNumber] INT
)

INSERT INTO @JediTEMP
([Name], [Height], [Created], [Edited], [RowNumber])
SELECT 
	[Name] = TEMP.name,		 --CONCAT('Jedi ', TEMP.name) --CONCAT(RIGHT('00000', VARCHAR(10, ))
	[Height] = 170,
	[Created] = DATEADD(DAY, -7, GETDATE()),
	[Edited] = DATEADD(DAY, -1, GETDATE()),
	RowNumber = ROW_NUMBER() OVER(ORDER BY (SELECT NULL))
FROM (SELECT TOP (@ToGenerate) c1.name
		FROM sys.all_columns c1
		ORDER BY NEWID()) TEMP


UPDATE @JediTEMP SET
	[Name] = CONCAT('Jedi ', RIGHT('00000' + CONVERT(VARCHAR(10), RowNumber), 5), ' ', [Name]),
	[Height] = (SELECT ABS(CHECKSUM(NEWID()) % (@HeightMax - @HeightMin + 1)) + @HeightMin)


--SELECT * FROM @JediTEMP

INSERT INTO dbo.Jedi
([Name], [Height], [Created], [Edited])
SELECT 
	TEMP.[Name], 
	TEMP.[Height], 
	TEMP.[Created], 
	TEMP.[Edited]
FROM @JediTEMP TEMP