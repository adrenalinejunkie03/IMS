create table productPrice
(
pp_proID int not null unique foreign key references products(pro_id) 
on delete cascade  on update cascade,
pp_buyingPrice money not null,
pp_sellingPrice money 
)

create procedure st_insertProductPrice
@proID int,
@bp money,
@sp money
as
insert into productPrice values(@proID,@bp,@sp
)

create procedure st_updateProductPrice
@proID int,
@bp money,
@sp money
as
update productPrice
set
pp_buyingPrice = @bp,
pp_sellingPrice = @sp
where
pp_proID = @proID