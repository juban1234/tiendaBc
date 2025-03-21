create database tiendadb;
use tiendadb;


-- Tabla para los usuarios (administradores y vendedores)
CREATE TABLE Usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    contraseña VARCHAR(255) NOT NULL,
    rol ENUM('vendedor', 'administrador') NOT NULL, 
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabla para los proveedores
CREATE TABLE Proveedores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    telefono VARCHAR(20),
    email VARCHAR(255) UNIQUE, 
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabla para los productos (bicicletas y accesorios)
CREATE TABLE Productos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    descripcion TEXT,
    precio DECIMAL(10, 2) NOT NULL,
    cantidad INT DEFAULT 0,
    imagen LONGBLOB,  
    fecha_agregado TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    id_proveedor INT,  -- Agregado para vincular al proveedor
    FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id)  -- Relación con el proveedor
);

-- Tabla para registrar las ventas realizadas
CREATE TABLE Ventas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT, 
    fecha_venta TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10, 2), 
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id)
);

-- Tabla intermedia entre ventas y productos (relación muchos a muchos)
CREATE TABLE Ventas_Productos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_venta INT,
    id_producto INT,
    cantidad INT,  
    precio_unitario DECIMAL(10, 2),  
    FOREIGN KEY (id_venta) REFERENCES Ventas(id),
    FOREIGN KEY (id_producto) REFERENCES Productos(id)
);

-- Tabla para registrar las facturas generadas
CREATE TABLE Facturas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_venta INT,
    monto_total DECIMAL(10, 2),  
    fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_venta) REFERENCES Ventas(id)
);

-- Tabla para gestionar el inventario (acciones de agregar o actualizar inventarios)
CREATE TABLE Inventarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_producto INT,  
    cantidad INT,  
    tipo_accion ENUM('entrada', 'salida'), 
    fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_producto) REFERENCES Productos(id)
);

