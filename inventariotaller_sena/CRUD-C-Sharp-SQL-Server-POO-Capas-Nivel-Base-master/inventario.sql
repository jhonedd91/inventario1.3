create database inventario;

use inventario;

create table usuario(
	id int primary key auto_increment not null,
    nombre varchar(50),
    apellido varchar(50),
    fecha_nacimiento date,
    email varchar(100),
    password varchar(8)
);

create table proveedor(
	id int primary key auto_increment not null,
	nombre varchar(50),
    direccion varchar(100),
    telefono varchar(20),
    nombre_contacto varchar(100)
);

create table producto(
	id int primary key auto_increment not null,
	nombre varchar(50),
	percio_unitario int,
	descripcion longtext,
    cantidad int,
    id_proveedor int,
    foreign key (id_proveedor) references proveedor(id)
);

create table cliente(
	id int primary key auto_increment not null,
	nombre varchar(100),
    documento varchar(50),
    email varchar(100)
);

create table compra(
	id int primary key auto_increment not null,
	fecha date,
    total int,
    id_usuario int,
    id_cliente int,
	foreign key (id_usuario) references usuario(id),
    foreign key (id_cliente) references cliente(id)
);

create table producto_compra(
	id int primary key auto_increment not null,
	id_compra int,
    id_producto int,
    cantidad int,
	foreign key (id_compra) references compra(id),
	foreign key (id_producto) references producto(id)
);