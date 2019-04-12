
ALTER PROC [dbo].[SELECT_EMPLOYEE_DETAIL]
    @BusinessEntityID int
AS
BEGIN
--DETAY
SELECT P.FirstName,P.MiddleName,P.LastName,E.JobTitle,E.HireDate,E.BirthDate 
		FROM [Person].[Person] P
		INNER JOIN [HumanResources].[Employee] E ON E.BusinessEntityID=P.BusinessEntityID
WHERE E.BusinessEntityID=@BusinessEntityID
--ADRES
SELECT PA.AddressID,PA.AddressLine1,PA.City,PA.PostalCode 
		FROM [Person].[Address] PA 
		INNER JOIN [Person].[BusinessEntityAddress] BA ON BA.AddressID=PA.AddressID

WHERE BA.BusinessEntityID=@BusinessEntityID
--PHONE
SELECT PP.BusinessEntityID,PP.PhoneNumber
		FROM [Person].[PersonPhone] PP 
WHERE PP.BusinessEntityID=@BusinessEntityID
--EMAİLADRES
SELECT *
		FROM [Person].[EmailAddress] PEA
WHERE PEA.BusinessEntityID=@BusinessEntityID
END


