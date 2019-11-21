
--更新订单入库产品的数量 、价格、销售价格
create trigger purchaseBill_Update on TBL_PurchaseBill
after update
as
if update(OnProcess)
begin
declare @oldOnProcess smallint,@newOnProcess smallint,@purchaseID nchar(12)

select @oldOnProcess=OnProcess from deleted
select @newOnProcess=OnProcess,@purchaseID=PurchaseID from inserted 

if(@oldOnProcess=0 and @newOnProcess=2)
	begin 
	update p
	set p.PurchasePrice=(p.PurchasePrice*p.Quantity+d.PurchasePrice*d.Quantity)/(p.Quantity+d.Quantity),
	p.SalePrice=p.SalePrice*1.1,
	p.Quantity=p.Quantity+d.Quantity
	from TBL_Product as p join (select * from TBL_PurchaseDetail where PurchaseID=@purchaseID) as d on p.ProductID=d.ProductID
	end 
end






 --用户权限管理

--1.新添加一个员工的时候添加一个系统的用户（插入触发）
create trigger Employee_insert on TBL_Employee
after insert
as 
begin
declare @UserID nvarchar(6)
select @UserID=EmployeeID from inserted

insert  TBL_SystemUser values(@UserID,'111',0,0,0,1)
end

 
--2.删除一个员工的时候删除一个系统的用户（删除触发）
create trigger Employee_delete on TBL_Employee
after delete
as
begin
declare @UserID nvarchar(6)
select @UserID=EmployeeID from  deleted

delete  TBL_SystemUser  where UserID=@UserID
end