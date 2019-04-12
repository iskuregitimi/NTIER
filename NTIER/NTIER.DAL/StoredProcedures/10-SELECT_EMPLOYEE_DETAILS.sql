ALTER PROC SELECT_EMPLOYEE_DETAILS
	@BusinessEntityID INT

AS
BEGIN
	SELECT he.BusinessEntityID,he.JobTitle,he.HireDate,pp.FirstName,pp.LastName,he.BirthDate FROM HumanResources.Employee he
		INNER JOIN Person.Person pp ON he.BusinessEntityID=pp.BusinessEntityID
	WHERE HE.BusinessEntityID=@BusinessEntityID

	SELECT pa.AddressID,pa.AddressLine1,pa.AddressLine2 FROM Person.Address pa
		INNER JOIN Person.BusinessEntityAddress pba ON pa.AddressID=pba.AddressID
	WHERE pba.BusinessEntityID=@BusinessEntityID

	SELECT * FROM Person.PersonPhone ppp
	WHERE ppp.BusinessEntityID=@BusinessEntityID

	SELECT * FROM Person.EmailAddress pea
	WHERE pea.BusinessEntityID=@BusinessEntityID
END

