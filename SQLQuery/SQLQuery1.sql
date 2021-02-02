ALTER PROC UserAdd
@username varchar(50),
@password varchar(50),
@email varchar(50)
AS
	INSERT INTO SignUpTable(username, password, email)
	VALUES (@username, @password, @email)
