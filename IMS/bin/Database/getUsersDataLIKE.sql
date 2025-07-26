create procedure st_getUsersDataLIKE
@data varchar(50)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status'
from users u
where 
u.usr_name like '%'+ @data + '%'
or
u.usr_username like '%'+ @data + '%'
or
u.usr_phone like '%'+ @data + '%'
or
u.usr_email like '%'+ @data + '%'

order by u.usr_name asc
