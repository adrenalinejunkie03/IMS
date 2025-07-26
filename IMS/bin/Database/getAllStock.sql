alter procedure st_getALLStock
as
select 
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
FORMAT (p.pro_expiry, 'dd-MMM,yyyy') as 'Expiry Date',
p.pro_price as 'Price',
c.cat_name as 'Category',
s.st_quan as 'Available Stock',
case when (s.st_quan < 50) then 'LOW' else case when 
(s.st_quan<100 and s.st_quan>50) then 'Average' else case when (s.st_quan>=100)
then 'Good' end end end as 'Status' ,
p.pro_price * s.st_quan as 'Total Amount'
from stock s
inner join products p
on p.pro_id = s.st_proID
inner join categories c
on c.cat_id = p.pro_catID