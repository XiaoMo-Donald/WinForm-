
--根据日期获得订单编号（标量函数）

create function CreatePurchaseID(@purchaseDate datetime)
returns nchar(12)
as
begin
declare @purchaseID nchar(12);
declare @date nvarchar(8);
declare @maxpurchaseID nchar(12);

set @date=CONVERT(nvarchar(8),@purchaseDate,112)
select @maxpurchaseID=max(PurchaseID) from TBL_PurchaseBill WHERE PurchaseID like @date+'%'
if(@maxPurchaseID is null)
set @purchaseID=@date+'0001'
else
set @purchaseID=@date+RIGHT('000'+ CAST ((CONVERT (int, RIGHT( @maxpurchaseID,4)) +1) as varchar(4)),4)

return @purchaseID;
end



--创建自动生成订单编号的存储过程
create proc bill_CreatePurchaseID
@PurchaseDate datetime
as
select dbo.CreatePurchaseID(@PurchaseDate)as purchaseID