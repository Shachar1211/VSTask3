ALTER PROCEDURE [dbo].[spLogInUser]
    @email NVARCHAR(25),
    @password NVARCHAR(25)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM UsersTable WHERE email = @email AND [password] = @password)
    BEGIN
        SELECT 'Login successful' AS Status;
    END
    ELSE
    BEGIN
        SELECT 'Login failed' AS Status;
    END
END
