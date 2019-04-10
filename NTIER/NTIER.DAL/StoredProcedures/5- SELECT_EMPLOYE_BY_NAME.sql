CREATE PROC [dbo].[SELECT_EMPLOYEE_BY_NAME]
	@SearchText VARCHAR(50)=''
AS
BEGIN
	SELECT	p.BusinessEntityID,p.FirstName,p.MiddleName,p.LastName,e.JobTitle,e.BirthDate 
	FROM	[HumanResources].[Employee] e
			INNER JOIN [Person].[Person] p ON (e.BusinessEntityID=p.BusinessEntityID)
	WHERE	(p.FirstName+' '+p.MiddleName+' '+p.LastName+ ' ' + e.JobTitle  ) LIKE '%'+@SearchText+'%'
END