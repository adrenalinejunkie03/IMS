create procedure st_getSalesReceiptWRTSalesIDDataLIKE
@data varchar(50)
as
select 
s.sal_id as 'Sales ID',
p.pro_barcode as 'Barcode',
p.pro_id as 'Product ID',
p.pro_name as 'Product',
sd.sd_quan as 'Quantity',
round(sd.sd_sellingPrice,0) as 'Product Price',
round(sd.sd_discount,0) as 'Product Discount',
round(sd.sd_discount,0) as 'Total Per Product Discount',
round((sd.sd_sellingPrice * sd.sd_quan),0) as 'Per Product Total',
s.sal_totDis as 'Total Discount',
s.sal_totAmount as 'Total Amount',
s.sal_amtGiven as 'Amount Given',
s.sal_amtReturn as 'Amount Return',
format(s.sal_date,'dd-MM-yyyy hh:mm:ss tt') as 'Date',
pp.pp_sellingPrice as 'Product Price',
(pp.pp_sellingPrice * pp.pp_discount / 100) * sd.sd_quan as 'Per Product Discount',
(pp.pp_sellingPrice * sd.sd_quan) - ((pp.pp_sellingPrice * pp.pp_discount / 100) * sd.sd_quan) as 'Per Product Total',
u.usr_name as 'User',
case when (s.sal_payType = 0) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_payType = 2) then 'Credit Card' end end end as 'Pay Type'
from Sales s inner join 
SalesDetails sd on s.sal_id = sd.sd_salID
inner join products p
on p.pro_id = sd.sd_proID
inner join productPrice pp
on pp.pp_proID = p.pro_id
inner join users u
on u.usr_id = s.sal_doneBy
where 
p.pro_name like '%'+ @data + '%'
or
p.pro_barcode like '%'+ @data + '%'
or
s.sal_payType like '%'+ @data + '%'
or
s.sal_id like '%'+ @data + '%'
order by s.sal_id desc
