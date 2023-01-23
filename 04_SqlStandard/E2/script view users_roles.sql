 create view usersroles 
 as
 select r.idroles, u.idusers, r.rol, u.name from users u
 inner join roles r on u.roles_idroles = r.idroles