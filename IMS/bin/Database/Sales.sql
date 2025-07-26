create table Sales
(
sal_id bigint not null identity primary key,
sal_doneBy int not null,
sal_date datetime not null,
sal_totAmount float,
sal_totDis float,
sal_amtGiven float,
sal_amtReturn float
)

create procedure insertSales
@done int,
@date datetime,
@totamt float,
@totdis float,
@given float,
@return float
as
insert into Sales values (@done,@date,@totamt,@totdis,@given,@return)

create procedure st_getSalesID
as
select top 1 s.sal_id as 'Sales ID' from Sales s order by s.sal_id desc


create table SalesDetails
(
sd_salID bigint not null foreign key references Sales(sal_id) on delete no action on update no action,
sd_proID bigint not null,
sd_quan int
)

create procedure st_insertSalesDetails
@salID bigint,
@proID bigint,
@quan int
as
insert into SalesDetails values (@salID,@proID,@quan)