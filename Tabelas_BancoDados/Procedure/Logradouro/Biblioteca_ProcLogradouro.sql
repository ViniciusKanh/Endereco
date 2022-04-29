

use BD_CEP
go
Create Procedure Proc_Mostrar_Logradouro 
as
select* from Logradouro  order by Nome
go

use BD_CEP
go
Create Procedure Proc_Inserir_Logradouro  
@NOME varchar(50)
as
insert Logradouro (Nome) values (@NOME)
go

use BD_CEP
go
Create Procedure Proc_Alterar_Logradouro 
@ID int,
@NOME varchar(50)
as
Update Logradouro  set Nome = @NOME where ID = @ID
go

use BD_CEP
go
Create Procedure Proc_Buscar_Logradouro 
@textobuscar  varchar(2)
as
select * from Logradouro  where Nome like @textobuscar +'%'
go

use BD_CEP
go
Create Procedure Proc_Remover_Logradouro 
@ID int
as
Delete from Logradouro  where ID = @ID
go

