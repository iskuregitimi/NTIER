
CREATE Proc SELECT_EMPLOYEE_DETAILS
@BusinessEntityID INT

AS
BEGIN
	SELECT pp.BusinessEntityID,pp.FirstName,pp.LastName,he.JobTitle,he.BirthDate,he.HireDate
	FROM Person.Person pp
	INNER JOIN HumanResources.Employee he
	ON pp.BusinessEntityID=he.BusinessEntityID
	WHERE @BusinessEntityID=pp.BusinessEntityID
	
	SELECT pb.BusinessEntityID,pa.AddressID,pa.AddressLine1,pa.City,pa.PostalCode
	FROM Person.Address pa
	Inner Join Person.BusinessEntityAddress pb
	ON pa.AddressID = pb.AddressID
	WHERE @BusinessEntityID=pb.BusinessEntityID


	SELECT BusinessEntityID,PhoneNumber 
	FROM Person.PersonPhone pp
	WHERE @BusinessEntityID=pp.BusinessEntityID

	SELECT BusinessEntityID,EmailAddress 
	FROM Person.EmailAddress
	WHERE @BusinessEntityID=BusinessEntityID

END