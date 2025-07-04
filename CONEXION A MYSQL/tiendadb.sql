-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-04-2025 a las 20:53:11
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.1.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tiendadb`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AgregarProovedores` (IN `pr_nombre` VARCHAR(255), IN `pr_direccion` VARCHAR(255), IN `pr_telefono` VARCHAR(20), IN `pr_email` VARCHAR(100))   begin
	insert into proveedores (nombre,direccion,telefono,email)
    values (pr_nombre, pr_direccion, pr_telefono, pr_email);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarProductos` (IN `p_nombre` VARCHAR(255))   begin
	select * from productos where nombre = p_nombre;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarUsuarioPorEmail` (IN `p_email` VARCHAR(255))   BEGIN
    SELECT nombre, rol, contraseña
    FROM usuarios
    WHERE email = p_email;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditarProducto` (IN `p_nombre` VARCHAR(255), IN `p_descripcion` TEXT, IN `p_precio` DECIMAL(10,2), IN `p_cantidad` INT)   BEGIN
    DECLARE v_id INT;
    SELECT id INTO v_id FROM Productos WHERE nombre = p_nombre LIMIT 1;
    IF v_id IS NOT NULL THEN
        UPDATE Productos 
        SET descripcion = p_descripcion,
            precio = p_precio,
            cantidad = p_cantidad
        WHERE id = v_id;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarProductoPorId` (IN `producto_name` VARCHAR(30))   BEGIN
    -- Eliminar el producto de la tabla Productos
    DELETE FROM Productos WHERE nombre = producto_name;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GuardarProducto` (IN `p_nombre` VARCHAR(255), IN `p_descripcion` TEXT, IN `p_precio` DECIMAL(10,2), IN `p_cantidad` INT, IN `p_imagen` LONGBLOB, IN `pr_id` INT)   BEGIN
    INSERT INTO Productos (nombre, descripcion, precio, cantidad, imagen,id_proveedor)
    VALUES (p_nombre, p_descripcion, p_precio, p_cantidad, p_imagen,pr_id);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerProductos` ()   BEGIN
    SELECT * FROM Productos;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarUsuario` (IN `p_nombre` VARCHAR(255), IN `p_email` VARCHAR(255), IN `p_contraseña` VARCHAR(255), IN `p_rol` ENUM('vendedor','administrador','jefe'))   BEGIN
    INSERT INTO usuarios (nombre, email, contraseña, rol)
    VALUES (p_nombre, p_email, p_contraseña, p_rol);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE `facturas` (
  `id` int(11) NOT NULL,
  `id_venta` int(11) DEFAULT NULL,
  `monto_total` decimal(10,2) DEFAULT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventarios`
--

