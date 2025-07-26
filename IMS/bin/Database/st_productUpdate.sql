create procedure st_productUpdate
@name varchar(50),
@barcode nvarchar(100),
@expiry date,
@catID int,
@proID int 
as
update products
set
pro_name = @name,
pro_expiry = @expiry,
pro_catID = @catID,
pro_barcode = @barcode
where
pro_id = @proid

