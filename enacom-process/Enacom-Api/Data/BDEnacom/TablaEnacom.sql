--Tabla de usuario Enacom
create table TEnacom(
	idDocumento char(20) Not Null,
	nombre char(20) Not Null,
	apellido char(20) Not Null,
	email char(30),
	nTelefono char(12),
	pin int Not Null
);