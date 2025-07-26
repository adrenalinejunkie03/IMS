create procedure st_getSuppliersDataLike
@data varchar(50)
as
select
s.sup_id as 'ID',
s.sup_company as 'Company',
s.sup_contactPerson as 'Contact Person',
s.sup_phone1 as 'Phone 1',
s.sup_phone2 as 'Phone 2',
s.sup_ntn as 'NTN #',
s.sup_address as 'Address',
case when (s.sup_status = 1) then 'Active' else 'In-active' end as 'Status'
from supplier s
where
s.sup_company like '%'+ @data + '%'
or
s.sup_contactPerson like '%'+ @data + '%'
or
s.sup_phone1 like '%'+ @data + '%'
or
s.sup_phone2 like '%'+ @data + '%'
or
s.sup_ntn like '%'+ @data + '%'
or
s.sup_address like '%'+ @data + '%'

order by s.sup_company asc
