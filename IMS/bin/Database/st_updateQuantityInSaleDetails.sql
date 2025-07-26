create procedure st_updateQuantityInSalesDetails
@quan tinyint,
@salID bigint
as
update
SalesDetails
set 
sd_quan = @quan
where
sd_salID = @salID
