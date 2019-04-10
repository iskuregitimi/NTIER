ALTER PROC INSERT_EMPLOYEE_PHONE
    @BusinessEntityID INT,
    @PhoneNumber VARCHAR(50)
AS 
BEGIN

	
	INSERT INTO [Person].[PersonPhone] ([BusinessEntityID], [PhoneNumber],PhoneNumberTypeID)
	SELECT @BusinessEntityID, @PhoneNumber,1
               
END
