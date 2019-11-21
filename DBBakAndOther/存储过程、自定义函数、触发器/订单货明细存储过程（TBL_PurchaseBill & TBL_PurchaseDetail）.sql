
use EntersSellsSaves

--根据PurchaseID 查询 订单信息（表：TBL_PurchaseBill）
create proc GetPurchaseBillAll
@PurchaseID nchar(12)
as
select * from TBL_PurchaseBill where PurchaseID=@PurchaseID


exec GetPurchaseBillAll ''

--根据PurchaseID 查询 订单明细（表:TBL_PurchaseDetail ）
create proc GetPurchaseDetailAll
@PurchaseID nchar(12)
as
select * from TBL_PurchaseDetail where PurchaseID=@PurchaseID

exec GetPurchaseDetailAll ''



--根据进货单编号更新订单记录
create proc bill_UpdatePurchaseBillByPurchaseID
@PurchaseID nchar(12),
@SupplierID nvarchar(6),
@PurchaseDate datetime,
@StockDate datetime,
@Clerk nvarchar(6),
@Examiner nvarchar(6),
@Custodian nvarchar(6),
@OnProcess smallint,
@Memo nvarchar(100)
as
update TBL_PurchaseBill 
set SupplierID=@SupplierID,PurchaseDate=@PurchaseDate,StockDate=@StockDate,Clerk=@Clerk,Examiner=@Examiner,Custodian=@Custodian,OnProcess=@OnProcess,Memo=@Memo
where PurchaseID=@PurchaseID

exec bill_UpdatePurchaseBillByPurchaseID '','','','','','','','',''



--新增订单明细记录
create proc InsertPurchaseDetail
@PurchaseID nchar(12),
@PurchaseDetailID smallint,
@ProductID nvarchar(6),
@PurchasePrice decimal(18,2),
@Quantity int
as
insert TBL_PurchaseDetail values(@PurchaseID,@PurchaseDetailID,@ProductID,@PurchasePrice,@Quantity)


exec InsertPurchaseDetail '','','','',''



--根据订单编号删除订单明细记录
create proc DeletePurchaseDetailByPurchaseID
@PurchaseID nchar(12)
as
delete TBL_PurchaseDetail where PurchaseID=@PurchaseID


exec DeletePurchaseDetailByPurchaseID ''



--插入新的订单
create proc bill_InsertPurchaseBill
@PurchaseID nchar(12),
@SupplierID nvarchar(6),
@PurchaseDate datetime,
@StockDate datetime,
@Clerk nvarchar(6),
@Examiner nvarchar(6),
@Custodian nvarchar(6),
@OnProcess smallint,
@Memo nvarchar(100)
as
insert TBL_PurchaseBill values(@PurchaseID ,@SupplierID,@PurchaseDate,@StockDate,@Clerk ,@Examiner,@Custodian,@OnProcess,@Memo)



--删除订单
create proc bill_DeletePurchaseBill
@PurchaseID nchar(12)
as
delete TBL_PurchaseBill where PurchaseID=PurchaseID