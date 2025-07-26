create table products
(
pro_id int not null identity primary key,
pro_name varchar(50) not null,
pro_barcode nvarchar(100) not null,
pro_price money not null,
pro_expiry date,
pro_catID int not null foreign key references categories(cat_id)
)

create procedure st_productInsert
@name varchar(50),
@barcode nvarchar(100),
@price money,
@expiry date,
@catID int
as
insert into products values (@name,@barcode,@price,@expiry,@catID)



create procedure st_productUpdate
@name varchar(50),
@barcode nvarchar(100),
@price money,
@expiry date,
@catID int,
@proID int 
as
update products
set
pro_name = @name,
pro_expiry = @expiry,
pro_price = @price,
pro_catID = @catID,
pro_barcode = @barcode
where
pro_id = @proid


create procedure s_productDelete
@proID int
as
delete from products where pro_id = @proID

create procedure st_getProductsData
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
format (p.pro_expiry ,'dd-MMM,yyyy') as 'Expiry',
p.pro_price as 'Price',
p.pro_barcode as 'Barcode',
c.cat_name as 'Category',
c.cat_ID as 'Category ID'
from products p
inner join categories c
on c.cat_id = p.pro_catID

