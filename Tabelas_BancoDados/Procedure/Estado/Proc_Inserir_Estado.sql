USE BD_CEP
GO

/****** Object:  StoredProcedure [dbo].[Proc_Inserir_ESTADO]    Script Date: 28/04/2022 00:03:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Proc_Inserir_Estado]
@Sigla varchar(2),
@IDESTADO int output,
@Nome varchar(50)
as
insert into Estado(Nome,Sigla) Values(@Nome,@Sigla)

GO


