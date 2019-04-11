ALTER PROC SELECT_EMPLOYEE_DETAILS
@BusinessEntityID INT
AS
BEGIN

SELECT pp.FirstName, pp.MiddleName, pp.LastName, he.JobTitle, he.BirthDate, he.HireDate FROM Person.Person pp 
INNER JOIN HumanResources.Employee he ON pp.BusinessEntityID=he.BusinessEntityID 
WHERE @BusinessEntityID=pp.BusinessEntityID

SELECT pa.AddressID, pa.AddressLine1, pa.City, pa.PostalCode FROM Person.Address pa
INNER JOIN Person.BusinessEntityAddress pba ON pa.AddressID=pba.AddressID
WHERE @BusinessEntityID=pba.BusinessEntityID

SELECT pp.PhoneNumber FROM Person.PersonPhone pp
WHERE @BusinessEntityID=pp.BusinessEntityID

SELECT pe.EmailAddress FROM Person.EmailAddress pe
WHERE @BusinessEntityID=pe.BusinessEntityID
END
