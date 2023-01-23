insert into roles (idroles, rol) values (1, "owner");
insert into roles (idroles, rol) values (2, "admin");
insert into roles (idroles, rol) values (3, "member");
insert into roles (idroles, rol) values (4, "user");
insert into roles (idroles, rol) values (5, "visitor");

insert into users(idusers, name, roles_idroles) values (1, "Fabian", "1");
insert into users(idusers, name, roles_idroles) values (2, "Juan", "2");
insert into users(idusers, name, roles_idroles) values (3, "Roberto", "3");
insert into users(idusers, name, roles_idroles) values (4, "Daniela", "3");
insert into users(idusers, name, roles_idroles) values (5, "Raul", "4");

insert into cities(idcities, city) values (1, "Uruapan");
insert into cities(idcities, city) values (2, "Morelia");
insert into cities(idcities, city) values (3, "Monterrey");
insert into cities(idcities, city) values (4, "Nuevo Laredo");
insert into cities(idcities, city) values (5, "Tepic");

insert into membershiptypes(idmembershiptypes, membership, duration) values (1, "Diamond", 12);
insert into membershiptypes(idmembershiptypes, membership, duration) values (2, "Platinum", 8);
insert into membershiptypes(idmembershiptypes, membership, duration) values (3, "Gold", 6);
insert into membershiptypes(idmembershiptypes, membership, duration) values (4, "Silver", 3);
insert into membershiptypes(idmembershiptypes, membership, duration) values (5, "Bronze", 1);

insert into members(idmembers, name, membersince, membershiptypes_idmembershiptypes, cities_idcities) values (1, "Mario", '2020-12-15', 3, 1);
insert into members(idmembers, name, membersince, membershiptypes_idmembershiptypes, cities_idcities) values (2, "Roberto", '2021-05-11', 3, 3);
insert into members(idmembers, name, membersince, membershiptypes_idmembershiptypes, cities_idcities) values (3, "Daniela", '2022-03-30', 1, 1);
insert into members(idmembers, name, membersince, membershiptypes_idmembershiptypes, cities_idcities) values (4, "Luis", '2019-09-19', 4, 2);
insert into members(idmembers, name, membersince, membershiptypes_idmembershiptypes, cities_idcities) values (5, "Amado", '2023-01-02', 5, 5);

insert into equipmenttype(idequipmenttype, type) values (1, "chest press");
insert into equipmenttype(idequipmenttype, type) values (2, "dip machine");
insert into equipmenttype(idequipmenttype, type) values (3, "chest fly");
insert into equipmenttype(idequipmenttype, type) values (4, "bench press");
insert into equipmenttype(idequipmenttype, type) values (5, "curl machine");

insert into measuretype(idmeasureType, type) values (1, "kg");
insert into measuretype(idmeasureType, type) values (2, "cm");
insert into measuretype(idmeasureType, type) values (3, "lb");
insert into measuretype(idmeasureType, type) values (4, "ft");
insert into measuretype(idmeasureType, type) values (5, "oz");

insert into producttypes(idproducttypes, productname, cost, measureType_idmeasureType) values (1, "protein X", 50, 5);
insert into producttypes(idproducttypes, productname, cost, measureType_idmeasureType) values (2, "protein Y", 50, 5);
insert into producttypes(idproducttypes, productname, cost, measureType_idmeasureType) values (3, "weight", 10, 1);
insert into producttypes(idproducttypes, productname, cost, measureType_idmeasureType) values (4, "nutritive bar", 3, 5);
insert into producttypes(idproducttypes, productname, cost, measureType_idmeasureType) values (5, "protein shake", 10, 5);

insert into inventory(idinventory, amount, productTypes_idproducttypes) values (1, 10, 1);
insert into inventory(idinventory, amount, productTypes_idproducttypes) values (2, 10, 2);
insert into inventory(idinventory, amount, productTypes_idproducttypes) values (3, 3, 3);
insert into inventory(idinventory, amount, productTypes_idproducttypes) values (4, 20, 4);
insert into inventory(idinventory, amount, productTypes_idproducttypes) values (5, 15, 5);

insert into sales(idsales, date) values (1, '2022-12-05');
insert into sales(idsales, date) values (2, '2022-12-06');
insert into sales(idsales, date) values (3, '2022-12-06');
insert into sales(idsales, date) values (4, '2022-12-10');
insert into sales(idsales, date) values (5, '2022-12-12');

insert into sales_has_producttypes(sales_idsales, productTypes_idproducttypes) values (1, 2);
insert into sales_has_producttypes(sales_idsales, productTypes_idproducttypes) values (2, 3);
insert into sales_has_producttypes(sales_idsales, productTypes_idproducttypes) values (3, 4);
insert into sales_has_producttypes(sales_idsales, productTypes_idproducttypes) values (4, 5);
insert into sales_has_producttypes(sales_idsales, productTypes_idproducttypes) values (5, 1);


