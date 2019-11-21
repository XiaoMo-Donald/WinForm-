

--产品选择模糊查询
create proc SelectProductBySpellingCode
@spellingCode nvarchar(40)
as
select * from TBL_Product where SpellingCode like '%'+ @spellingCode + '%'

