CREATE TABLE [dbo].[Jedi](
	[JediId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[Height] [int] NULL,
	[Created] [datetime2](7) NOT NULL,
	[Edited] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Jedi] PRIMARY KEY CLUSTERED ([JediId] ASC)
)
GO




