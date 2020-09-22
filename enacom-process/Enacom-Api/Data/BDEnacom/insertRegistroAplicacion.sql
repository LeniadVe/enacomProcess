--insertar NOTIFICACION

insert into RegistroAplicacion (idNotificacion, destinatario, titulo, 
								descripcion, urlAplicacion, imagen) select * from @INFO_ARRAY
