create table purchaseInvoice
(
pi_id bigint not null identity primary key,
pi_date date not null,
pi_doneBy int not null,
pi_suppID int not null
)

create procedure st_insertPurchaseInvoice
@date date,
@doneBy int,
@suppID int
as
insert into purchaseInvoice values(@date, @doneBy, @suppID)

create procedure st_getLastPurchaseID
as
select top 1 pii.pi_id from purchaseInvoice pii order by pii.pi_id desc

create table purchaseInvoiceDetails
(
pid_id bigint not null identity primary key,
pid_purchaseID bigint not null foreign key references purchaseInvoice(pi_id),
pid_productID int not null,
pid_productQuantity int not null,
pid_totalPrice money not null
)

create procedure st_insertPurchaseInvoiceDetails
@purchaseID bigint,
@proID int,
@quantity int,
@totalPrice money
as
insert into purchaseInvoiceDetails values (@purchaseID, @proID , @quantity , @totalPrice)


