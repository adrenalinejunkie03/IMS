create procedure getProductStockWRTProID
@proID int
as
select s.st_quan from stock s where s.st_proID = @proID
