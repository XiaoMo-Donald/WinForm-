
--1.插入新记录
CREATE PROC empl_InsertEmployee
@EmployeeID nvarchar(6),
@EmployeeName nvarchar(80),
@sex bit,
@Birthday datetime,
@Brief nvarchar(max)
as
insert TBL_Employee values(@EmployeeID,@EmployeeName,@sex,@Birthday,@Brief)
return 


exec empl_InsertEmployee '4','莫1',0,'2015-05-20','10'



--2.删除记录
create proc empl_DeleteEmployeeByEmployeeID
@EmployeeID nvarchar(6)
as
delete TBL_Employee where EmployeeID=@EmployeeID
return 


exec empl_DeleteEmployeeByEmployeeID '1'


--3.更新记录
create proc empl_UpdateEmployeeByEmployeeID
@EmployeeID nvarchar(6),
@EmployeeName nvarchar(80),
@sex bit,
@Birthday datetime,
@Brief nvarchar(max)
as
update TBL_Employee
set EmployeeName=@EmployeeName,Sex=@sex,Birthday=@Birthday,Brief=@Brief
where EmployeeID=@EmployeeID
return


exec empl_UpdateEmployeeByEmployeeID '4','莫666',0,'2016-05-20','100'



--4.查询所有记录
create proc empl_GetAllEmployee
as
select * from TBL_Employee
return 


exec empl_GetAllEmployee


--5.根据EmployeeID查询记录
create proc empl_GetAllEmployeeByEmployeeID
@EmployeeID nvarchar(6)
as
select * from TBL_Employee where EmployeeID=@EmployeeID
return 

exec empl_GetAllEmployeeByEmployeeID '1'