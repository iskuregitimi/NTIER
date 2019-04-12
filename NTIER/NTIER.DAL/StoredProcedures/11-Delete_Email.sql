create PROC  Delete_Email
@EmailAdressID int
as

begin 

--select * from [Person].[EmailAddress]
delete EmailAddress from [Person].[EmailAddress] where EmailAddressID=@EmailAdressID

end