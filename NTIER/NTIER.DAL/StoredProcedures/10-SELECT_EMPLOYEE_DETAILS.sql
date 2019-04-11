alter proc SELECT_EMPLOYEE_DETAILS
@BussinessEntityID int 

as
begin 
select e.JobTitle, e.HireDate,p.FirstName,p.LastName,e.BirthDate from [Person].[Person] p
 join [HumanResources].[Employee]  e on  p.BusinessEntityID=e.BusinessEntityID
where p.BusinessEntityID=@BussinessEntityID

select * from [Person].[PersonPhone] where BusinessEntityID=@BussinessEntityID

select bea.AddressID,a.AddressLine1,a.AddressLine2 from [Person].[BusinessEntityAddress] bea join [Person].[Address] a on a.AddressID=bea.AddressID
where bea.BusinessEntityID=@BussinessEntityID

select * from [Person].[EmailAddress] where BusinessEntityID=@BussinessEntityID
end 
