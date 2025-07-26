create procedure st_getPurchaseInvoiceDetailsDataLIKE
@data varchar(50)
as
select
pid.pid_id as 'MPID',
pid.pid_productID as 'Product ID',
p.pro_name as 'Product',
pid.pid_productQuantity as 'Quantity',
pid.pid_totalPrice as 'Total Price',
pp.pp_buyingPrice as 'Per Unit Price'
from purchaseInvoice pii
inner join purchaseInvoiceDetails pid
inner join products p on p.pro_id = pid.pid_productID
on pii.pi_id = pid.pid_purchaseID
inner join productPrice pp
on p.pro_id = pp.pp_proID
where 
p.pro_name like '%'+ @data + '%'
or
pid.pid_productQuantity like '%'+ @data + '%'
or
pid.pid_totalPrice like '%'+ @data + '%'
or
pp.pp_buyingPrice like '%'+ @data + '%'

