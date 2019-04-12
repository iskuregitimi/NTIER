ALTER PROC [SELECT_STATEPROVINCES] 
    @searchText VARCHAR(50)=''
AS 
BEGIN
	SELECT [StateProvinceID], [StateProvinceCode], [CountryRegionCode], [IsOnlyStateProvinceFlag], [Name], [TerritoryID], [rowguid], [ModifiedDate] 
	FROM   [Person].[StateProvince] 
	WHERE  [Name] LIKE '%'+@searchText+'%'
END
