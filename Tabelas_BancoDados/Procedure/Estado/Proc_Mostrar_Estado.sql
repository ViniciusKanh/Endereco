USE BD_CEP
GO

/****** Object:  StoredProcedure [dbo].[Proc_Mostrar_ESTADO]    Script Date: 28/04/2022 00:03:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Proc_Mostrar_Estado]
as
select * from Estado
order by Nome desc


GO