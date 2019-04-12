alter PROC INSERT_EMPLOYEE_EMAIL
    @BusinessEntityID int,
    @EmailAddress nvarchar(50)
AS 
BEGIN
	
	INSERT INTO [Person].[EmailAddress] ([BusinessEntityID], [EmailAddress])
	SELECT @BusinessEntityID, @EmailAddress
               
END
