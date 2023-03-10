USE [Prueba]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 20/12/2022 5:20:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[NUME_DOC] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](200) NOT NULL,
	[DIRECCION] [varchar](200) NOT NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[NUME_DOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
