CREATE PROCEDURE prodemo
  @site_name VARCHAR(50) OUT

AS

BEGIN

   DECLARE @site_id INT;

   SET @site_id = 8;

   IF @site_id < 10
      SET @site_name = 'TechOnTheNet.com';
   ELSE
      SET @site_name = 'CheckYourMath.com';

END;
------------------------------------------
create procedure helloproc
As
Begin
Print 'Hello'
End
Go

exec helloproc
------------------------------------------

create procedure variableproc
As
Begin
declare @Name varchar(max),@Name2 varchar(max)
set @Name = 'Jack'
set @Name2 = 'Rack' 
Print @Name
print @Name2
End;
Go

drop procedure variableproc

exec variableproc

create procedure interviewq
As
Begin
declare @Name char(4)
set @Name = 'Jackies'
Print @Name
End;
Go

exec interviewq

drop procedure returncheck

create procedure returncheck
As
Begin
declare @Name char(4)
declare @Nam int
set @Nam = 1
set @Name = 'Jackies'
print @Name
return @Nam
End;
Go

exec returncheck
