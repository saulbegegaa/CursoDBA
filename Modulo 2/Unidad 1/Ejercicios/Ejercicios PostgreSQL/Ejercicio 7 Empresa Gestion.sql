-- CREAMOS LA TABLA EMPLEADOS

CREATE TABLE tblEmpleados 
(
strNombre VARCHAR(20),
strApellidos VARCHAR (40),
strDepartamento VARCHAR (20),
strPuesto VARCHAR (20),
intAntiguedad INT,
monSueldoBase MONEY,
bolCasado BOOLEAN,
datFechaNacimiento DATE
);

-- Introducimos los siguientes registros a la tabla empleados

INSERT into tblEmpleados VALUES
('Esteban', 'Ruiz Penalba', 'Demandas', 'Auxiliar', 24, 980, True, '1962-08-12'),
('Veronica', 'Sanchez Leal', 'Ingenieria', 'Asesor Tecnico', 36, 1000, False, '1966-06-13'),
('Angel', 'Mataro Polar', 'Discos', 'Representante', 12, 800, False, '1958-02-02'),
('Hilda', 'Moran Blasco', 'Ocio y Deporte', 'Encargada', 42, 950, True, '1967-09-20');

-- LA EMPRESA DECIDE AUMENTAR EL SUELDO A LOS EMPLEADOS QUE COBRAN MAS DE 600. LA SUBIDA ES DEL 10%. REALIZAR UNA CONSULTA QUE REFLEJE LOS CAMBIOS SOBRE LA TABLA

UPDATE tblempleados
SET monSueldoBase = monSueldoBase * 1.1 
WHERE monSueldoBase > 600::money;

-- REALIZAR UNA CONSULTA QUE NOS MUESTRE LOS EMPLEADOS CASADOS Y NACIDOS EN EL 67
SELECT strNombre AS Nombre, strApellidos AS Apellidos, bolCasado AS "¿Está casado?", datFechaNacimiento AS "Fecha de nacimiento"
FROM tblempleados
WHERE bolCasado = True AND datFechaNacimiento BETWEEN '1967-01-01' AND '1967-12-31';

-- QUEREMOS SABER LOS QUE COBRAN MAS DE 980

SELECT strNombre AS Nombre, strApellidos AS Apellidos, monSueldoBase AS Sueldo
FROM tblempleados
WHERE monSueldoBase >980::money;

-- QUEREMOS SABER QUE EMPLEADOS COBRAN MAS DE 1000

SELECT strNombre AS Nombre, strApellidos AS Apellidos, monSueldoBase AS Sueldo
FROM tblempleados
WHERE monSueldoBase >1000::money;

-- INSERTAR DATOS

INSERT INTO tblempleados
VALUES
('Flor','Nadal Jerez','Joyeria','Piedras Preciosas',2,1010,True,'1958-05-06'),
('David','Alonso Díaz','Libreria','Vendedor',4,990,True,'1965,01-01'),
('Yulisa','Valverde Torre','Contabilidad','Supervisora',5,11200,True,'1975-04-19'),
('Gerardo','Garcia Alvarez','Investigacion','Jefe Laboratorio',7,1500,True,'1970-05-18');

-- LA EMPRESA DECIDE CAMBIAR DE DEPARTAMENTO A VERONICA SANCHEZ LEAL. SU NUEVO DEPARTAMENTO SERA EL DE INVESTIGACION

UPDATE tblempleados 
SET strDepartamento = 'Investigacion'
WHERE strNombre = 'Veronica' AND strApellidos = 'Sanchez Leal';

-- INCREMENTAR EN 1 MES LA ANTIGUEDAD DE TODOS LOS EMPLEADOS

UPDATE tblempleados 
SET intAntiguedad = intAntiguedad + 1;

-- VERONICA CAMBIA DE ESTADO CIVIL. REFLEJALO EN LA TABLA

UPDATE tblempleados 
SET bolCasado = True
WHERE strNombre = 'Veronica' AND strApellidos = 'Sanchez Leal';

-- REALIZAR UNA CONSULTA QUE PERMITA CAMBIAR EL DEPARTAMENTO DE ANGEL AUMENTANDO SU SALARIO EN 200

UPDATE tblempleados
SET strDepartamento = 'Escanciador', monSueldoBase = monSueldoBase + 200::money
WHERE strNombre = 'Angel';

-- SE DESEA DESPEDIR A GERARDO POR POCA PRODUCTIVIDAD (EL WHERE HA DE INCLUIR NOMBRE Y APELLIDO)

DELETE FROM tblempleados
WHERE strNombre = 'Gerardo' 
  AND strApellidos = 'Garcia Alvarez';


-- LA EMPRESA TIENE EXCESO DE TRABAJADORES Y DECIDE DESPEDIR A LOS EMPLEADOS QUE LLVEN MENOS DE 1 AÑO Y MEDIO EN ELLA. REALIZAR UNA CONSULTA DE ELIMINACION QUE MODIFIQUE LOS DATOS DE LA TABLA

DELETE FROM tblempleados
WHERE intAntiguedad < 18;

