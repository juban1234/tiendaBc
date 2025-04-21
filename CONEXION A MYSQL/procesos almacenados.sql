use tiendadb;

 ALTER TABLE ventas ADD COLUMN usuario_id INT;

select * from usuarios;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VenderProducto`(
    IN p_nombre_producto VARCHAR(255),
    IN p_cantidad INT,
    IN p_id_usuario INT
)
BEGIN
    DECLARE v_id_producto INT;
    DECLARE v_precio DECIMAL(10, 2);
    DECLARE v_stock INT;
    DECLARE v_total DECIMAL(10, 2);
    DECLARE v_id_venta INT;

    -- Buscar el producto por nombre
    SELECT id, precio, cantidad
    INTO v_id_producto, v_precio, v_stock
    FROM productos
    WHERE nombre = p_nombre_producto
    LIMIT 1;

    -- Si el producto no existe, lanzar error
    IF v_id_producto IS NULL THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Producto no encontrado';
    END IF;

    -- Verificar si hay suficiente stock
    IF v_stock < p_cantidad THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No hay suficiente stock para vender';
    END IF;

    -- Calcular el total de la venta
    SET v_total = v_precio * p_cantidad;

    -- Registrar la venta en la tabla ventas
    INSERT INTO ventas (id_usuario, total) 
    VALUES (p_id_usuario, v_total);

    -- Obtener el id de la venta recién registrada
    SET v_id_venta = LAST_INSERT_ID();

    -- Registrar los productos vendidos en la tabla ventas_productos
    INSERT INTO ventas_productos (id_venta, id_producto, cantidad, precio_unitario) 
    VALUES (v_id_venta, v_id_producto, p_cantidad, v_precio);

    -- Actualizar el stock del producto
    UPDATE productos
    SET cantidad = cantidad - p_cantidad
    WHERE id = v_id_producto;

    -- Registrar la salida de inventario
    INSERT INTO inventarios (id_producto, cantidad, tipo_accion) 
    VALUES (v_id_producto, p_cantidad, 'salida');

END $$

DELIMITER ;

select * from inventarios;

select * from usuarios;

DELIMITER //
CREATE PROCEDURE BuscarUsuarioPorEmail(IN p_email VARCHAR(100))
BEGIN
    SELECT nombre, contraseña, rol
    FROM usuarios
    WHERE email = p_email;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE RegistrarUsuario(
    IN p_nombre VARCHAR(100),
    IN p_email VARCHAR(100),
    IN p_contraseña TEXT,
    IN p_rol VARCHAR(50)
)
BEGIN
    INSERT INTO usuarios (nombre, email, contraseña, rol)
    VALUES (p_nombre, p_email, p_contraseña, p_rol);
END //
DELIMITER ;

