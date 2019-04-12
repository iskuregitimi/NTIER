alter PROC INSERT_BUSINESS_ENTITY
AS
BEGIN
	INSERT INTO [Person].[BusinessEntity](ModifiedDate) VALUES(GETDATE())

	SELECT * FROM [Person].[BusinessEntity] WHERE BusinessEntityID=SCOPE_IDENTITY()
END
