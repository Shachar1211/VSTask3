CREATE PROCEDURE [dbo].[spLogInUser]
    @email varchar(25),
    @password NVARCHAR(25)
AS
    BEGIN 
        SELECT * From UsersTable 
        WHERE 
        email=@email AND [password]=@password
END