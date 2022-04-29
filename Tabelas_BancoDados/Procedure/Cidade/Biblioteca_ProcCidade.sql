

Use BD_CEP
go
Create Procedure Proc_Remover_Cidade
@ID int
as
Delete from CIDADE where ID = @ID
GO

Use BD_CEP
go
Create Procedure Proc_Alterar_Cidade
@ID int,
@NOME varchar(50),
@IDESTADO int,
@CEP varchar(50)
as
Update CIDADE set Nome = @Nome, ID_ESTADO = @IDESTADO, CEP = @CEP where ID = @ID
GO

Use BD_CEP
go
CREATE Procedure Proc_Buscar_Cidade
@textobuscar  varchar(50)
as
select * from CIDADE where Nome like @textobuscar +'%'
GO

Use BD_CEP
go
Create Procedure Proc_Inserir_Cidade
@NOME varchar(50),
@IDESTADO int,
@CEP varchar(50)
as
insert CIDADE (Nome,ID_ESTADO,CEP) values (@NOME,@IDESTADO,@CEP)
GO

Use BD_CEP
go
CREATE Procedure Proc_Mostrar_Cidade
as
select CIDADE.ID, CIDADE.Nome as Cidade, Estado.Sigla as Estado, CIDADE.CEP from CIDADE, Estado where Cidade.ID_ESTADO = Estado.ID order by CIDADE.Nome
GO