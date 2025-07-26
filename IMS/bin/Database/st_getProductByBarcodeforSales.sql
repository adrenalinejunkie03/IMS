create procedure st_getProductByBarcodeforSales
@barcode nvarchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
pp.pp_sellingPrice as 'Selling Price',
pp.pp_sellingPrice*pp.pp_discount/100 as 'Discount',
pp.pp_sellingPrice - (pp.pp_sellingPrice*pp.pp_discount/100) as 'Final Selling Price'
from products p 
inner join productPrice pp
on p.pro_id = pp.pp_proID
where p.pro_barcode = @barcode