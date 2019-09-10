Create DataBase EstudianteDb
GO
Use EstudianteDb
Go 
Create Table Estudiante(
	Id int primary key identity,
	Matricula varchar(10),
	Nombres varchar(35),
	Apellidos varchar(35),
	Cedula varchar(13),
	Telefono varchar(12),
	Celular varchar(12),
	Email varchar(40),
	FechaNacimiento date,
	Sexo int,
	Balance decimal
);

