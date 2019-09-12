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
Go
Create Table Inscripcion(
	IDInscripcion int primary key identity,
	Fecha date,
	IDEstudiante int,
	Comentario varchar(60),
	Monto decimal,
	Deposito decimal,
	Balance decimal
);
