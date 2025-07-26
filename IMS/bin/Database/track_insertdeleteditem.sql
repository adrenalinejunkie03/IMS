 create table trackDeletedItemsPI
 (
 pi_id bigint not null,
 usr_id int not null,
 pro_id int not null foreign key references products(pro_id) 
 on delete cascade on update cascade,
 pro_quan int not null
 )

 alter procedure st_insertDeletedItemPI
 @pi bigint,
 @usrID int,
 @proID int,
 @quan int,
 @date date
 as
 insert into trackDeletedItemsPI values(@pi,@usrID,@proID,@quan,@date)
 
 alter table trackDeletedItemsPI
 add del_date date not null