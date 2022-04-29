USE BD_CEP
GO

/****** Object:  Table [dbo].[Endereco]    Script Date: 27/04/2022 23:59:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Endereco](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CEP] [varchar](50) NOT NULL,
	[ID_Cidade] [int] NOT NULL,
	[ID_Bairro] [int] NOT NULL,
	[ID_TipoLogradouro] [int] NOT NULL,
	[ID_Logradouro] [int] NOT NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Bairro] FOREIGN KEY([ID_Bairro])
REFERENCES [dbo].[Bairro] ([ID])
GO

ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Bairro]
GO

ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Cidade] FOREIGN KEY([ID_Cidade])
REFERENCES [dbo].[CIDADE] ([ID])
GO

ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Cidade]
GO

ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Logradouro] FOREIGN KEY([ID_Logradouro])
REFERENCES [dbo].[Logradouro] ([ID])
GO

ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Logradouro]
GO

ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_TipoLogradouro] FOREIGN KEY([ID_TipoLogradouro])
REFERENCES [dbo].[Tipo_logradouro] ([ID])
GO

ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_TipoLogradouro]
GO


