create procedure st_getCategoriesDataLIKE
@data varchar(50)
as
select
c.cat_id as 'ID',
c.cat_name as 'Category',
case when (c.cat_isActive = 1) then 'Yes' else 'No' end as 'Status'
from categories c
where 
c.cat_name like '%'+ @data + '%'
or
c.cat_isActive like '%'+ @data + '%'
order by c.cat_name asc