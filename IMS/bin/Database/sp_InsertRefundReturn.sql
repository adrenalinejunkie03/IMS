CREATE PROCEDURE sp_InsertRefundReturn
    @SalesID bigint,
    @date datetime,
    @doneBy int,
    @proid int,
    @quantity tinyint,
    @amount money
AS
    INSERT INTO refunds_returns VALUES (@SalesID, @date, @doneBy, @proid, @quantity, @amount);
