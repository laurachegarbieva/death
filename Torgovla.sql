USE [torgovayaOrganizaciya]
GO
/****** Object:  Table [dbo].[Orgnizaciya]    Script Date: 20.05.2021 10:18:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orgnizaciya](
	[id] [int] NOT NULL,
	[nazvaniye] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](20) NOT NULL,
	[adres] [nvarchar](20) NOT NULL,
	[director] [nvarchar](50) NULL,
 CONSTRAINT [PK_Orgnizaciya] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Postavshiki]    Script Date: 20.05.2021 10:18:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postavshiki](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[ferst_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NULL,
	[telefon] [nvarchar](20) NOT NULL,
	[adres] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Postavshiki] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodovcy]    Script Date: 20.05.2021 10:18:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prodovcy](
	[id] [int] NOT NULL,
	[id_tochka] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[ferst_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NULL,
	[telefon] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Prodovcy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tochka]    Script Date: 20.05.2021 10:18:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tochka](
	[id] [int] NOT NULL,
	[id_organizacia] [int] NOT NULL,
	[adres] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tochka] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tovar]    Script Date: 20.05.2021 10:18:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tovar](
	[id] [int] NOT NULL,
	[naimenovaniye] [nvarchar](50) NOT NULL,
	[colichestvo] [nvarchar](50) NOT NULL,
	[cena] [money] NOT NULL,
 CONSTRAINT [PK_Tovar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZakazyPostavshikam]    Script Date: 20.05.2021 10:18:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZakazyPostavshikam](
	[id] [int] NOT NULL,
	[id_tovar] [int] NULL,
	[id_postavshik] [int] NOT NULL,
	[id_organizacia] [int] NOT NULL,
 CONSTRAINT [PK_ZakazyPostavshikam] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Prodovcy]  WITH CHECK ADD  CONSTRAINT [FK_Prodovcy_Tochka] FOREIGN KEY([id_tochka])
REFERENCES [dbo].[Tochka] ([id])
GO
ALTER TABLE [dbo].[Prodovcy] CHECK CONSTRAINT [FK_Prodovcy_Tochka]
GO
ALTER TABLE [dbo].[Tochka]  WITH CHECK ADD  CONSTRAINT [FK_Tochka_Orgnizaciya] FOREIGN KEY([id_organizacia])
REFERENCES [dbo].[Orgnizaciya] ([id])
GO
ALTER TABLE [dbo].[Tochka] CHECK CONSTRAINT [FK_Tochka_Orgnizaciya]
GO
ALTER TABLE [dbo].[ZakazyPostavshikam]  WITH CHECK ADD  CONSTRAINT [FK_ZakazyPostavshikam_Orgnizaciya] FOREIGN KEY([id_organizacia])
REFERENCES [dbo].[Orgnizaciya] ([id])
GO
ALTER TABLE [dbo].[ZakazyPostavshikam] CHECK CONSTRAINT [FK_ZakazyPostavshikam_Orgnizaciya]
GO
ALTER TABLE [dbo].[ZakazyPostavshikam]  WITH CHECK ADD  CONSTRAINT [FK_ZakazyPostavshikam_Postavshiki1] FOREIGN KEY([id_postavshik])
REFERENCES [dbo].[Postavshiki] ([id])
GO
ALTER TABLE [dbo].[ZakazyPostavshikam] CHECK CONSTRAINT [FK_ZakazyPostavshikam_Postavshiki1]
GO
ALTER TABLE [dbo].[ZakazyPostavshikam]  WITH CHECK ADD  CONSTRAINT [FK_ZakazyPostavshikam_Tovar] FOREIGN KEY([id_tovar])
REFERENCES [dbo].[Tovar] ([id])
GO
ALTER TABLE [dbo].[ZakazyPostavshikam] CHECK CONSTRAINT [FK_ZakazyPostavshikam_Tovar]
GO
