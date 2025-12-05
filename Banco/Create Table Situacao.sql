create table tblSituacao (
id int identity primary key,
situacao varchar(50),
idUsuario int foreign key (idUsuario) references tblUsuario
)

insert into tblSituacao (situacao ) values ('Agendado'),('Efetivado'),('Cancelado')