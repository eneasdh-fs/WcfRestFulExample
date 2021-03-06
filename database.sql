USE [cinemark]
GO
/****** Object:  Table [dbo].[migrations]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[migrations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[migration] [nvarchar](255) NOT NULL,
	[batch] [int] NOT NULL,
 CONSTRAINT [PK_migrations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[headquarters]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[headquarters](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_headquarters] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[headquarters] ON
INSERT [dbo].[headquarters] ([id], [name]) VALUES (1, N'Principal')
SET IDENTITY_INSERT [dbo].[headquarters] OFF
/****** Object:  Table [dbo].[genres]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genres](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_genres] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[genres] ON
INSERT [dbo].[genres] ([id], [name]) VALUES (1, N'misterio')
SET IDENTITY_INSERT [dbo].[genres] OFF
/****** Object:  Table [dbo].[products]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[price] [decimal](10, 3) NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON
INSERT [dbo].[products] ([id], [name], [price]) VALUES (1, N'combo x1', CAST(5.990 AS Decimal(10, 3)))
INSERT [dbo].[products] ([id], [name], [price]) VALUES (2, N'combo x2', CAST(7.990 AS Decimal(10, 3)))
SET IDENTITY_INSERT [dbo].[products] OFF
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
 CONSTRAINT [PK_sysdiagrams] PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[headquarter_id] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[users] ON
INSERT [dbo].[users] ([id], [name], [username], [password], [headquarter_id]) VALUES (1, N'nano', N'nano', N'nano', 1)
SET IDENTITY_INSERT [dbo].[users] OFF
/****** Object:  Table [dbo].[movies]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[genre_id] [int] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[price] [decimal](8, 3) NOT NULL,
	[url] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_movies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[movies] ON
INSERT [dbo].[movies] ([id], [name], [genre_id], [description], [price], [url]) VALUES (1, N'death note 2 el ultimo nombre 2006', 1, N'some description', CAST(10.900 AS Decimal(8, 3)), N'death-note-2-el-ultimo-nombre-2006')
SET IDENTITY_INSERT [dbo].[movies] OFF
/****** Object:  Table [dbo].[programming]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[programming](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[movie_id] [int] NOT NULL,
	[headquarter_id] [int] NOT NULL,
	[room] [nvarchar](255) NOT NULL,
	[limit] [smallint] NOT NULL,
	[release_at] [datetime] NOT NULL,
	[occupied] [smallint] NOT NULL,
 CONSTRAINT [PK_programming] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[programming] ON
INSERT [dbo].[programming] ([id], [movie_id], [headquarter_id], [room], [limit], [release_at], [occupied]) VALUES (1, 1, 1, N'AB1', 30, CAST(0x0000A79C00A7D5B2 AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[programming] OFF
/****** Object:  Table [dbo].[payments]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[payments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[programming_id] [int] NOT NULL,
	[creator_by] [int] NOT NULL,
	[headquarter_id] [int] NOT NULL,
	[client] [varchar](60) NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [decimal](10, 3) NOT NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK_payments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[payment_detail]    Script Date: 06/21/2017 17:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment_detail](
	[product_id] [int] NOT NULL,
	[payment_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [decimal](10, 3) NOT NULL,
 CONSTRAINT [PK_payment_detail] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC,
	[payment_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__payments__create__1920BF5C]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[payments] ADD  DEFAULT (getdate()) FOR [created_at]
GO
/****** Object:  ForeignKey [FK_movies_genre_id_foreign]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[movies]  WITH CHECK ADD  CONSTRAINT [FK_movies_genre_id_foreign] FOREIGN KEY([genre_id])
REFERENCES [dbo].[genres] ([id])
GO
ALTER TABLE [dbo].[movies] CHECK CONSTRAINT [FK_movies_genre_id_foreign]
GO
/****** Object:  ForeignKey [FK__payment_d__payme__71D1E811]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[payment_detail]  WITH CHECK ADD  CONSTRAINT [FK__payment_d__payme__71D1E811] FOREIGN KEY([payment_id])
REFERENCES [dbo].[payments] ([id])
GO
ALTER TABLE [dbo].[payment_detail] CHECK CONSTRAINT [FK__payment_d__payme__71D1E811]
GO
/****** Object:  ForeignKey [FK__payment_d__produ__70DDC3D8]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[payment_detail]  WITH CHECK ADD  CONSTRAINT [FK__payment_d__produ__70DDC3D8] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[payment_detail] CHECK CONSTRAINT [FK__payment_d__produ__70DDC3D8]
GO
/****** Object:  ForeignKey [FK_payments_creator_by_foreign]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[payments]  WITH CHECK ADD  CONSTRAINT [FK_payments_creator_by_foreign] FOREIGN KEY([creator_by])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[payments] CHECK CONSTRAINT [FK_payments_creator_by_foreign]
GO
/****** Object:  ForeignKey [FK_payments_headquarter_id_foreign]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[payments]  WITH CHECK ADD  CONSTRAINT [FK_payments_headquarter_id_foreign] FOREIGN KEY([headquarter_id])
REFERENCES [dbo].[headquarters] ([id])
GO
ALTER TABLE [dbo].[payments] CHECK CONSTRAINT [FK_payments_headquarter_id_foreign]
GO
/****** Object:  ForeignKey [FK_payments_programming_id_foreign]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[payments]  WITH CHECK ADD  CONSTRAINT [FK_payments_programming_id_foreign] FOREIGN KEY([programming_id])
REFERENCES [dbo].[programming] ([id])
GO
ALTER TABLE [dbo].[payments] CHECK CONSTRAINT [FK_payments_programming_id_foreign]
GO
/****** Object:  ForeignKey [FK_programming_headquarter_id_foreign]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[programming]  WITH CHECK ADD  CONSTRAINT [FK_programming_headquarter_id_foreign] FOREIGN KEY([headquarter_id])
REFERENCES [dbo].[headquarters] ([id])
GO
ALTER TABLE [dbo].[programming] CHECK CONSTRAINT [FK_programming_headquarter_id_foreign]
GO
/****** Object:  ForeignKey [FK_programming_movie_id_foreign]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[programming]  WITH CHECK ADD  CONSTRAINT [FK_programming_movie_id_foreign] FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([id])
GO
ALTER TABLE [dbo].[programming] CHECK CONSTRAINT [FK_programming_movie_id_foreign]
GO
/****** Object:  ForeignKey [FK_users_headquarter_id_foreign]    Script Date: 06/21/2017 17:00:18 ******/
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_headquarter_id_foreign] FOREIGN KEY([headquarter_id])
REFERENCES [dbo].[headquarters] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_headquarter_id_foreign]
GO
