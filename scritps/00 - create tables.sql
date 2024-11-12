go

drop table reserva

create table reserva
(
	reservaid int identity(1,1) primary key,
	usuarioid int,
	estacionamientoid int,
	placa nvarchar(50),
	fecha datetime,
	tipo int,
	estado int
)

go

drop table vehiculo

create table vehiculo
(
	vehiculoid int identity(1,1) primary key,
	marca nvarchar(50),
	modelo nvarchar(50),
	placa nvarchar(50),
	usuarioid int
)

go

drop table usuario

create table usuario
(
	usuarioid int identity(1,1) primary key,
	nombre nvarchar(50),
	apellido nvarchar(50),
	tipodocumento int,
	documento nvarchar(50),
	marca nvarchar(50),
	modelo nvarchar(50),
	placa nvarchar(50),
	correo nvarchar(50),
	contrasena nvarchar(50)
)

go

drop table estacionamiento

create table estacionamiento
(
	estacionamientoid int identity(1,1) primary key,
	piso nvarchar(50),
	espacio nvarchar(50),
	tipo int,
	estado int
)




go

ALTER TABLE reserva ADD FOREIGN KEY (usuarioid) REFERENCES usuario(usuarioid);
ALTER TABLE reserva ADD FOREIGN KEY (estacionamientoid) REFERENCES estacionamiento(estacionamientoid);
ALTER TABLE vehiculo ADD FOREIGN KEY (usuarioid) REFERENCES usuario(usuarioid);

