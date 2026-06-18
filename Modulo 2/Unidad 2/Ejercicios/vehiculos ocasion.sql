-- 1. CREACIÓN DE TABLAS

CREATE TABLE clientes (
    codigo_cliente INT PRIMARY KEY CHECK (codigo_cliente BETWEEN 1 AND 3000),
    nombre_cliente VARCHAR(15) NOT NULL,
    apellidos_cliente VARCHAR(30) NOT NULL,
    direccion_cliente VARCHAR(30),
    poblacion_cliente VARCHAR(15) DEFAULT 'VALENCIA',
    telefono_cliente VARCHAR(10),
    fecha_nacimiento DATE
);

CREATE TABLE coches_vendidos (
    matricula VARCHAR(7) PRIMARY KEY,
    marca VARCHAR(15),
    modelo VARCHAR(20),
    color VARCHAR(15),
    precio NUMERIC(10,2),
    extras_instalados TEXT,
    codigo_cliente INTEGER REFERENCES clientes(codigo_cliente)
);

CREATE TABLE revisiones (
    numero_revision SERIAL PRIMARY KEY,
    cambio_aceite BOOLEAN,
    cambio_filtro BOOLEAN,
    revision_frenos BOOLEAN,
    otros TEXT,
    matricula VARCHAR(7) REFERENCES coches_vendidos(matricula)
);

-- 2. INSERCIÓN DE DATOS

INSERT INTO clientes (codigo_cliente, nombre_cliente, apellidos_cliente, direccion_cliente, poblacion_cliente, telefono_cliente, fecha_nacimiento) VALUES
(100, 'Antonio', 'García Pérez', 'Astilleros, 3', 'Valencia', '963689521', '1960-08-15'),
(101, 'Carlos', 'Pérez Ruiz', 'Magallanes, 21', 'Valencia', '963485147', '1958-04-26'),
(105, 'Luis', 'Rodríguez Más', 'Juan de Mena, 11', 'Valencia', '962965478', '1961-03-30'),
(112, 'Jaime', 'Juangarín Sornes', 'Balmes, 21', 'Valencia', '963664596', '1968-01-31'),
(225, 'Alfonso', 'Prats Motolla', 'Séneca, 23', 'Valencia', '963547852', '1969-04-28'),
(260, 'José', 'Navarro Lard', 'Río Segura, 14', 'Valencia', '963874569', '1964-04-15'),
(289, 'Elisa', 'Úbeda Sansón', 'Valencia, 4', 'Valencia', '963547812', '1962-07-10'),
(352, 'Eva', 'San Martín', 'Villafranca, 34', 'Valencia', '962401589', '1965-08-12'),
(365, 'Gerardo', 'Hernández Luis', 'Salinas, 8', 'Valencia', '963589621', '1965-01-02'),
(390, 'Carlos', 'Prats Ruiz', 'Ercilla, 8', 'Valencia', '963589654', '1967-05-03'),
(810, 'Lourdes', 'Oliver Peris', 'Gran Vía, 34', 'Valencia', '963587412', '1964-06-25'),
(822, 'Sergio', 'Larred Navas', 'Blasco Ibáñez, 65', 'Valencia', '963589621', '1967-12-25'),
(860, 'Joaquín', 'Arboles Onsins', 'Gandía, 8', 'Valencia', '963758963', '1969-05-04');

INSERT INTO coches_vendidos (matricula, marca, modelo, color, precio, extras_instalados, codigo_cliente) VALUES
('V2360OX', 'Opel', 'Corsa 1.2 Sport', 'Azul', 12600, 'Antena eléctrica', 100),
('V1010PB', 'Ford', 'Probe 2.0 16V', 'Blanco', 17160, NULL, 101),
('V4578OB', 'Ford', 'Orion 1.8 Ghia', 'Negro', 16500, 'Aire acondicionado', 105),
('V7640OU', 'Citroen', 'Xantia 16V', 'Negro', 14880, 'Airbag', 225),
('V3543NC', 'Ford', 'Escort 1.6 Ghia', 'Rojo', 15000, NULL, 260),
('V7632NX', 'Citroen', 'ZX Turbo-D', 'Rojo', 16800, 'Aire acondicionado, Airbag', 289),
('V8018LJ', 'Ford', 'Fiesta 1.4 CLX', 'Azul', 11700, 'Elevalunas eléctricos', 352),
('V2565NB', 'Renault', 'Clio 1.7 S', 'Blanco', 12600, NULL, 390),
('V7642OU', 'Ford', 'Mondeo 1.8 GLX', 'Blanco', 18600, NULL, 810),
('V1234LC', 'Audi', '100 2.3', 'Verde', 21060, 'Climatizador', 822),
('V9834LH', 'Peugeot', '205 GTI', 'Rojo', 14700, NULL, 860);

INSERT INTO revisiones (numero_revision, cambio_aceite, cambio_filtro, revision_frenos, otros, matricula) VALUES
(1, TRUE, FALSE, FALSE, 'Revisar luces', 'V7632NX'),
(2, TRUE, TRUE, FALSE, 'Cambiar limpias', 'V7632NX'),
(3, FALSE, TRUE, TRUE, 'Arreglar alarma', 'V4578OB'),
(4, FALSE, TRUE, TRUE, 'Ajustar tablero', 'V2360OX'),
(5, TRUE, TRUE, TRUE, 'Cambiar limpias. Revisar luces', 'V2565NB'),
(6, FALSE, FALSE, TRUE, 'Cambiar luz interior', 'V7640OU'),
(7, TRUE, TRUE, FALSE, NULL, 'V2565NB'),
(8, FALSE, FALSE, FALSE, NULL, 'V8018LJ'),
(9, TRUE, FALSE, TRUE, 'Regular encendido', 'V3543NC'),
(10, FALSE, TRUE, FALSE, 'Reparar puerta delantera', 'V8018LJ'),
(11, FALSE, FALSE, FALSE, NULL, 'V3543NC'),
(12, TRUE, TRUE, TRUE, NULL, 'V1234LC'),
(13, FALSE, TRUE, FALSE, 'Cambiar limpias', 'V9834LH'),
(14, FALSE, TRUE, FALSE, NULL, 'V1010PB');


