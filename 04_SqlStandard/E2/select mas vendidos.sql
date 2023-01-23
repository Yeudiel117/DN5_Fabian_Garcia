Select
    idsales
    , date
    , idproducttype
From
    sales
Group By
    idproducttype
Having
    Count(*) > 1
;