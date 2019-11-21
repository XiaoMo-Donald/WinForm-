--1.插入新记录
CREATE PROC supp_InsertSupplier
@SupplierID nvarchar(6),
@SupplierName nvarchar(80),
@SpellingCode nvarchar(20),
@Address nvarchar(80),
@ZipCode char(6),
@Tel nvarchar(20),
@Fax nvarchar(20),
@BankName nvarchar(40),
@BankAccount nvarchar(50),
@Contacter nvarchar(20),
@Email nvarchar(30)
as
insert TBL_Supplier values(@SupplierID,@SupplierName,@SpellingCode,@Address,@ZipCode,@Tel,@Fax,@BankName,@BankAccount,@Contacter,@Email)
return


exec supp_InsertSupplier '2','供应商','供应商的Code','供应商地址','邮编','电话','不知道','工商银行','4564654654654564654','这个不知道','123456@qq.com'


--2.删除记录
create proc supp_DeleteSupplierBySupplierID
@SupplierID nvarchar(6)
as
delete TBL_Supplier where SupplierID=@SupplierID
return

exec supp_DeleteSupplierBySupplierID '1'



--3.更新记录
create proc supp_UpdateSupplierBySupplierID
@SupplierID nvarchar(6),
@SupplierName nvarchar(80),
@SpellingCode nvarchar(20),
@Address nvarchar(80),
@ZipCode char(6),
@Tel nvarchar(20),
@Fax nvarchar(20),
@BankName nvarchar(40),
@BankAccount nvarchar(50),
@Contacter nvarchar(20),
@Email nvarchar(30)
as
update TBL_Supplier
set SupplierName=@SupplierName,SpellingCode=@SpellingCode,Address=@Address,ZipCode=@ZipCode,Tel=@Tel,Fax=@Fax,BankName=@BankName,BankAccount=@BankAccount,@Contacter=@Contacter,Email=@Email
where SupplierID=@SupplierID
return

exec supp_UpdateSupplierBySupplierID '1','供应商2','供应商的Code2','供应商地址2','邮编2','电话2','不知道2','工商银行2','45646546546545646542','这个不知道2','2123456@qq.com'



--4.查询所有记录
create proc supp_GetAllSupplier
as
select * from TBL_Supplier
return

exec supp_GetAllSupplier


--5.根据SupplierID查询记录
create proc supp_GetAllSupplierBySupplierID
@SupplierID nvarchar(6)
as
select * from TBL_Supplier where SupplierID=@SupplierID
return

exec supp_GetAllSupplierBySupplierID '1'