-- 3. CONSULTAS DE SELECCIÓN

-- a) 
SELECT matricula, marca, modelo 
FROM coches_vendidos 
ORDER BY matricula ASC;

-- b) 
SELECT * 
FROM coches_vendidos 
WHERE marca = 'Ford';

-- c) 
SELECT * 
FROM coches_vendidos 
WHERE marca = 'Ford' AND precio > 15600;

-- d) 
SELECT DISTINCT c.* 
FROM clientes c
JOIN coches_vendidos cv ON c.codigo_cliente = cv.codigo_cliente
WHERE cv.marca IN ('Ford', 'Citroen');

-- e) 
SELECT DISTINCT cv.matricula, cv.modelo 
FROM coches_vendidos cv
JOIN revisiones r ON cv.matricula = r.matricula
WHERE r.cambio_aceite = TRUE AND r.cambio_filtro = TRUE;

-- f) 
SELECT DISTINCT c.* 
FROM clientes c
JOIN coches_vendidos cv ON c.codigo_cliente = cv.codigo_cliente
WHERE cv.marca = 'Ford' AND cv.extras_instalados IS NOT NULL AND cv.extras_instalados <> '';

-- g) 
SELECT DISTINCT cv.marca, cv.modelo 
FROM coches_vendidos cv
JOIN revisiones r ON cv.matricula = r.matricula
WHERE r.cambio_aceite = TRUE AND r.cambio_filtro = TRUE AND r.revision_frenos = TRUE;

-- h) 
SELECT DISTINCT cv.marca, cv.modelo 
FROM coches_vendidos cv
JOIN revisiones r ON cv.matricula = r.matricula
WHERE r.cambio_aceite = TRUE AND r.revision_frenos = FALSE;

-- i) 
SELECT DISTINCT cv.marca, cv.modelo 
FROM coches_vendidos cv
JOIN revisiones r ON cv.matricula = r.matricula
WHERE r.cambio_aceite = FALSE AND r.cambio_filtro = FALSE AND r.revision_frenos = FALSE;

-- j) 
SELECT COUNT(DISTINCT matricula) AS coches_con_cambio_aceite FROM revisiones WHERE cambio_aceite = TRUE;

-- k) 
SELECT COUNT(DISTINCT cv.matricula) AS coches_sin_revision_frenos
FROM coches_vendidos cv
WHERE NOT EXISTS 
(SELECT 1 FROM revisiones r 
 WHERE r.matricula = cv.matricula AND r.revision_frenos = TRUE);

-- l) 
SELECT DISTINCT cv.* 
FROM coches_vendidos cv 
JOIN revisiones r ON cv.matricula = r.matricula 
WHERE r.otros ILIKE '%limpias%';

-- m) 
SELECT marca, MAX(precio) AS precio_mas_caro 
FROM coches_vendidos 
GROUP BY marca;

-- n) 
SELECT COUNT(DISTINCT codigo_cliente) AS clientes_coche_rojo 
FROM coches_vendidos 
WHERE color = 'Rojo';

-- o) 
SELECT c.nombre_cliente, c.apellidos_cliente, cv.marca, r.cambio_aceite, r.cambio_filtro, r.revision_frenos, r.otros
FROM clientes c
JOIN coches_vendidos cv ON c.codigo_cliente = cv.codigo_cliente
JOIN revisiones r ON cv.matricula = r.matricula
WHERE cv.matricula = 'V4578OB';

-- p) 
SELECT cv.marca, cv.modelo, c.nombre_cliente, c.apellidos_cliente 
FROM coches_vendidos cv
JOIN clientes c ON cv.codigo_cliente = c.codigo_cliente
WHERE cv.extras_instalados IS NOT NULL AND cv.extras_instalados <> '';

-- q) 
SELECT marca, COUNT(DISTINCT modelo) AS total_modelos 
FROM coches_vendidos 
GROUP BY marca;

-- r) 
SELECT SUM(precio) AS total_ventas_ford 
FROM coches_vendidos 
WHERE marca = 'Ford';

-- s)
SELECT *, (precio * 1.16) AS precio_en_dolares 
FROM coches_vendidos;

-- t) Clientes más jóvenes 
SELECT * 
FROM clientes 
WHERE fecha_nacimiento = (SELECT MAX(fecha_nacimiento) FROM clientes);


-- u) Color y modelo del Ford más caro
SELECT color, modelo 
FROM coches_vendidos 
WHERE marca = 'Ford' AND precio = (SELECT MAX(precio) FROM coches_vendidos WHERE marca = 'Ford');

-- CONSULTAS DML
-- 1. Actualizar color de Ford a Rojo Metalizado 
UPDATE coches_vendidos 
SET color = 'Rojo Metalizado' 
WHERE marca = 'Ford';

-- 2. Incrementar precio del Xantia un 10% 
UPDATE coches_vendidos 
SET precio = precio * 1.10 
WHERE modelo LIKE '%Xantia%';


-- 3. Modificar teléfono de Antonio de Astilleros
UPDATE clientes 
SET telefono_cliente = '963111222' 
WHERE nombre_cliente = 'Antonio' AND direccion_cliente LIKE '%Astilleros%';

-- 4. 
UPDATE revisiones 
SET revision_frenos = TRUE 
WHERE matricula LIKE '%6%' AND matricula LIKE '%X';