
Alter PROC [HumanResources].[usp_EmployeeInsert] 
    @BusinessEntityID int,
    @NationalIDNumber nvarchar(15),
    @LoginID nvarchar(256),
    @OrganizationNode hierarchyid = NULL,
    @JobTitle nvarchar(50),
    @BirthDate date,
    @MaritalStatus nchar(1),
    @Gender nchar(1),
    @HireDate date,
    @SalariedFlag Flag,
    @VacationHours smallint,
    @SickLeaveHours smallint,
    @CurrentFlag Flag
AS 
BEGIN
	
	INSERT INTO [HumanResources].[Employee] ([BusinessEntityID], [NationalIDNumber], [LoginID], [OrganizationNode], [JobTitle], [BirthDate], [MaritalStatus], [Gender], [HireDate], [SalariedFlag], [VacationHours], [SickLeaveHours], [CurrentFlag])
	SELECT @BusinessEntityID, @NationalIDNumber, @LoginID, @OrganizationNode, @JobTitle, @BirthDate, @MaritalStatus, @Gender, @HireDate, @SalariedFlag, @VacationHours, @SickLeaveHours, @CurrentFlag
	
	-- Begin Return Select <- do not remove
	SELECT [BusinessEntityID], [NationalIDNumber], [LoginID], [OrganizationNode], [OrganizationLevel], [JobTitle], [BirthDate], [MaritalStatus], [Gender], [HireDate], [SalariedFlag], [VacationHours], [SickLeaveHours], [CurrentFlag], [rowguid], [ModifiedDate]
	FROM   [HumanResources].[Employee]
	WHERE  [BusinessEntityID] = @BusinessEntityID
	-- End Return Select <- do not remove
END