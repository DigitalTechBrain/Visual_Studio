CREATE database Tutorial

create table tbl2
(Sno int,SName varchar(max),Saddress char(4))

insert into tbl2
values(2,'zack','vill')

select * from tbl where Sno = 1 and SName ='Jack'

select * from tbl 
union
(Select * from tbl2)