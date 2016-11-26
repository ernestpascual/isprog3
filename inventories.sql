--- update inventories
create procedure updateInventories
(@product NVARCHAR(100),
@price MONEY,
@qty INT)
AS
update inventories set productName = @product ,productPrice =@price ,productStockQty =@qty where productName =@product
