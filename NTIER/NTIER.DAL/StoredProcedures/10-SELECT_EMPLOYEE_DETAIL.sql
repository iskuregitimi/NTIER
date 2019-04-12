
ALTER PROC [dbo].[SELECT_EMPLOYEE_DETAIL]
    @BusinessEntityID int
AS
BEGIN
--DETAY
SELECT P.FirstName,P.MiddleName,P.LastName,E.JobTitle,E.HireDate,E.BirthDate 
		FROM [Person].[Person] P
		INNER JOIN [HumanResources].[Employee] E ON E.BusinessEntityID=P.BusinessEntityID
WHERE E.BusinessEntityID=@BusinessEntityID



--PHONE
SELECT PP.BusinessEntityID,PP.PhoneNumber
		FROM [Person].[PersonPhone] PP 
WHERE PP.BusinessEntityID=@BusinessEntityID
--EMAİLADRES
SELECT *
		FROM [Person].[EmailAddress] PEA
WHERE PEA.BusinessEntityID=@BusinessEntityID
END


