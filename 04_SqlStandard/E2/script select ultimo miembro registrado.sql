SELECT 
	E1.idmembers, 
    E1.name, 
    E1.membersince, 
    E1.membershiptypes_idmembershiptypes, 
    E1.cities_idcities, 
    E2.membership 
FROM members E1 JOIN membershiptypes E2
WHERE membersince IN (SELECT max(membersince) FROM members) 
AND E1.membershiptypes_idmembershiptypes = E2.idmembershiptypes 

