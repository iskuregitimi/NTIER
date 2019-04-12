ALTER PROC DELETE_ADRESS
   @AddressID  int
AS
BEGIN
DELETE FROM [Person].[BusinessEntityAddress]
WHERE AddressID= @AddressID

DELETE FROM  [Person].[Address] 
WHERE AddressID= @AddressID
END


EXEC DELETE_ADRESS 4