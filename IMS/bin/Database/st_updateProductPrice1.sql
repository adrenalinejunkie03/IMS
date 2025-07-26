create procedure st_updateProductPrice1
@proID int,
@bp money
as
update productPrice
set
pp_buyingPrice = @bp
where
pp_proID = @proID

