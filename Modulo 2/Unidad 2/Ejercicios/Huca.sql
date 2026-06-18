CREATE TABLE HOSPITAL (
Cod_Hospital int PRIMARY KEY,
Nombre varchar(50),
Direccion varchar(50),
Telefono varchar(50),
Num_Cama int
);

CREATE TABLE SALA (
Cod_Sala int PRIMARY KEY,
Cod_Hospital int,
Nombre varchar(50),
Especialidad varchar(50),
CONSTRAINT FK_CodHospital_SalaHospital FOREIGN KEY (Cod_Hospital) REFERENCES HOSPITAL(Cod_Hospital) ON DELETE CASCADE
);


CREATE TABLE DEPARTAMENTO (
No_Dept INT PRIMARY KEY,
Nombre_Dpt VARCHAR(50),
Cod_Hospital int,
CONSTRAINT FK_CodHospital_DepartamentoHospital FOREIGN KEY (Cod_Hospital) REFERENCES HOSPITAL(Cod_Hospital) ON DELETE CASCADE
);

CREATE TABLE EMPLEADO (
No_Empleado int PRIMARY KEY,
Apellido varchar(50),
Oficio varchar(50),
Dir int,
Fecha_Alt date,
Salario numeric(9,2),
Comision numeric(9,2),
No_Dept int,
CONSTRAINT FK_DeptNo_EmpleadoDepartamento FOREIGN KEY (No_Dept) REFERENCES DEPARTAMENTO(No_Dept) ON DELETE CASCADE
);

CREATE TABLE DOCTOR (
No_Doctor INT PRIMARY KEY,
Cod_Hospital int,
Apellido VARCHAR(50),
Especialidad VARCHAR (50),
CONSTRAINT FK_CodHospital_DoctorHospital FOREIGN KEY (Cod_Hospital) REFERENCES HOSPITAL(Cod_Hospital) ON DELETE CASCADE
);


CREATE TABLE ENFERMO (
Inscripcion INT,
Apellido varchar(50),
Direccion varchar(50),
Dir Int,
Fecha_Nacimiento date,
Sexo VARCHAR(2),
NSS int,
Cod_Hospital int,
CONSTRAINT FK_CodHospital_EnfermoHospital FOREIGN KEY (Cod_Hospital) REFERENCES HOSPITAL(Cod_Hospital) ON DELETE CASCADE
);


CREATE TABLE PLANTILLA (
Cod_Hospital int,
Cod_Sala int,
No_Empleado int,
Apellido varchar(50),
Funcion varchar(50),
Turno varchar(5),
Salario numeric(9,2),
CONSTRAINT FK_CodHospital_PlantillaHospital FOREIGN KEY (Cod_Hospital) REFERENCES HOSPITAL(Cod_Hospital) ON DELETE CASCADE
);


