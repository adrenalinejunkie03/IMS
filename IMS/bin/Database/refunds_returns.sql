create table refunds_returns
(
ref_salesID bigint foreign key references Sales(sal_id),
ref_date datetime not null,
ref_doneBy int not null,
ref_proid bigint not null,
ref_quantity tinyint not null,
ref_amount money not null
)