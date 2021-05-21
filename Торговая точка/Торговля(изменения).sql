USE [torgovayaOrganizaciya]
GO
/****** Object:  Table [dbo].[Mestopologeniye]    Script Date: 21.05.2021 10:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mestopologeniye](
	[id] [int] NOT NULL,
	[id_postavshik] [int] NOT NULL,
	[id_tochka] [int] NOT NULL,
	[id_organizaciya] [int] NOT NULL,
	[gorod] [nvarchar](50) NOT NULL,
	[ulica] [nvarchar](50) NOT NULL,
	[nomer_doma] [nvarchar](50) NOT NULL,
	[isdeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Mestopologeniye] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orgnizaciya]    Script Date: 21.05.2021 10:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orgnizaciya](
	[id] [int] NOT NULL,
	[nazvaniye] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](20) NOT NULL,
	[name_director] [nvarchar](50) NOT NULL,
	[ferst_name_director] [nvarchar](50) NOT NULL,
	[last_name_director] [nvarchar](50) NULL,
	[isdeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Orgnizaciya] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Postavshik]    Script Date: 21.05.2021 10:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postavshik](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[ferst_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NULL,
	[telefon] [nvarchar](20) NOT NULL,
	[isdeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Postavshiks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodovec]    Script Date: 21.05.2021 10:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prodovec](
	[id] [int] NOT NULL,
	[id_tochka] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[ferst_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NULL,
	[telefon] [nvarchar](20) NOT NULL,
	[isdeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Prodovcy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tochka]    Script Date: 21.05.2021 10:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tochka](
	[id] [int] NOT NULL,
	[id_organizacia] [int] NOT NULL,
	[isdeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Tochka] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tovar]    Script Date: 21.05.2021 10:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tovar](
	[id] [int] NOT NULL,
	[naimenovaniye] [nvarchar](50) NOT NULL,
	[colichestvo] [nvarchar](50) NOT NULL,
	[cena] [money] NOT NULL,
	[isdeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Tovar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZakazyPostavshikam]    Script Date: 21.05.2021 10:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZakazyPostavshikam](
	[id] [int] NOT NULL,
	[id_tovar] [int] NOT NULL,
	[id_postavshiki] [int] NOT NULL,
	[id_organizacia] [int] NOT NULL,
	[colichestvo] [nvarchar](50) NOT NULL,
	[isdeleted] [bit] NOT NULL,
 CONSTRAINT [PK_ZakazyPostavshikam] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Mestopologeniye] ([id], [id_postavshik], [id_tochka], [id_organizaciya], [gorod], [ulica], [nomer_doma], [isdeleted]) VALUES (1, 1, 1, 1, N'Moscov', N'Tader', N'2', 0)
INSERT [dbo].[Mestopologeniye] ([id], [id_postavshik], [id_tochka], [id_organizaciya], [gorod], [ulica], [nomer_doma], [isdeleted]) VALUES (2, 2, 2, 2, N'Piter', N'Soloveva', N'3', 0)
GO
INSERT [dbo].[Orgnizaciya] ([id], [nazvaniye], [telefon], [name_director], [ferst_name_director], [last_name_director], [isdeleted]) VALUES (1, N'Solot', N'89289125887', N'Victor', N'Dorohov', NULL, 0)
INSERT [dbo].[Orgnizaciya] ([id], [nazvaniye], [telefon], [name_director], [ferst_name_director], [last_name_director], [isdeleted]) VALUES (2, N'Krilew', N'89293564321', N'Sergey', N'Androv', NULL, 0)
GO
INSERT [dbo].[Postavshik] ([id], [name], [ferst_name], [last_name], [telefon], [isdeleted]) VALUES (1, N'Fedor', N'Poresev', NULL, N'89289125887', 0)
INSERT [dbo].[Postavshik] ([id], [name], [ferst_name], [last_name], [telefon], [isdeleted]) VALUES (2, N'Andrey', N'Coretco', NULL, N'89365432134', 0)
GO
INSERT [dbo].[Prodovec] ([id], [id_tochka], [name], [ferst_name], [last_name], [telefon], [isdeleted]) VALUES (1, 1, N'Oleg', N'Foster', N'Victorovich', N'89285764321', 0)
INSERT [dbo].[Prodovec] ([id], [id_tochka], [name], [ferst_name], [last_name], [telefon], [isdeleted]) VALUES (2, 2, N'Maxsim', N'Solovev', N'Andreevich', N'89361234567', 0)
GO
INSERT [dbo].[Tochka] ([id], [id_organizacia], [isdeleted]) VALUES (1, 1, 0)
INSERT [dbo].[Tochka] ([id], [id_organizacia], [isdeleted]) VALUES (2, 2, 0)
GO
INSERT [dbo].[Tovar] ([id], [naimenovaniye], [colichestvo], [cena], [isdeleted]) VALUES (1, N'Izdeliye1', N'3', 1500.0000, 0)
INSERT [dbo].[Tovar] ([id], [naimenovaniye], [colichestvo], [cena], [isdeleted]) VALUES (2, N'Izdeliye2', N'8', 2000.0000, 0)
GO
INSERT [dbo].[ZakazyPostavshikam] ([id], [id_tovar], [id_postavshiki], [id_organizacia], [colichestvo], [isdeleted]) VALUES (1, 1, 1, 1, N'75', 0)
INSERT [dbo].[ZakazyPostavshikam] ([id], [id_tovar], [id_postavshiki], [id_organizacia], [colichestvo], [isdeleted]) VALUES (2, 2, 2, 2, N'80', 0)
GO
ALTER TABLE [dbo].[Mestopologeniye]  WITH CHECK ADD  CONSTRAINT [FK_Mestopologeniye_Orgnizaciya] FOREIGN KEY([id_organizaciya])
REFERENCES [dbo].[Orgnizaciya] ([id])
GO
ALTER TABLE [dbo].[Mestopologeniye] CHECK CONSTRAINT [FK_Mestopologeniye_Orgnizaciya]
GO
ALTER TABLE [dbo].[Mestopologeniye]  WITH CHECK ADD  CONSTRAINT [FK_Mestopologeniye_Tochka] FOREIGN KEY([id_tochka])
REFERENCES [dbo].[Tochka] ([id])
GO
ALTER TABLE [dbo].[Mestopologeniye] CHECK CONSTRAINT [FK_Mestopologeniye_Tochka]
GO
ALTER TABLE [dbo].[Prodovec]  WITH CHECK ADD  CONSTRAINT [FK_Prodovec_Tochka] FOREIGN KEY([id_tochka])
REFERENCES [dbo].[Tochka] ([id])
GO
ALTER TABLE [dbo].[Prodovec] CHECK CONSTRAINT [FK_Prodovec_Tochka]
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
ALTER TABLE [dbo].[ZakazyPostavshikam]  WITH CHECK ADD  CONSTRAINT [FK_ZakazyPostavshikam_Postavshik] FOREIGN KEY([id_postavshiki])
REFERENCES [dbo].[Postavshik] ([id])
GO
ALTER TABLE [dbo].[ZakazyPostavshikam] CHECK CONSTRAINT [FK_ZakazyPostavshikam_Postavshik]
GO
ALTER TABLE [dbo].[ZakazyPostavshikam]  WITH CHECK ADD  CONSTRAINT [FK_ZakazyPostavshikam_Tovar] FOREIGN KEY([id_tovar])
REFERENCES [dbo].[Tovar] ([id])
GO
ALTER TABLE [dbo].[ZakazyPostavshikam] CHECK CONSTRAINT [FK_ZakazyPostavshikam_Tovar]
GO
