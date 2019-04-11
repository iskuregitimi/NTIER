ALter Proc INSERT_PHONE
			@BusinessEntityID	INT,
			@PhoneNumber		VARCHAR(11),
			@PhoneNumberType	INT = 1
AS
BEGIN

Insert into [Person].[PersonPhone](BusinessEntityID,PhoneNumber,PhoneNumberTypeID) values(@BusinessEntityID,@PhoneNumber,@PhoneNumberType)

END