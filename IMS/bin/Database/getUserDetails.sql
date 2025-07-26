ALTER PROCEDURE st_getUserDetails
    @user VARCHAR(30),
    @pass NVARCHAR(30)
AS
BEGIN
    SELECT 
        u.usr_id AS 'ID',
        u.usr_name AS 'Name',
        u.usr_username AS 'Username',
        u.usr_password AS 'Password'
    FROM users u
    WHERE
        u.usr_username = @user  
        AND u.usr_password = @pass;
END

--EXEC st_getUserDetails @user = ' sobi28', @pass = '123';

