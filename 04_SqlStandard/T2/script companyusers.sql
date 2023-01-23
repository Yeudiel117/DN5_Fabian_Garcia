create view companyusers
as
select c.idcompany, u.iduser, u.email, c.location from users u
inner join company c on u.idcompany = c.idcompany;


alter TABLE users
add constraint company_users
	foreign key (idcompany)
    references company (idcompany);
    
alter table users
add index company_users_idx (idcompany asc) visible;