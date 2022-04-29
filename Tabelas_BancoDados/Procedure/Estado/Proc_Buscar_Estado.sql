USE BD_CEP
GO

/****** Object:  StoredProcedure [dbo].[Proc_Buscar_ESTADO]    Script Date: 28/04/2022 00:03:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Proc_Buscar_Estado]
@textobuscar  varchar(2)
as
select * from Estado where Nome like @textobuscar +'%'

GO
