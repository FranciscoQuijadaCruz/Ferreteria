USE [Ferreteria]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 12/03/2018 23:11:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](150) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON
INSERT [dbo].[Categoria] ([id], [nombre], [descripcion]) VALUES (1, N'Herramienta', N'Pinza, Llaves, Dados, etc')
INSERT [dbo].[Categoria] ([id], [nombre], [descripcion]) VALUES (2, N'Construccion', N'Todo lo necesario para la construccion')
INSERT [dbo].[Categoria] ([id], [nombre], [descripcion]) VALUES (3, N'Plomeria', N'Articulos de plomeria')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
/****** Object:  Table [dbo].[Producto]    Script Date: 12/03/2018 23:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[descripcion] [varchar](500) NULL,
	[descripcionCorta] [varchar](100) NULL,
	[categoria] [int] NULL,
	[precio] [decimal](12, 2) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (1, N'Pinzas de corte ', N'Pinzas para cortarse', N'Pinza de corte shidas', 1, CAST(100.00 AS Decimal(12, 2)))
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (2, N'Cemento', N'Cemento campa', N'Saco de 25 kg', 2, CAST(180.00 AS Decimal(12, 2)))
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (3, N'Cemento shido', N'Cemento campa', N'saco de 50kg', 2, CAST(280.00 AS Decimal(12, 2)))
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (4, N'Coople de 1/4', N'Coople de cobre', N'Coople de cobre de 1/4', 3, CAST(5.00 AS Decimal(12, 2)))
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (5, N'Coople de 1/2', N'Coople de cobre', N'Coople 1/2', 3, CAST(8.00 AS Decimal(12, 2)))
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (6, N'Ni idea', N'Calando', N'Ye mero queda', 2, CAST(10.22 AS Decimal(12, 2)))
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (7, N'Asi nomas', N'ergrg', N'wef', 0, CAST(10.22 AS Decimal(12, 2)))
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [descripcionCorta], [categoria], [precio]) VALUES (8, N'Asi nomas2', N'ergrg', N'wef', 0, CAST(10.22 AS Decimal(12, 2)))
SET IDENTITY_INSERT [dbo].[Producto] OFF
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/03/2018 23:11:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[email] [varchar](150) NULL,
	[contrasena] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([id], [nombre], [email], [contrasena]) VALUES (1, N'Francisco Quijada', N'fran@gmail.com', N'12345')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  StoredProcedure [dbo].[SEARCH_USERS]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCH_USERS]
AS
 SELECT * FROM usuario
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_USER]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCH_USER] --RUIZ MANZ
@ID_USER int
AS
  SELECT * FROM usuario WHERE id = @ID_USER
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_PRODUCTS_CAT]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCH_PRODUCTS_CAT]
@ID_CATEGORY int
AS
  SELECT * FROM producto WHERE categoria = @ID_CATEGORY
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_PRODUCTS]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCH_PRODUCTS]
AS
 SELECT * FROM producto
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_PRODUCT]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCH_PRODUCT]
@ID_PRODUCT int
AS
  SELECT * FROM producto WHERE id = @ID_PRODUCT
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CATEGORY]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCH_CATEGORY]
@ID_CATEGORY int
AS
  SELECT * FROM categoria WHERE id = @ID_CATEGORY
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_CATEGORIES]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCH_CATEGORIES]
AS
 SELECT * FROM categoria
GO
/****** Object:  StoredProcedure [dbo].[LOGIN_USER]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LOGIN_USER]
@EMAIL varchar(150),
@CONTRASENA varchar(150)
AS
	SELECT * FROM usuario WHERE email = @EMAIL AND contrasena = @CONTRASENA
GO
/****** Object:  StoredProcedure [dbo].[EDIT_USER]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[EDIT_USER]
@NOMBRE	varchar(150),
@EMAIL varchar(150),
@CONTRASENA varchar(150),
@ID_USER int
AS
	UPDATE usuario SET nombre=@NOMBRE, email=@EMAIL, contrasena=@CONTRASENA
	WHERE id = @ID_USER
GO
/****** Object:  StoredProcedure [dbo].[EDIT_PRODUCT]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[EDIT_PRODUCT]
@NOMBRE	varchar(150),
@DESCRIPCION varchar(500),
@DESCRIPCION_CORTA varchar(100),
@CATEGORIA int,
@PRECIO decimal(12,2),
@ID_PRODUCT int
AS
	UPDATE producto SET nombre=@NOMBRE, descripcion=@DESCRIPCION,
						descripcionCorta = @DESCRIPCION_CORTA,
						categoria = @CATEGORIA,
						precio = @PRECIO
	WHERE id = @ID_PRODUCT
GO
/****** Object:  StoredProcedure [dbo].[EDIT_CATEGORY]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[EDIT_CATEGORY]
@NOMBRE	varchar(150),
@DESCRIPCION varchar(150),
@ID_CATEGORY int
AS
	UPDATE categoria SET nombre=@NOMBRE, descripcion=@DESCRIPCION
	WHERE id = @ID_CATEGORY
GO
/****** Object:  StoredProcedure [dbo].[DELETE_USER]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_USER]
@ID_USER int
AS
 DELETE FROM usuario WHERE id = @ID_USER
GO
/****** Object:  StoredProcedure [dbo].[DELETE_PRODUCT]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_PRODUCT]
@ID_PRODUCT int
AS
 DELETE FROM producto WHERE id = @ID_PRODUCT
GO
/****** Object:  StoredProcedure [dbo].[DELETE_CATEGORY]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_CATEGORY]
@ID_CATEGORY int
AS
 DELETE FROM categoria WHERE id = @ID_CATEGORY
GO
/****** Object:  StoredProcedure [dbo].[ADD_USER]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_USER]
@NOMBRE	varchar(150),
@EMAIL varchar(150),
@CONTRASENA varchar(150)
AS

	INSERT INTO usuario (nombre,email,contrasena) 
	VALUES (@NOMBRE,@EMAIL,@CONTRASENA)
GO
/****** Object:  StoredProcedure [dbo].[ADD_PRODUCT]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_PRODUCT]
@NOMBRE	varchar(150),
@DESCRIPCION varchar(500),
@DESCRIPCION_CORTA varchar(100),
@CATEGORIA int,
@PRECIO decimal(12,2)
AS

	INSERT INTO producto (nombre,descripcion,descripcionCorta,categoria,precio) 
	VALUES (@NOMBRE,@DESCRIPCION,@DESCRIPCION_CORTA,@CATEGORIA,@PRECIO)
GO
/****** Object:  StoredProcedure [dbo].[ADD_CATEGORY]    Script Date: 12/03/2018 23:11:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_CATEGORY]
@NOMBRE	varchar(150),
@DESCRIPCION varchar(150)
AS

	INSERT INTO categoria (nombre,descripcion) 
	VALUES (@NOMBRE,@DESCRIPCION)
GO
