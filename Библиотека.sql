USE [Biblioteka]
GO
/****** Object:  Table [dbo].[Avtor]    Script Date: 19.05.2021 15:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avtor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[middle_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Avtor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitateli]    Script Date: 19.05.2021 15:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitateli](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[familiya] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[id_passport] [int] NOT NULL,
	[ulica] [nvarchar](20) NOT NULL,
	[nomer_kvartiry] [nvarchar](8) NOT NULL,
	[nomer_telefona] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_Chitateli] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cnigi]    Script Date: 19.05.2021 15:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cnigi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_avtor] [int] NOT NULL,
	[nazvaniye_knigi] [nvarchar](50) NOT NULL,
	[id_god] [int] NOT NULL,
	[colichestvj_knig] [int] NOT NULL,
	[cena] [decimal](16, 2) NOT NULL,
	[id_izdanelstvo] [int] NOT NULL,
 CONSTRAINT [PK_Cnigi_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[God]    Script Date: 19.05.2021 15:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[God](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[god_proizvodstva] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_God] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Izdatelstvo]    Script Date: 19.05.2021 15:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izdatelstvo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nazvaniye_firmy] [nvarchar](50) NOT NULL,
	[gorod] [nvarchar](20) NOT NULL,
	[nomer_izdatelstva] [int] NOT NULL,
	[email] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Izdatelstvo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passport]    Script Date: 19.05.2021 15:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passport](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[seria] [nvarchar](4) NOT NULL,
	[number] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_Passport] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vydacha]    Script Date: 19.05.2021 15:00:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vydacha](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data_vudochi] [date] NOT NULL,
	[data_vozvrata] [date] NOT NULL,
	[id_chitatel] [int] NULL,
	[id_cnigi] [int] NULL,
 CONSTRAINT [PK_Vydacha_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Chitateli]  WITH CHECK ADD  CONSTRAINT [FK_Chitateli_Passport] FOREIGN KEY([id_passport])
REFERENCES [dbo].[Passport] ([id])
GO
ALTER TABLE [dbo].[Chitateli] CHECK CONSTRAINT [FK_Chitateli_Passport]
GO
ALTER TABLE [dbo].[Cnigi]  WITH CHECK ADD  CONSTRAINT [FK_Cnigi_Avtor] FOREIGN KEY([id_avtor])
REFERENCES [dbo].[Avtor] ([id])
GO
ALTER TABLE [dbo].[Cnigi] CHECK CONSTRAINT [FK_Cnigi_Avtor]
GO
ALTER TABLE [dbo].[Cnigi]  WITH CHECK ADD  CONSTRAINT [FK_Cnigi_God] FOREIGN KEY([id_god])
REFERENCES [dbo].[God] ([id])
GO
ALTER TABLE [dbo].[Cnigi] CHECK CONSTRAINT [FK_Cnigi_God]
GO
ALTER TABLE [dbo].[Cnigi]  WITH CHECK ADD  CONSTRAINT [FK_Cnigi_Izdatelstvo] FOREIGN KEY([id_izdanelstvo])
REFERENCES [dbo].[Izdatelstvo] ([id])
GO
ALTER TABLE [dbo].[Cnigi] CHECK CONSTRAINT [FK_Cnigi_Izdatelstvo]
GO
ALTER TABLE [dbo].[Vydacha]  WITH CHECK ADD  CONSTRAINT [FK_Vydacha_Chitateli] FOREIGN KEY([id_chitatel])
REFERENCES [dbo].[Chitateli] ([id])
GO
ALTER TABLE [dbo].[Vydacha] CHECK CONSTRAINT [FK_Vydacha_Chitateli]
GO
ALTER TABLE [dbo].[Vydacha]  WITH CHECK ADD  CONSTRAINT [FK_Vydacha_Cnigi] FOREIGN KEY([id_cnigi])
REFERENCES [dbo].[Cnigi] ([id])
GO
ALTER TABLE [dbo].[Vydacha] CHECK CONSTRAINT [FK_Vydacha_Cnigi]
GO
