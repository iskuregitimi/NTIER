ALTER PROC SELEC_PERSON_BY_NAME
	@FirstName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@LastName VARCHAR(50)
AS
BEGIN

	SELECT *
	FROM [Person].[Person]
	WHERE FirstName=@FirstName 
			AND MiddleName=@MiddleName 
			AND LastName=@LastName

END