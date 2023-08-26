-- Crear la base de datos
CREATE DATABASE ADMINISTRACION;
GO

-- Cambiar al contexto de la base de datos recién creada
USE ADMINISTRACION;
GO

-- Crear la tabla Hospital
CREATE TABLE Hospital
(
    NOMBRE VARCHAR(50)PRIMARY KEY,
    MATERIAL VARCHAR(50),
    EQUIPO VARCHAR(50),
    MEDICINA VARCHAR(50),
    CANTIDAD_MATERIAL INT,
    CANTIDAD_EQUIPO INT,
    CANTIDAD_MEDICINA INT,
);

-- Insertar datos en la tabla Hospital
INSERT INTO Hospital (NOMBRE, MATERIAL, EQUIPO, MEDICINA, CANTIDAD_MATERIAL, CANTIDAD_EQUIPO, CANTIDAD_MEDICINA)
VALUES ('Hospital SM', 'Pinzas', 'Cirugano', 'Acetaminofen', 3, 2, 22,'A001');

-- Mostrar los datos de la tabla Hospital
SELECT * FROM Hospital;
