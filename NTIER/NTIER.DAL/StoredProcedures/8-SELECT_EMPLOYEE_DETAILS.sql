CREATE PROC SELECT_EMPLOYEE_DETAILS
	@BusinessEntityID INT

AS
BEGIN

	select pp.BusinessEntityID,pp.FirstName,pp.MiddleName,pp.LastName,he.JobTitle,he.HireDate,he.BirthDate from Person.Person pp, HumanResources.Employee he where pp.BusinessEntityID=he.BusinessEntityID and pp.BusinessEntityID=@BusinessEntityID

	select * from Person.Address pa, Person.BusinessEntityAddress pbe where pbe.AddressID=pa.AddressID and pbe.BusinessEntityID=@BusinessEntityID

	select * from [Person].[PersonPhone] pp,[Person].[PhoneNumberType] ppt where pp.PhoneNumberTypeID=ppt.PhoneNumberTypeID and pp.BusinessEntityID=@BusinessEntityID

	select * from [Person].[EmailAddress] where BusinessEntityID=@BusinessEntityID

END
