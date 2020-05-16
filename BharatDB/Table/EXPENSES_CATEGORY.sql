CREATE TABLE [dbo].[Expenses_Category](
	[Expenses_Category_Id] [int] IDENTITY(1,1) NOT NULL,
	[Expenses_Category_Name] [varchar](500) NOT NULL,
	[Expenses_Category_Table_Id] [int] NOT NULL,
	[Expenses_Category_Table_Value] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Expenses_Category_Id] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

