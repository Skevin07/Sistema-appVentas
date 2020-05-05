use sistema_ventas;

select id, Email, tipo_rol

from tb_usuarios
inner join roles_usuarios

on tb_usuarios.Id = roles_usuarios.id_Rol_Usuario;