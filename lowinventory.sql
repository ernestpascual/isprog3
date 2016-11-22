--- low inventory procedure
create procedure dbo.lowinventory
AS
select productName from inventories
WHERE productStockQty < productStockReq


EXEC dbo.lowinventory



--- low inventory query
select productName from inventories
WHERE productStockQty < productStockReq
