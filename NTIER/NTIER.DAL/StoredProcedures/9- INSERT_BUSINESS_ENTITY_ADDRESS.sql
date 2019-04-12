ALTER PROC [INSERT_BUSINESS_ENTITY_ADDRESS] 
    @BusinessEntityID int,
    @AddressID int,
    @AddressTypeID int=2
AS 
BEGIN	
	INSERT INTO [Person].[BusinessEntityAddress] ([BusinessEntityID], [AddressID], [AddressTypeID])
	SELECT @BusinessEntityID, @AddressID, @AddressTypeID	
END