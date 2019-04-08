ALTER PROC INSERT_PERSON
    @BusinessEntityID int,
    @Title nvarchar(8) = NULL,
    @FirstName nvarchar(50),
    @MiddleName nvarchar(50) = NULL,
    @LastName nvarchar(50)
AS 
BEGIN
	INSERT INTO [Person].[Person] ([BusinessEntityID], [PersonType], [Title], [FirstName], [MiddleName], [LastName], [Suffix], [EmailPromotion], [ModifiedDate])
	VALUES (@BusinessEntityID, 'EM', @Title, @FirstName, @MiddleName, @LastName, NULL, 2, GETDATE())
	
END







CREATE PROC [Person].[usp_PersonInsert] 
    @BusinessEntityID int,
    @PersonType nchar(2),
    @NameStyle NameStyle,
    @Title nvarchar(8) = NULL,
    @FirstName Name,
    @MiddleName Name = NULL,
    @LastName Name,
    @Suffix nvarchar(10) = NULL,
    @EmailPromotion int,
    @AdditionalContactInfo xml = NULL,
    @Demographics xml = NULL,
    @rowguid uniqueidentifier,
    @ModifiedDate datetime
AS 
BEGIN
	INSERT INTO [Person].[Person] ([BusinessEntityID], [PersonType], [NameStyle], [Title], [FirstName], [MiddleName], [LastName], [Suffix], [EmailPromotion], [AdditionalContactInfo], [Demographics], [rowguid], [ModifiedDate])
	SELECT @BusinessEntityID, @PersonType, @NameStyle, @Title, @FirstName, @MiddleName, @LastName, @Suffix, @EmailPromotion, @AdditionalContactInfo, @Demographics, @rowguid, @ModifiedDate
	
	-- Begin Return Select <- do not remove
	SELECT [BusinessEntityID], [PersonType], [NameStyle], [Title], [FirstName], [MiddleName], [LastName], [Suffix], [EmailPromotion], [AdditionalContactInfo], [Demographics], [rowguid], [ModifiedDate]
	FROM   [Person].[Person]
	WHERE  [BusinessEntityID] = @BusinessEntityID

END