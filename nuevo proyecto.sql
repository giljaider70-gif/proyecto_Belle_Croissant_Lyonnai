 create database Belle_Croissant_Lyonnais;


 use Belle_Croissant_Lyonnais;


 select * from PreguntaSeguridad;

 CREATE TABLE PreguntaSeguridad(
    IdPregunta INT IDENTITY(1,1) PRIMARY KEY,
    Pregunta NVARCHAR(200) NOT NULl);

    CREATE TABLE MetodoEntrega(
    IdMetodo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULl);

    CREATE TABLE Pais(
    IdPais INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULl );

    CREATE TABLE Ciudad(
    IdCiudad INT IDENTITY(1,1) PRIMARY KEY,
    IdPais INT NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,

    CONSTRAINT FK_Ciudad_Pais
        FOREIGN KEY(IdPais)
        REFERENCES Pais(IdPais)
);


CREATE TABLE Usuario(
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,

    IdPregunta INT NOT NULL,
    IdMetodo INT NOT NULL,

    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,

    Telefono NVARCHAR(20),

    Correo NVARCHAR(150) NOT NULL UNIQUE,

    PasswordHash NVARCHAR(255) NOT NULL,

    FotoPerfil NVARCHAR(255),

    RespuestaHash NVARCHAR(255) NOT NULL,

    SuscripcionListaCorreo BIT NOT NULL DEFAULT(0),

    CONSTRAINT FK_Usuario_Pregunta
        FOREIGN KEY(IdPregunta)
        REFERENCES PreguntaSeguridad(IdPregunta),

    CONSTRAINT FK_Usuario_Metodo
        FOREIGN KEY(IdMetodo)
        REFERENCES MetodoEntrega(IdMetodo) );


        CREATE TABLE Direccion(

    IdDireccion INT IDENTITY(1,1) PRIMARY KEY,

    IdCiudad INT NOT NULL,

    Direccion NVARCHAR(250) NOT NULL,

    CodigoPostal NVARCHAR(20) NOT NULL,

    EsPreferida BIT NOT NULL DEFAULT(0),

    CONSTRAINT FK_Direccion_Ciudad
        FOREIGN KEY(IdCiudad)
        REFERENCES Ciudad(IdCiudad) );



        CREATE TABLE Pedido(

    IdPedido INT IDENTITY(1,1) PRIMARY KEY,

    IdUsuario INT NOT NULL,

    Fecha DATETIME NOT NULL,

    Estado NVARCHAR(50) NOT NULL,

    Total DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_Pedido_Usuario
        FOREIGN KEY(IdUsuario)
        REFERENCES Usuario(IdUsuario));








 CREATE TABLE Direccion_Usuario ( 
 id_Direccion_Usuario int identity (1,1) primary key ,
 id_IdUsuario int not null,
  IdDireccion INT NOT NULL,

  FOREIGN KEY ( id_IdUsuario ) REFERENCES Usuario( IdUsuario) ,

  FOREIGN KEY ( id_IdUsuario ) REFERENCES  Direccion( IdDireccion ) 

);






 