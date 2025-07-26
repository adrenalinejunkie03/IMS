create procedure st_getCompleteSalesDetails
@date date = null,
@month tinyint = null,
@year int = null
as
if(@date is not null and @month is null and @year is null)
begin
select 
s.sal_id as 'Sales ID',
s.sal_totAmount as 'Total Amount',
u.usr_name as 'User',
format(s.sal_date , 'dd-MMM-yyyy') as 'Date', 
case when(s.sal_payType = 1) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_paytype = 2) then 'Credit Card' end end end as 'Payment Type',
s.sal_amtGiven as 'Amount Received',
s.sal_amtReturn as 'Amount Return'
from Sales s
inner join SalesDetails sd 
on s.sal_id = sd.sd_salID
inner join users u
on u.usr_id = s.sal_doneBy
where s.sal_date = @date
group by s.sal_id , u.usr_name , s.sal_date , s.sal_payType , s.sal_amtGiven , s.sal_amtReturn, s.sal_totAmount
end

else if(@date is null and @month is not null and @year is not null)
begin
select 
s.sal_id as 'Sales ID',
s.sal_totAmount as 'Total Amount',
u.usr_name as 'User',
format(s.sal_date , 'dd-MMM-yyyy') as 'Date', 
case when(s.sal_payType = 1) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_paytype = 2) then 'Credit Card' end end end as 'Payment Type',
s.sal_amtGiven as 'Amount Received',
s.sal_amtReturn as 'Amount Return'
from Sales s
inner join SalesDetails sd 
on s.sal_id = sd.sd_salID
inner join users u
on u.usr_id = s.sal_doneBy
where 
month(s.sal_date) = @month
and
year(s.sal_date) = @year
group by s.sal_id , u.usr_name , s.sal_date , s.sal_payType , s.sal_amtGiven , s.sal_amtReturn, s.sal_totAmount
end

else if(@date is null and @month is null and @year is not null)
begin
select 
s.sal_id as 'Sales ID',
s.sal_totAmount as 'Total Amount',
u.usr_name as 'User',
format(s.sal_date , 'dd-MMM-yyyy') as 'Date', 
case when(s.sal_payType = 1) then 'Cash' else case when (s.sal_payType = 1) then 'Debit Card' else case when (s.sal_paytype = 2) then 'Credit Card' end end end as 'Payment Type',
s.sal_amtGiven as 'Amount Received',
s.sal_amtReturn as 'Amount Return'
from Sales s
inner join SalesDetails sd 
on s.sal_id = sd.sd_salID
inner join users u
on u.usr_id = s.sal_doneBy
where 
year(s.sal_date) = @year
group by s.sal_id , u.usr_name , s.sal_date , s.sal_payType , s.sal_amtGiven , s.sal_amtReturn, s.sal_totAmount
end


