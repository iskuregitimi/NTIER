ALTER PROC SELECT_EMPLOYEE_DETAILS
	@BusinessEntityID INT

-- SELECT_EMPLOYEE_DETAILS 1
AS
BEGIN
--TELEFON BİLGİLERİ
    SELECT TOP 1 FirstName AS 'ADI',MiddleName AS 'Ortanca Adı',LastName AS 'Soyadı',pp.PhoneNumber AS 'Telefon Numarası',pnt.Name AS 'Çağrı Tipi' FROM Person.Person p
	INNER JOIN Person.PersonPhone pp ON pp.BusinessEntityID = p.BusinessEntityID
	INNER JOIN Person.PhoneNumberType pnt ON pnt.PhoneNumberTypeID=pp.PhoneNumberTypeID
	WHERE p.BusinessEntityID=@BusinessEntityID

--ADRES Detayları
    SELECT TOP 1 FirstName AS 'ADI',MiddleName AS 'Ortanca Adı',LastName AS 'Soyadı',pa.AddressLine1 AS 'ADRES',pa.AddressLine2 AS 'ADRES 2',pa.City AS 'ŞEHİR',pa.PostalCode AS 'POSTA KODU' 
	FROM Person.Person p
	INNER JOIN [Person].[BusinessEntityAddress] pea ON pea.BusinessEntityID = p.BusinessEntityID
	INNER JOIN Person.Address pa ON pa.AddressID = pea.AddressID
	WHERE p.BusinessEntityID=@BusinessEntityID

--Kişi Detayları
	SELECT TOP 1 FirstName AS 'Adı',MiddleName AS 'Ortanca Adı',LastName AS 'Soyadı',hre.JobTitle As 'İş Tanımı',hre.HireDate AS 'İşe Giriş Tarihi',hre.BirthDate AS 'Doğum Tarihi',hre.Gender AS 'Cinsiyet',hre.VacationHours as 'Dinlendiği Süre',hre.SickLeaveHours AS 'Hasta Kaldığı Süre'
	FROM Person.Person p 
	INNER JOIN HumanResources.Employee hre ON p.BusinessEntityID = hre.BusinessEntityID
	WHERE p.BusinessEntityID = @BusinessEntityID

--Mail Bilgileri
	SELECT TOP 1 FirstName AS 'Adı',MiddleName AS 'Ortanca Adı',LastName AS 'Soyadı',pea.EmailAddress AS 'Email Adresi'
	FROM Person.Person p 
	INNER JOIN Person.EmailAddress pea ON pea.BusinessEntityID = p.BusinessEntityID
	WHERE p.BusinessEntityID=@BusinessEntityID

END

EXEC SELECT_EMPLOYEE_DETAILS 1