create proc UsersValidate
	@username varchar(40), @password varchar(400)
	as begin
		
		set @Password = CONVERT(
		VARCHAR(MAX),
		hashbytes('SHA2_512',@password),2)

		select * from UsersLog where Username = @username 
		and Passwords = @password
	end