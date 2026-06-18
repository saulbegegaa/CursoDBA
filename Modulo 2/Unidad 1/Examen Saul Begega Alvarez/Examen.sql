-- Crear tabla
CREATE TABLE empleados (
    id_empleado SERIAL PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    departamento VARCHAR(50),
    salario NUMERIC(10,2),
    fecha_ingreso DATE,
    activo BOOLEAN
);

-- Insertar datos iniciales
INSERT INTO empleados (nombre, apellido, departamento, salario, fecha_ingreso, activo)
VALUES
('Juan', 'Pérez', 'IT', 2500, '2020-01-15', TRUE),
('María', 'Gómez', 'HR', 2200, '2019-03-10', TRUE),
('Carlos', 'López', 'IT', 2800, '2021-07-23', TRUE),
('Ana', 'Martínez', 'Ventas', 2000, '2018-11-05', FALSE),
('Luis', 'Sánchez', 'IT', 3000, '2022-02-14', TRUE),
('Laura', 'Díaz', 'Ventas', 2100, '2020-06-01', TRUE),
('Pedro', 'Ramírez', 'HR', 2300, '2017-09-19', FALSE),
('Sofía', 'Torres', 'Marketing', 2400, '2021-12-11', TRUE);




-- INSERT
-- 1. INSERTAR UN EMPLEADO LLAMADO RAUL ORTEGA EN FINANZAS CON SALARIO 2600
INSERT INTO empleados (nombre, apellido, departamento, salario)
VALUES ('Raúl', 'Ortega', 'Finanzas', 2600);

-- 2. Insertar un empleado en IT con salario 2700 y fecha de hoy
INSERT INTO empleados (nombre, apellido, departamento, salario, fecha_ingreso)
VALUES ('Enrique', 'Formación', 'IT', 2700, '2026-06-15');

-- 3. Insertar dos empleados en una sola sentencia
INSERT INTO empleados (nombre, apellido, departamento, salario, fecha_ingreso, activo)
VALUES
('Saul', 'Begega', 'Padawan', 2600, '2026-06-15', TRUE),
('Anakin', 'Skywalker', 'Jedi', 5000, '1983-12-30', FALSE);

-- 4. Insertar un empleado con salario NULL
INSERT INTO empleados (nombre, apellido, departamento, fecha_ingreso, activo)
VALUES 
('Maestro', 'Yoda', 'Jedi', '1977-01-01', FALSE);

-- 5. Insertar un empleado inactivo
INSERT INTO empleados (nombre, apellido, departamento, salario, fecha_ingreso, activo)
VALUES 
('Qui-Gonn', 'Jin', 'Jedi', 3520, '2001-01-01', FALSE);

-- UPDATE
-- 6. Cambiar el salario de Juan Perez a 2600
UPDATE empleados
SET salario = 2600
WHERE nombre = 'Juan' AND apellido = 'Pérez'

-- 7. Cambiar el departamento de Ana Martinez a IT
UPDATE empleados
SET departamento = 'IT'
WHERE nombre = 'Ana' AND apellido = 'Martínez'

-- 8. Activar TRUE a todos los empleados
UPDATE empleados
SET activo = TRUE

-- 9. Desactivar (FALSE) a todos los empleados departamento HR
UPDATE empleados
SET activo = FALSE
WHERE departamento = 'HR'

-- 10. Aumentar el salario en 100 a todos los empleados de Ventas
UPDATE empleados
SET salario = salario + 100
WHERE departamento = 'Ventas'

-- 11. Reducir el salario en 50 a los empleados de IT
UPDATE empleados
SET salario = salario - 50
WHERE departamento = 'IT'

-- 12. Cambiar la fecha de ingreso de Laura Díaz a 2021-01-01
UPDATE empleados
SET fecha_ingreso = '2021-01-01'
WHERE nombre = 'Laura' AND apellido = 'Díaz'

-- 13. Cambiar el departamento de todos los empleados a 'General'
UPDATE empleados
SET departamento = 'General'

-- 14. Poner salario en 2000 a los empleados inactivos
UPDATE empleados
SET salario = 2000
WHERE activo = FALSE

-- 15. Activar a los empleados con salario mayor a 2500
UPDATE empleados
SET activo = TRUE
WHERE salario > 2500

-- DELETE
-- 16. Eliminar al empleado Pedro Ramírez
DELETE FROM empleados
WHERE nombre = 'Pedro' AND Apellido = 'Ramírez'

-- 17. Eliminar todos los empleados inactivos
DELETE FROM empleados
WHERE activo = FALSE

-- 18. Eliminar los empleados del departamento Marketing
DELETE FROM empleados
WHERE departamento = 'Marketing'

-- 19. Eliminar empleados con salario menor a 2200
DELETE FROM empleados
WHERE salario < 2200

-- 20. Eliminar todos los empleados
DELETE FROM empleados

