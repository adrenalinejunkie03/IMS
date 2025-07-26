create procedure st_getStocksDataLike
@data varchar(50)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
FORMAT (p.pro_expiry, 'dd-MMM,yyyy') as 'Expiry Date',
pp.pp_buyingPrice as 'Buying Price',
pp.pp_sellingPrice as 'Selling Price',
c.cat_name as 'Category',
s.st_quan as 'Available Stock',
case when (s.st_quan < 50) then 'LOW' else case when 
(s.st_quan<100 and s.st_quan>50) then 'Average' else case when (s.st_quan>=100)
then 'Good' end end end as 'Status' ,
pp.pp_buyingPrice * s.st_quan as 'Total Amount'
from stock s
inner join products p
on p.pro_id = s.st_proID
inner join categories c
on c.cat_id = p.pro_catID
inner join productPrice pp
on p.pro_id = pp.pp_proID
where

p.pro_name like '%'+ @data + '%'
or
p.pro_barcode like '%'+ @data + '%'
or
p.pro_expiry like '%'+ @data + '%'
or
pp.pp_buyingPrice like '%'+ @data + '%'
or
pp.pp_sellingPrice like '%'+ @data + '%'
or
c.cat_name like '%'+ @data + '%'
or
s.st_quan like '%'+ @data + '%'