CREATE TABLE `inventarios` (
  `id` int(11) NOT NULL,
  `id_producto` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `tipo_accion` enum('entrada','salida') DEFAULT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL,
  `cantidad` int(11) DEFAULT 0,
  `imagen` longblob DEFAULT NULL,
  `fecha_agregado` timestamp NOT NULL DEFAULT current_timestamp(),
  `id_proveedor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `nombre`, `descripcion`, `precio`, `cantidad`, `imagen`, `fecha_agregado`, `id_proveedor`) VALUES
(22, 'papitas', 'p', 1.00, 1, '', '2025-03-21 22:23:58', NULL),
(23, 'malmiss', 'fefef', 2.00, 1, '', '2025-03-25 17:39:47', NULL),
(24, 'Laptop Gamer', '1', 1.00, 1, NULL, '2025-03-25 17:59:01', NULL),
(35, 'Laptop Gamer2', 'Laptop con RTX 3060 y 16GB RAM', 2500.00, 10, NULL, '2025-03-26 18:18:19', NULL),
(36, 'Laptop Gamer2', 'Laptop con RTX 3060 y 16GB RAM', 2500.00, 10, NULL, '2025-03-26 20:35:35', NULL),
(37, 'merenges', 'e', 1.00, 1, '', '2025-03-26 20:46:25', 1),
(40, 'jujuju', '1', 1.00, 1, '', '2025-03-26 22:01:04', 1),
(42, 'merenges planos', 'wdede', 333.00, 3, '', '2025-04-04 20:21:21', 1),
(43, 'dededd', 'dede', 11.00, 11, '', '2025-04-04 22:31:09', 1),
(44, 'hthththhhhhhhhhhhhhhhhhhh', 'hhhhhhhhhhhh', 1.00, 11, '', '2025-04-04 22:32:22', 1),
(45, 'camron', 'efefef', 12121.00, 1, NULL, '2025-04-11 21:59:00', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `id` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`id`, `nombre`, `direccion`, `telefono`, `email`, `fecha_creacion`) VALUES
(1, 'hyh', 'yhyh', 'yhyh', 'hyh', '2025-03-26 20:43:11');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `contraseña` varchar(100) DEFAULT NULL,
  `rol` enum('vendedor','administrador','jefe') NOT NULL,
  `fecha_creacion` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `email`, `contraseña`, `rol`, `fecha_creacion`) VALUES
(12, 'papw', 'rgjrogrkog1@gmail.com', '$2a$11$357ZrwaX/2Fo0MuGBwsCV.wm8/SLK9pKPMM9O8.D2hiMEjMUGQL/a', 'vendedor', '2025-04-11 21:08:10'),
(13, 'juan', 'gjuanesteban413@gmail.com', '$2a$11$DQg//Yzzx56u.PvDMWA8S.lhmu3WcrQ0Fdrg.dcnsPksmtQM9D2Y6', 'vendedor', '2025-04-11 21:09:19'),
(14, 'pepito', 'alexzo8677@gmail.com', '$2a$11$Kf1oLAGzBO2YIM7CR3bIB.Eg5l3F5DspM5WJurAd3KHLFDbRtJhzW', 'administrador', '2025-04-11 21:19:43'),
(15, 'juan', 'ewewewe@gmail.com', '$2a$11$Wl2hDjOp3moB3Bnc4Y61I.797uSwRTyROeyJ.NJN0Jf63ef20eO7K', 'administrador', '2025-04-11 21:55:41'),
(16, 'miguel', 'efefefef@gmail.com', '$2a$11$TDYVM2FkmMbMn8GlAJVereiANv0hEk4kFQnlK5c4GIpfCQ61ZK41.', 'administrador', '2025-04-11 22:25:46');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `fecha_venta` timestamp NOT NULL DEFAULT current_timestamp(),
  `total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_productos`
--

CREATE TABLE `ventas_productos` (
  `id` int(11) NOT NULL,
  `id_venta` int(11) DEFAULT NULL,
  `id_producto` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_unitario` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_venta` (`id_venta`);

--
-- Indices de la tabla `inventarios`
--
ALTER TABLE `inventarios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_proveedor` (`id_proveedor`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `ventas_productos`
--
ALTER TABLE `ventas_productos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_venta` (`id_venta`),
  ADD KEY `id_producto` (`id_producto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `facturas`
--
ALTER TABLE `facturas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `inventarios`
--
ALTER TABLE `inventarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `ventas_productos`
--
ALTER TABLE `ventas_productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD CONSTRAINT `facturas_ibfk_1` FOREIGN KEY (`id_venta`) REFERENCES `ventas` (`id`);

--
-- Filtros para la tabla `inventarios`
--
ALTER TABLE `inventarios`
  ADD CONSTRAINT `inventarios_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id`);

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedores` (`id`);

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);

--
-- Filtros para la tabla `ventas_productos`
--
ALTER TABLE `ventas_productos`
  ADD CONSTRAINT `ventas_productos_ibfk_1` FOREIGN KEY (`id_venta`) REFERENCES `ventas` (`id`),
  ADD CONSTRAINT `ventas_productos_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
