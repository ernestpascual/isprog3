-- dashboard values
select sum(a.productPrice * b.transQtyPurchase) as 'Dashboard'
from inventories a
inner join sales b ON b.productID =a.productID -- total overall sales
UNION
select sum(a.productPrice * b.transQtyPurchase)from inventories a
inner join sales b ON b.productID =a.productID
WHERE DATEPART(mm,transDate) = DATEPART(mm, GETDATE()) 
AND DATEPART(dd,transDate) = DATEPART(dd, GETDATE()) -- sales for the day



-- stored procedure
create procedure dbo.DashboardPrice
AS
select sum(a.productPrice * b.transQtyPurchase) as 'Dashboard'
from inventories a
inner join sales b ON b.productID =a.productID 
UNION
select sum(a.productPrice * b.transQtyPurchase)from inventories a
inner join sales b ON b.productID =a.productID
WHERE DATEPART(mm,transDate) = DATEPART(mm, GETDATE()) 
AND DATEPART(dd,transDate) = DATEPART(dd, GETDATE())

EXEC dbo.DashboardPrice


--- day sales 



create procedure dbo.DaySalePrice
AS
select sum(a.productPrice * b.transQtyPurchase)from inventories a
inner join sales b ON b.productID =a.productID
WHERE DATEPART(mm,transDate) = DATEPART(mm, GETDATE()) 
AND DATEPART(dd,transDate) = DATEPART(dd, GETDATE())


EXEC dbo.DaySalePrice
