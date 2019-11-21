
--按单据编号查询
alter proc purc_FindPurchaseIDByID
@PurchaseID nvarchar(12)
as
select PurchaseID from TBL_PurchaseBill where PurchaseID like '%'+@PurchaseID+'%'

exec purc_FindPurchaseIDByID '1'

--按业务员查询
alter proc purc_FindPurchaseIDByClerk
@EmployeeName nvarchar(80) 
as
select PurchaseID from TBL_PurchaseBill as pb,TBL_Employee as el where pb.Examiner=el.EmployeeID and EmployeeName like '%'+@EmployeeName+'%'

exec purc_FindPurchaseIDByClerk '莫'

--按审核员查询
alter proc purc_FindPurchaseIDByExaminer
@EmployeeName nvarchar(80)
as
select PurchaseID from TBL_PurchaseBill as pb,TBL_Employee as el where pb.Clerk=el.EmployeeID and EmployeeName like '%'+@EmployeeName+'%'

exec purc_FindPurchaseIDByExaminer '莫'

--按完成状态查询
alter proc purc_FindPurchaseIDByOnProcess
@OnProcess smallint
as
select PurchaseID from TBL_PurchaseBill where  OnProcess=@OnProcess

exec purc_FindPurchaseIDByOnProcess 1

--按订单日期查询
alter proc purc_FindPurchaseIDByPurchaseDate
@BeginPurchaseDate datetime,
@EndPurchaseDate datetime
as
select PurchaseID from TBL_PurchaseBill where PurchaseDate>=@BeginPurchaseDate and PurchaseDate<=@EndPurchaseDate

exec purc_FindPurchaseIDByPurchaseDate '2015-05-01','2017-01-01'
