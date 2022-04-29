USE BD_CEP
GO

/****** Object:  StoredProcedure [dbo].[Proc_Remover_ESTADO]    Script Date: 28/04/2022 00:03:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Proc_Remover_Estado]
@IDESTADO int
as
Delete from Estado where ID = @IDESTADO

GO
