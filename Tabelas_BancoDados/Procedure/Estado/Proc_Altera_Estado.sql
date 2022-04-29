USE BD_CEP
GO

/****** Object:  StoredProcedure [dbo].[Proc_Editar_ESTADO]    Script Date: 28/04/2022 00:01:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Proc_Altera_Estado]
@Sigla varchar(2),
@IDESTADO int,
@Nome varchar(50)
as
Update Estado set Nome = @Nome, Sigla = @Sigla where ID = @IDESTADO
GO