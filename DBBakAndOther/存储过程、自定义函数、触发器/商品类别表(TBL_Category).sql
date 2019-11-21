
use EntersSellsSaves

--1.插入新记录
create proc cate_InsertCategory
@categoryID nvarchar(6),
@categoryName nvarchar(80)
as
insert TBL_Category values (@categoryID,@categoryName)
return

exec cate_InsertCategory'5','西瓜'


--2.删除记录
create proc cate_DeleteCategoryByCategoryID
@categoryID nvarchar(6)
as
delete TBL_Category where CategoryID=@categoryID
return

exec cate_DeleteCategoryByCategoryID '4'


--3.更新记录
create proc cate_UpdataCategoryByCategoryID
@categoryID nvarchar(6),
@categoryName nvarchar(80)
as
update TBL_Category
set CategoryName=@categoryName
where CategoryID=@categoryID
return

exec cate_UpdataCategoryByCategoryID '5','哈密瓜'


--4.查询所有记录
create proc cate_GetAllCategory
as
select * from TBL_Category
return

exec cate_GetAllCategory


--5.根据CategoryID查询记录
create proc cate_GetAllCategoryByCategoryID
@categoryID nvarchar(6)
as
select * from TBL_Category where CategoryID=@categoryID
return

exec cate_GetAllCategoryByCategoryID '3'