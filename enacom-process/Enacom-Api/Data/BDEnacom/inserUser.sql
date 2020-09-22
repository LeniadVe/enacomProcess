--insertar usuario

--insert into UsuarioEnacom values ('100','daniel','amaya','correo','1122334455','1234')

insert into UsuarioEnacom (idDocumento,nombre,apellido,email,nTelefono,pin) select * from @INFO_ARRAY
