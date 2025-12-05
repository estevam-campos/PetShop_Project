create table tblProfissional (
id int identity primary key,
nome varchar(100),
atuacao varchar(100),
ativo bit,
idUsuario int foreign key (idUsuario) references tblUsuario)