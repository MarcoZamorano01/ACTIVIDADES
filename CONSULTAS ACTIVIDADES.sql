--BASE DE DATOS TIENDA ACT
CREATE DATABASE TIENDA_ACT

--CREAR TABLAS

CREATE TABLE CLIENTE (
    IDCLIENTE INT IDENTITY(1,1) PRIMARY KEY,
    NOMBRE NVARCHAR(50) NOT NULL,
    APELLIDO NVARCHAR(50) NOT NULL,
    CORREO NVARCHAR(50) NULL,
    TELEFONO NVARCHAR(50) NULL,
    DIRECCION NVARCHAR(50) NOT NULL
);

CREATE TABLE PEDIDO (
    IDPEDIDO INT IDENTITY(1,1) PRIMARY KEY,
    IDCLIENTE INT NOT NULL,
    FECHA DATETIME NOT NULL,
    TOTAL MONEY NOT NULL,
    ESTADO NVARCHAR(20) NOT NULL,
    FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE(IDCLIENTE)
);
--AGREAGAR DATOS
insert into cliente values ('Marco','Zamorano','marco@gmail.com','69585925', 'B. San Juan');
insert into cliente values ('Andres','Aramayo','andres@gmail.com','69585926', 'B. San Lucas');
insert into cliente values ('Carlos','Ortiz','carlos@gmail.com','69585932', 'B. San Pedro');

insert into pedido values (1, '2022-02-01 14:00:00','100', 'Activo');
insert into pedido values (2, '2022-02-02 14:00:00','200', 'Activo');
insert into pedido values (3, '2022-02-03 14:00:00','300', 'Activo');
--CONSULTAS
SELECT *
FROM CLIENTE

SELECT *
FROM PEDIDO

