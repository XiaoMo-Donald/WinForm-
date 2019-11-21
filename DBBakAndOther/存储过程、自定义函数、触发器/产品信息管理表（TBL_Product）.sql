

--1.插入新记录

CREATE PROC prod_InsertProduct
@ProductID nvarchar(6),
@ProductName nvarchar(80),
@SpellingCode nvarchar(40),
@Barcode nvarchar(14),
@Special nvarchar(40),
@Unit nvarchar(6),
@Origin nvarchar(50),
@CategoryID nvarchar(6),
@PurchasePrice decimal(18,2),
@SalePrice decimal(18,2),
@Quantity int
AS
INSERT TBL_Product VALUES(@ProductID,@ProductName,@SpellingCode,@Barcode,@Special,@Unit,@Origin,@CategoryID,@PurchasePrice,@SalePrice,@Quantity)
RETURN

EXEC prod_InsertProduct '1','苹果','5555','1231','啊啊啊啊','斤','13','2','20','45',1



--2.删除记录
create proc prod_DeleteProductByProductID
@ProductID nvarchar(6)
as
delete TBL_Product where ProductID=@ProductID
return

exec prod_DeleteProductByProductID '123'



--3.更新记录
create proc prod_UpdateByProductID
@ProductID nvarchar(6),
@ProductName nvarchar(80),
@SpellingCode nvarchar(40),
@Barcode nvarchar(14),
@Special nvarchar(40),
@Unit nvarchar(6),
@Origin nvarchar(50),
@CategoryID nvarchar(6),
@PurchasePrice decimal(18,2),
@SalePrice decimal(18,2),
@Quantity int
AS
update TBL_Product 
set ProductName=@ProductName,SpellingCode=@SpellingCode,Barcode=@Barcode,Special=@Special,Unit=@Unit,Origin=@Origin,CategoryID=@CategoryID,PurchasePrice=@PurchasePrice,SalePrice=@SalePrice,Quantity=@Quantity
where ProductID=@ProductID
return

exec prod_UpdateByProductID '123','苹果1','55551','12311','啊啊啊啊1','斤1','131','2','201','451',11



--4.查询所有记录
create proc prod_GetAllProduct
as
select * from TBL_Product
return

exec prod_GetAllProduct



--5.根据ProductID查询记录
create proc prod_GetAllProductByProductID
@ProductID nvarchar(6)
as
select * from TBL_Product where ProductID=@ProductID
return

exec prod_GetAllProductByProductID '123'