-- create trigger for price change
alter TRIGGER priceChangeLogUpdate
ON inventories
AFTER UPDATE
AS
BEGIN
	   SET IDENTITY_INSERT priceChanges ON
       SET NOCOUNT ON
       DECLARE @product INT
       DECLARE @prevPrice INT
	     DECLARE @curPrice INT
	     SELECT @product = INSERTED.productID FROM INSERTED
	     SELECT @prevPrice = DELETED.productPrice FROM DELETED
       SELECT @curPrice = INSERTED.productPrice FROM INSERTED
	   INSERT INTO priceChanges (pchangetransID,productID, prevPrice, newPrice, dateChanged)  VALUES ((SELECT ISNULL(MAX(pchangetransID)+1,0) FROM dbo.priceChanges WITH(SERIALIZABLE, UPDLOCK)), @product, @prevPrice, @curPrice, CURRENT_TIMESTAMP)
		SET IDENTITY_INSERT priceChanges OFF
END	

-- update price
UPDATE inventories
SET productPrice = '120'
WHERE productID = '3'


-- check changes
select * from priceChanges 
select * from inventories
