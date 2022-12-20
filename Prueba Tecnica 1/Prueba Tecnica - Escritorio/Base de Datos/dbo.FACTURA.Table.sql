USE [Prueba]
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 20/12/2022 5:20:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA](
	[ID_FACTURA] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NUME_DOC] [numeric](18, 0) NOT NULL,
	[CODI_ESTADO] [numeric](2, 0) NOT NULL,
	[VALOR_FAC] [numeric](18, 0) NOT NULL,
	[FECHA_FAC] [datetime] NOT NULL,
 CONSTRAINT [PK_FACTURA] PRIMARY KEY CLUSTERED 
(
	[ID_FACTURA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_CLIENTES] FOREIGN KEY([NUME_DOC])
REFERENCES [dbo].[CLIENTES] ([NUME_DOC])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_CLIENTES]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_ESTADOS_FACTURA] FOREIGN KEY([CODI_ESTADO])
REFERENCES [dbo].[ESTADOS_FACTURA] ([CODI_ESTADO])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_ESTADOS_FACTURA]
GO
