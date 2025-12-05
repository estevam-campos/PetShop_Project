--senha --> Senac@123 = 57c4cdb2495854c8febf4440852e88a3
create table tblUsuario (
id int identity primary key,
nome varchar(100),
usuario varchar(20),
senha varchar(100),
ativo bit
)

insert into tblUsuario 
(nome, usuario, senha, ativo)
values
('Administrador', 'adm.admin', '57c4cdb2495854c8febf4440852e88a3', 1)