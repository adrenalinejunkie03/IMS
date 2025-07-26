alter procedure st_getPurchaseInvoiceList
@month int,
@year int
as
select
pii.pi_id as 'ID',
su.sup_company+' '+FORMAT(pii.pi_date, 'dd-MMM-yyyy') as 'Company'
from purchaseInvoice pii 
inner join supplier su
on su.sup_id = pii.pi_suppID
where 
month(pii.pi_date) = @month and year(pii.pi_date) = @year

