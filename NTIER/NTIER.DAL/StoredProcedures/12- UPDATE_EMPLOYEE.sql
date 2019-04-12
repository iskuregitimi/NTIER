CREATE PROC [dbo].[UPDATE_EMPLOYEE]
    @BusinessEntityID int,
    @JobTitle nvarchar(50),
    @HireDate date
AS 
BEGIN
	UPDATE	[HumanResources].[Employee]
	SET		[JobTitle] = @JobTitle, 
			[HireDate] = @HireDate
	WHERE  [BusinessEntityID] = @BusinessEntityID
END