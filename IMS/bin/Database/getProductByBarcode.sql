alter procedure st_getProductByBarcode
@barcode nvarchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
ROUND(p.pro_price,2) as 'Price',
p.pro_barcode as 'Barcode'

from products p where p.pro_barcode = @barcode


