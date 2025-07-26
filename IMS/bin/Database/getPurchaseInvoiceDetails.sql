create procedure st_getPurchaseInvoiceDetails
@pid bigint
as
select
pid.pid_productID as 'Product ID',
p.pro_name as 'Product',
pid.pid_productQuantity as 'Quantity',
pid.pid_totalPrice as 'Total Price',
p.pro_price as 'Per Unit Price'
from purchaseInvoice pii
inner join purchaseInvoiceDetails pid
inner join products p on p.pro_id = pid.pid_productID
on pii.pi_id = pid.pid_purchaseID
where pii.pi_id = @pid;

-- Test the stored procedure with different @pid values
 --EXEC st_getPurchaseInvoiceDetails @pid = 1; -- Replace 1 with a valid pi_id value
--EXEC st_getPurchaseInvoiceDetails @pid = 8; -- Replace 2 with another valid pi_id value


