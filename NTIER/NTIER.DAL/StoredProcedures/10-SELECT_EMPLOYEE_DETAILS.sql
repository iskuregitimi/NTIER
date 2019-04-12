
Create PROC [dbo].[SELECT_EMPLOYEE_DETAIL]
    @BusinessEntityID int
AS
BEGIN
--DETAY
SELECT P.FirstName,P.MiddleName,P.LastName,E.JobTitle,E.HireDate,E.BirthDate 
		FROM [Person].[Person] P
		INNER JOIN [HumanResources].[Employee] E ON E.BusinessEntityID=P.BusinessEntityID
WHERE E.BusinessEntityID=@BusinessEntityID
--ADRES
SELECT P.BusinessEntityID,PA.AddressID,PA.AddressLine1,PA.City,PA.PostalCode 
		FROM [Person].[Address] PA 
		INNER JOIN [Person].[BusinessEntityAddress] BA ON BA.AddressID=PA.AddressID
		INNER JOIN [Person].[Person] P ON P.BusinessEntityID=BA.BusinessEntityID
WHERE BA.BusinessEntityID=@BusinessEntityID
--PHONE
SELECT P.BusinessEntityID,PP.PhoneNumber,PT.[Name] 
		FROM [Person].[PersonPhone] PP 
		INNER JOIN [Person].[Person] P  ON P.BusinessEntityID=PP.BusinessEntityID
		INNER JOIN [Person].[PhoneNumberType] PT ON PT.PhoneNumberTypeID=PP.PhoneNumberTypeID
WHERE PP.BusinessEntityID=@BusinessEntityID
--EMAİLADRES
SELECT P.BusinessEntityID,PEA.EmailAddress 
		FROM [Person].[EmailAddress] PEA
		INNER JOIN [Person].[Person] P ON P.BusinessEntityID=PEA.BusinessEntityID
WHERE PEA.BusinessEntityID=@BusinessEntityID
END


EXEC SELECT_EMPLOYEE_DETAILS 5