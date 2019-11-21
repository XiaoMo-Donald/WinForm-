
--1.查询所有的记录
create proc user_GelAllSystemUser
as
select * from TBL_SystemUser where UserID<>'admin'
return


exec user_GelAllSystemUser 



--2.根据UserID查询记录
create proc user_GelAllSystemUserByUserID
@userID nvarchar(6)
as
select * from TBL_SystemUser where UserID=@userID
return


exec user_GelAllSystemUserByUserID '2'


--3.新增记录
create proc user_InsertSystemUser
@userID nvarchar(6),
@password binary(50),
@baseFunction int,
@purchaseFunction int,
@saleFunction int,
@userFunction int
as
insert TBL_SystemUser values(@userID,@password,@baseFunction,@purchaseFunction,@saleFunction,@userFunction)
return


exec  user_InsertSystemUser '5','666666',0,0,0,1


--4.删除记录
create proc user_DeleteSystemUser
@userID nvarchar(6)
as
delete TBL_SystemUser where UserID=@userID
return


exec user_DeleteSystemUser '5'


--5.更新记录
create proc user_UpdateSystemUser
@userID nvarchar(6),
@password binary(50),
@baseFunction int,
@purchaseFunction int,
@saleFunction int,
@userFunction int
as
update TBL_SystemUser 
set Password= @password,BaseFunction= @baseFunction,PurchaseFunction= @purchaseFunction,SaleFunction= @saleFunction,UserFunction= @userFunction
where UserID=@userID
return

exec user_UpdateSystemUser '5','123456',0,0,0,1


--6.用户登录
create proc user_UserLogin
@userID nvarchar(6),
@password binary(50)
as
select COUNT(*) from TBL_SystemUser where UserID=@userID and Password=@password


exec  user_UserLogin '4','666666'

--7.修改登录密码
CREATE proc user_ChangeUserPassword
@userID nchar(6),
@password binary(50)
as
update TBL_SystemUser set password=@password where UserID=@userID


exec user_ChangeUserPassword '4','666666'