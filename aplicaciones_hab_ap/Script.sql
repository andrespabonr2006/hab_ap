/*
CREATE DATABASE db_hab_ap;
GO
USE db_hab_ap;
GO

CREATE TABLE [Usuarios] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Nombre] NVARCHAR(50) NOT NULL,
    [Contraseña] NVARCHAR(50) NOT NULL,
);

CREATE TABLE [Habitaciones] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Codigo] NVARCHAR(20) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [Capacidad] INT NOT NULL,
    [Personas] INT NOT NULL,
    [Precio] DECIMAL(10, 2) NOT NULL,
    [FechaEspecial] BIT NOT NULL,
    [Descuento] DECIMAL(10, 2) NOT NULL,
    [Total] DECIMAL(10, 2) NOT NULL,
    [Usuario] INT NOT NULL REFERENCES [Usuarios]([Id]),
);

CREATE TABLE [Auditorias] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Descripcion] NVARCHAR(500) NOT NULL,
    [Fecha] SMALLDATETIME NOT NULL,
);

INSERT INTO [Usuarios] ([Nombre], [Contraseña]) VALUES ('admin', '1234');
INSERT INTO [Habitaciones] ([Codigo], [Nombre], [Capacidad], [Personas], [Precio], [FechaEspecial], [Descuento], [Total], [Usuario])
VALUES ('H-101', 'Doble', 2, 2, 200.00, 0, 26.00, 174.00, 1);
INSERT INTO [Auditorias] ([Descripcion], [Fecha]) VALUES ('Creacion', '20261112');
*/
