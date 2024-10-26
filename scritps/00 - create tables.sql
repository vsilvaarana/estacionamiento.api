
create table usuario
(
	usuarioid int identity(1,1) primary key,
	nombre nvarchar(50),
	apellido nvarchar(50),
	tipodocumento int,
	documento nvarchar(50),
	correo nvarchar(50),
	contrasena nvarchar(50)
)

go

create table estacionamiento
(
	estacionamientoid int identity(1,1) primary key,
	piso nvarchar(50),
	espacio nvarchar(50),
	tipo int,
	estado int
)

go

create table vehiculo
(
	vehiculoid int identity(1,1) primary key,
	marca nvarchar(50),
	modelo nvarchar(50),
	placa nvarchar(50),
	usuarioid int
)

go

create table reserva
(
	reservaid int identity(1,1) primary key,
	usuarioid int,
	estacionamientoid int,
	vehiculoid int,
	fecha datetime,
	tipo int,
	estado int
)

go

ALTER TABLE reserva ADD FOREIGN KEY (usuarioid) REFERENCES usuario(usuarioid);
ALTER TABLE reserva ADD FOREIGN KEY (estacionamientoid) REFERENCES estacionamiento(estacionamientoid);
ALTER TABLE reserva ADD FOREIGN KEY (vehiculoid) REFERENCES vehiculo(vehiculoid);
ALTER TABLE vehiculo ADD FOREIGN KEY (usuarioid) REFERENCES usuario(usuarioid);