create view productsinexistence
as
select i.idinventory, p.idproducttypes, i.amount, p.productname from inventory i
inner join producttypes p on i.productTypes_idproducttypes = p.idproducttypes