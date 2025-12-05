CREATE TABLE tblAgendamento(
	id int IDENTITY,
	data datetime,
	observacao varchar(max),
	idAnimal int foreign key (idAnimal) references tblAnimal,
	idSituacao int foreign key (idSituacao) references tblSituacao,
	idProfissional int foreign key (idProfissional) references tblProfissional,
	idUsuario int foreign key (idUsuario) references tblUsuario
)
