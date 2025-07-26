create procedure st_getProductsDataLIKE
@data varchar(50)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
format (p.pro_expiry ,'dd-MMM,yyyy') as 'Expiry',
p.pro_barcode as 'Barcode',
c.cat_name as 'Category',
c.cat_ID as 'Category ID'
from products p
inner join categories c
on c.cat_id = p.pro_catID
where 
p.pro_name like '%'+ @data + '%'
or
p.pro_expiry like '%'+ @data + '%'
or
p.pro_barcode like '%'+ @data + '%'
or
c.cat_name like '%'+ @data + '%'

