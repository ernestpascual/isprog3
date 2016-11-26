--- create display sales procedure
create procedure dbo.displaysales
AS
select transDate, ORNo, productName, transQtyPurchase, productPrice from inventories a inner join sales b ON a.productID = b.productID;

--- create date filter
create procedure dbo.searchdate 
( @date INT,
@month INT,
@year INT)
AS 
select transDate, ORNo, productName, transQtyPurchase, productPrice from inventories a inner join sales b ON a.productID = b.productID
where datepart(yy, transDate) = @year AND datepart(mm, transDate) = @month AND datepart(dd, transDate) = @date;

--- create product filter
create procedure dbo.searchitem @product varchar(100)
AS
select transDate, ORNo, productName, transQtyPurchase, productPrice from inventories a inner join sales b ON a.productID = b.productID
where productName like '%' + @product + '%';


--- display all sales special procedure
exec dbo.displaysales

--- product filter special procedure
exec dbo.searchitem @product = 'shirt';

--- date filter special procedure
exec dbo.searchdate @date = 24, @month = 11, @year = 2016;


