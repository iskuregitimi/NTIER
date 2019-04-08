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