
/****** Object:  Table [dbo].[Code_Id]    Script Date: 14/05/2020 7:30:15 PM ******/
CREATE TABLE [dbo].[Code_Id](
	[Code_Id] [int] NOT NULL,
	[Code_Description] [varchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_Id] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

