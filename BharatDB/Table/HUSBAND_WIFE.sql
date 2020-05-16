CREATE TABLE [dbo].[Husband_Wife](
	[Husband_Wife_Id] [int] IDENTITY(1,1) NOT NULL,
	[Husband_Wife_Type] [varchar](10) NULL,
	[Husband_Wife_Amt] [int] NULL,
	[Husband_Wife_Date] [varchar](100) NULL,
	[HUSBAND_WIFE_TYPE_ID] [int] NOT NULL,
	[EXPENSES_CATEGORY_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Husband_Wife_Id] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Husband_Wife]  WITH CHECK ADD FOREIGN KEY([EXPENSES_CATEGORY_ID])
REFERENCES [dbo].[Expenses_Category] ([Expenses_Category_Id])
GO

