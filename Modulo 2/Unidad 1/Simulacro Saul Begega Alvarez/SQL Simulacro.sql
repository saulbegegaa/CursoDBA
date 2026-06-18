DROP TABLE IF EXISTS ventas;

CREATE TABLE ventas (
    id_venta SERIAL PRIMARY KEY,
    fecha DATE,
    cliente VARCHAR(50),
    ciudad VARCHAR(50),
    producto VARCHAR(50),
    categoria VARCHAR(50),
    cantidad INT,
    precio_unitario NUMERIC(10,2)
);

INSERT INTO ventas (fecha, cliente, ciudad, producto, categoria, cantidad, precio_unitario) VALUES
('2024-01-10', 'Ana', 'Madrid', 'Laptop', 'Tecnologia', 1, 1200),
('2024-01-11', 'Luis', 'Barcelona', 'Mouse', 'Tecnologia', 2, 25),
('2024-01-12', 'Carlos', 'Valencia', 'Teclado', 'Tecnologia', 1, 45),
('2024-01-13', 'Ana', 'Madrid', 'Silla', 'Muebles', 1, 150),
('2024-01-14', 'Marta', 'Sevilla', 'Mesa', 'Muebles', 1, 300),
('2024-01-15', 'Luis', 'Barcelona', 'Monitor', 'Tecnologia', 1, 200),
('2024-01-16', 'Carlos', 'Valencia', 'Lampara', 'Hogar', 3, 30),
('2024-01-17', 'Ana', 'Madrid', 'Tablet', 'Tecnologia', 1, 500),
('2024-01-18', 'Marta', 'Sevilla', 'Sofa', 'Muebles', 1, 700),
('2024-01-19', 'Luis', 'Barcelona', 'Auriculares', 'Tecnologia', 2, 80),
('2024-01-20', 'Carlos', 'Valencia', 'Cafetera', 'Hogar', 1, 90),
('2024-01-21', 'Ana', 'Madrid', 'Impresora', 'Tecnologia', 1, 150),
('2024-01-22', 'Marta', 'Sevilla', 'Alfombra', 'Hogar', 2, 120),
('2024-01-23', 'Luis', 'Barcelona', 'Escritorio', 'Muebles', 1, 250),
('2024-01-24', 'Carlos', 'Valencia', 'Ventilador', 'Hogar', 2, 60);


-- ---------------------  INSERT --------------------------------------
-- 1. Insertar una nueva venta
INSERT INTO ventas (fecha, cliente, ciudad, producto, categoria, cantidad, precio_unitario) VALUES 
('2024-01-25', 'Pedro', 'Bilbao', 'Tablet', 'Tecnología', 2, 450);

-- 2. Insertar dos ventas en una sola consulta
INSERT INTO ventas (fecha, cliente, ciudad, producto, categoria, cantidad, precio_unitario) VALUES
('2024-01-26', 'Laura', 'Barcelona', 'Silla', 'Muebles', 1, 180),
('2024-01-26', 'Jorge', 'Madrid', 'Cafetera', 'Hogar', 1, 95);

-- ---------------------  UPDATE --------------------------------------
-- 3. Actualizar el precio de los productos de categoria Muebles vendidos en Madrid, aumentando su precio en un 15%
UPDATE ventas
SET precio_unitario = precio_unitario * 1.15
WHERE categoria = 'Muebles' AND ciudad = 'Madrid'

-- 4. Actualizar el precio de todos los productos de categoría Tecnologia, aumentando un 10%
UPDATE ventas
SET precio_unitario = precio_unitario * 1.10
WHERE categoria = 'Tecnologia'

-- 5. Cambiar la ciudad de todos los clientes llamados Carlos a Alicante
UPDATE ventas
SET ciudad = 'Alicante'
WHERE cliente = 'Carlos'

-- 6. Incrementar en 1 la cantidad de todas las ventas cuyo producto sea Mouse
UPDATE ventas
SET cantidad = cantidad +1
WHERE producto = 'Mouse'

-- 7. Aplicar un descuento del 20% en el precio a todas las ventas anteriores al 15 de enero de 2024
UPDATE ventas
SET precio_unitario = precio_unitario * 0.80
WHERE fecha < '2024-01-15'

-- --------------------- DELETE --------------------------------------
-- 8. Elimina todas las ventas de la categoria Hogar
DELETE FROM ventas
WHERE categoria = 'Hogar'

-- 9. Elimina las ventas con cantidad menor o igual a 1
DELETE FROM ventas
WHERE cantidad <= 1

-- 10. Elimina todas las ventas de un cliente especcífico (por ejemplo: Luis)
DELETE FROM ventas
WHERE cliente = 'Luis'