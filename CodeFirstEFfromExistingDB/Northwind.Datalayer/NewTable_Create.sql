USE [Northwind]
GO

/****** Object:  Table [dbo].[NewTable]    Script Date: 14.08.2016 05:34:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NewTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NULL,
	[Desc] [nchar](10) NULL,
	[Value] [int] NULL,
	[NewField] [datetime] NULL,
 CONSTRAINT [PK_NewTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


