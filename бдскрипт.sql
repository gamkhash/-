USE [Аптека]
GO
/****** Object:  Table [dbo].[Buyers]    Script Date: 19.05.2024 14:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buyers](
	[id_Buyers] [int] NOT NULL,
	[Buyers] [varchar](max) NOT NULL,
	[Date_of_purhase] [varchar](max) NOT NULL,
	[id_of_the_drug] [int] NOT NULL,
 CONSTRAINT [PK_Buyers] PRIMARY KEY CLUSTERED 
(
	[id_Buyers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employess]    Script Date: 19.05.2024 14:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employess](
	[id_eplov] [int] NOT NULL,
	[Employes's full name] [varchar](max) NOT NULL,
	[Carrent position] [varchar](max) NOT NULL,
	[Salary] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Employess] PRIMARY KEY CLUSTERED 
(
	[id_eplov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Madication]    Script Date: 19.05.2024 14:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Madication](
	[id_Mtion] [int] NOT NULL,
	[Name_of_the_drug] [varchar](max) NOT NULL,
	[The_amount_of_the_drug] [varchar](max) NOT NULL,
	[Country_of_the_drug] [varchar](max) NOT NULL,
	[The_prise_of_the_drug] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Madication] PRIMARY KEY CLUSTERED 
(
	[id_Mtion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P_and_L]    Script Date: 19.05.2024 14:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P_and_L](
	[Login] [varchar](max) NOT NULL,
	[Passworsd] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Buyers]  WITH CHECK ADD  CONSTRAINT [FK_Buyers_Madication] FOREIGN KEY([id_of_the_drug])
REFERENCES [dbo].[Madication] ([id_Mtion])
GO
ALTER TABLE [dbo].[Buyers] CHECK CONSTRAINT [FK_Buyers_Madication]
GO
ALTER TABLE [dbo].[Madication]  WITH CHECK ADD  CONSTRAINT [FK_Madication_Madication] FOREIGN KEY([id_Mtion])
REFERENCES [dbo].[Madication] ([id_Mtion])
GO
ALTER TABLE [dbo].[Madication] CHECK CONSTRAINT [FK_Madication_Madication]
GO
