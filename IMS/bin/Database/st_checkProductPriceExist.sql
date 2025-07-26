create procedure st_checkProductPriceExist
@proID int
as
select * from productPrice where pp_proID = @proID