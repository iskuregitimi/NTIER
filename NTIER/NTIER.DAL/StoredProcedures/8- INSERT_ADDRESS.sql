CREATE PROC[INSERT_ADDRESS]
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60) = NULL,
    @City nvarchar(30),
    @StateProvinceID int,
    @PostalCode nvarchar(15)
AS
BEGIN


   INSERT INTO[Person].[Address]
	([AddressLine1], [AddressLine2], [City], [StateProvinceID], [PostalCode])
   SELECT @AddressLine1, @AddressLine2, @City, @StateProvinceID, @PostalCode

   SELECT CAST(SCOPE_IDENTITY() AS INT)


END