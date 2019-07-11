/*Database*/
Create database Project
/*Database*/


/*Table Login*/
create table Loggin
(
Name varchar (50),
pasword varchar(50)
);
insert into Loggin values ('Noman','aptech')
/*Table Login*/

 /*book add table or procedure*/
 drop proc bokad
 create table bookadd
 (
 List int primary key identity,
 Book_Name varchar(50),
 category varchar(50),
 ISBN varchar(50),
 Title varchar(50),
 Auther varchar(50)
 );
 select * from bookadd
 create proc bokad
 @Book_Name varchar(50),
 @category varchar(50),
 @IBSN varchar(50),
 @Title varchar(50),
 @Auther varchar(50)
 as
 begin
 insert into bookadd values(@Book_Name,@category,@IBSN,@Title,@Auther)
 end
create proc bookshow
as
begin
select * from bookadd
end
  /*book add table or procedure*/

/*Member add table or procedure*/
drop table Member_add
create table Member_add
(
Member_Id int primary key identity,
Name varchar(50),
F_Name varchar(50),
Cnic varchar(50),
Phone varchar(50),
Adress varchar(50),
Gender varchar(50)
);
 create proc ad_member
 @Name varchar (50),
 @F_Name varchar(50),
 @Cnic varchar(50),
 @Phone varchar(50),
 @Adress varchar(50),
 @Gender varchar(50)
 as
 begin
 insert into Member_add values(@Name,@F_Name,@Cnic,@Phone,@Adress,@Gender)
 end
 /*Member add table or procedure*/


create proc select_member
as
begin
select * from Member_add
end
create table issubook
(
Book_Name varchar(50),
Member_Name varchar(50),
Issuedate varchar(50),
Ruturn_Date varchar(50),
Return_Days varchar(50) 
);
drop table issubook
create proc isubook
@Book_Name varchar(50),
@Member_Name varchar(50),
@Issuedate varchar(50),
@Ruturn_Date varchar(50),
@Return_Days varchar(50)
as 
begin
insert into issubook values (@Book_Name,@Member_Name,@Issuedate,@Ruturn_Date,@Return_Days);
end
create proc isubookdetail
as
begin
select * from issubook
end

drop proc isubookdetail 
drop proc isubook
select * from issubook
select * from tbl_category	
truncate table issubook
create proc deleteBok
@id int 
as
begin
delete from bookadd where @id=List  
end