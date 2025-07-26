create procedure st_getproductsWRTCategoryDataLIKE
@data varchar(50)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
pp.pp_buyingPrice as 'Buying Price',
case when (pp.pp_sellingPrice is null) then 0 else pp.pp_sellingPrice end as 'Selling Price',
case when (pp.pp_discount is null) then 0 else pp.pp_discount end as 'Discount',
case when (pp.pp_profitPercentage is null) then 0 else pp.pp_profitPercentage end as 'Proft Percentage'
from products p
inner join productPrice pp
on p.pro_id = pp.pp_proID
inner join categories c
on c.cat_id = p.pro_catID
where 
p.pro_name like '%'+ @data + '%'
or
pp.pp_buyingPrice like '%'+ @data + '%'
or 
pp.pp_profitPercentage like '%'+ @data + '%'
or
pp.pp_discount like '%'+ @data + '%'
or
pp.pp_sellingPrice like '%'+ @data + '%'
