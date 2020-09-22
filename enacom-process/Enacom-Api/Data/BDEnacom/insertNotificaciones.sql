--insertar NOTIFICACION

insert into Notificacion (idNotificacion,nombreAplicacion, fecha, hora) select * from @INFO_ARRAY
