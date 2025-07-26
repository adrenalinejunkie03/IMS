create procedure st_getRefundInvoice
@saleID bigint
as
set @saleID = (select top 1 r.ref_SalesID from refunds_returns r order by r.ref_date desc)
select distinct 
s.sal_id as 'Sales ID',
p.pro_name as 'Product',
round(sd.sd_sellingPrice,0) as 'Selling Price',
round(sd.sd_discount,0) as 'Discount',
r.ref_quantity as 'Quantity',
r.ref_amount as 'Amount Refund',
u.usr_name as 'User',
format(r.ref_date, 'dd-MMM-yyyy hh:mm tt') as 'Date'

from refunds_returns r
inner join products p
on p.pro_id = r.ref_proid
inner join Sales s
on s.sal_id = r.ref_salesID
inner join users u
on u.usr_id = r.ref_doneBy
inner join SalesDetails sd
on p.pro_id = sd.sd_proID
where r.ref_salesID = @saleID
