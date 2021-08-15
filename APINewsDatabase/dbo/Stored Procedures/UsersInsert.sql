CREATE proc UsersInsert
@displayName Varchar(250),
@UserName Varchar(40),
@Password Varchar(400)
as begin
	set @Password = CONVERT(VARCHAR(MAX),hashbytes('SHA2_512',@password),2)

	insert UsersLog(DisplayName,Username,Passwords)
		values(@displayName,@UserName,@Password)
end