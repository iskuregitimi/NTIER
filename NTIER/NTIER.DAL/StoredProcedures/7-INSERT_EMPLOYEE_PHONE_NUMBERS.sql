ALTER
PROC INSERT_EMPLOYEE_PHONE_NUMBERS
    @BusinessEntityID int,
    @PhoneNumber nvarchar(50),
	@PhoneNumberTypeID INT=1
AS 
BEGIN
	
	INSERT INTO [Person].[PhoneNumber] ([BusinessEntityID], [PhoneNumber],[PhoneNumberTypeID])
	SELECT @BusinessEntityID, @PhoneNumber,@PhoneNumberTypeID
               
END