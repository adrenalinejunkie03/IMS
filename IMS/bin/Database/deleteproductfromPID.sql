create procedure st_deleteProductFromPID
@mPID bigint
as
delete from purchaseInvoiceDetails
where pid_id = @mPID 
