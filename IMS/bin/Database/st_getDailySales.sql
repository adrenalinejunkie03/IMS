alter procedure st_getDailySales
@date date
as
select distinct
s.sal_id as 'Sales ID',
s.sal_totAmount as 'Total Amount',
s.sal_amtGiven as 'Amount Given',
s.sal_amtReturn as 'Returned Amount',
u.usr_name as 'User',
u.usr_id as 'User ID',
s.sal_totDis as 'Total Discount'

from Sales s inner join
SalesDetails sd
on s.sal_id = sd.sd_salID 
inner join users u
on u.usr_id = s.sal_doneBy
where convert(date,s.sal_date ) = @date

