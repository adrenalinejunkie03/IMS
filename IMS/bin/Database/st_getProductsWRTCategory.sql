create procedure st_getProductsWRTCategory
@catID int
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
pp.pp_buyingPrice as 'Buying Price'
from products p
inner join productPrice pp
on p.pro_id = pp.pp_proID
inner join categories c
on c.cat_id = p.pro_catID
where c.cat_id = @catID

