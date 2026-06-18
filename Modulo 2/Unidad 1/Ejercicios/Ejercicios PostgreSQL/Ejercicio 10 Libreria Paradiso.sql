-- Creamos la tabla
CREATE TABLE libros (
    strISBN VARCHAR(20) PRIMARY KEY,
    strTitulo VARCHAR(100) NOT NULL,
    strAutores VARCHAR(100),
    strEditorial VARCHAR(50),
    strMateria VARCHAR(50),
    intEstante INT,
    intExistencias INT,
    monPrecio MONEY
);

-- INSERTAMOS LOS DATOS

INSERT INTO libros (strISBN, strTitulo, strAutores, strEditorial, strMateria, intEstante, intExistencias, monPrecio) VALUES

('854471', 'Structureed Design', 'Edwar Yourdan', 'Prentice-Hall', 'Informática', 22, 5, 45.00::money),
('88125', 'Aplique el dBase III', 'Edward Hones', 'Mc. Graw-Hill', 'Informática', 22, 45, 26.00::money),
('821942', 'Descubro y acuso', 'Elisco Bayo', 'Plaza & Janés', 'Actualidad', 1, 20, 18.00::money),
('33258', 'Miguel Strogoff', 'Julio Verne', 'Bruguera', 'Aventuras', 4, 70, 5.00::money),
('06352', 'Problemas de Contabilidad', 'Leandro Cañibano', 'Anaya', 'Contabilidad', 15, 45, 32.00::money),
('7117', 'Plantas en el hogar', 'Jose Antonio Cañizo', 'Mundi-Prensa', 'Jardinería', 17, 4, 4.00::money);

-- INSERTAMOS LOS TRES MOSQUETEROS

INSERT INTO libros (strISBN, strTitulo, strAutores, strEditorial, strMateria, intEstante, intExistencias, monPrecio) 
VALUES ('1854', 'Los Tres Mosqueteros', 'Alejandro Dumas', 'Toray', 'Aventuras', 4, 36, 6.00::money);

-- MODIFICAR LAS EXISTENCIAS DEL LIBRO APLIQUE EL DBASE III A 25

UPDATE libros SET intExistencias = 25 WHERE strTitulo = 'Aplique el dBase III';

-- MODIFICAR EL ISBN DEL LIBRO MIGUEL STROGOFF Y CAMBIARLO POR 369

UPDATE libros 
SET strISBN = '369' 
WHERE strTitulo = 'Miguel Strogoff';

-- MODIFICAR EL PRECIO DEL LIBRO LOS TRES MOSQUETEROS A 6.11

UPDATE libros
SET monPrecio = 6.11::money
WHERE strTitulo = 'Los Tres Mosqueteros';

-- AÑADIR EL LIBRO TRIBUTOS LOCALES Y MODIFICAR LOS PRECIOS DE STRUCTUREED DESIGN A 48, MIGUEL STROGOFF A 5.9, PLANTAS EN EL HOGAR A 7

-- AÑADIR LIBRO

INSERT INTO libros (strISBN, strTitulo, strAutores, strEditorial, strMateria, intEstante, intExistencias, monPrecio) 
VALUES ('4392', 'Tributos Locales', 'E. Lozano', 'Pirámide', 'Economía', 13, 32, 6.20::money);

-- CAMBIAR PRECIOS

UPDATE libros SET monPrecio = 48.00::money 	WHERE strTitulo = 'Structureed Design';
UPDATE libros SET monPrecio = 5.90::money 	WHERE strTitulo = 'Miguel Strogoff';
UPDATE libros SET monPrecio = 7.00::money 	WHERE strTitulo = 'Plantas en el hogar';

-- SE HAN RECIBIDO 10 LIBROS DEL LIBRO QUE EDITA PIRAMIDE. ACTUALIZA LAS EXISTENCIAS

UPDATE libros SET intExistencias = intExistencias + 10 WHERE strEditorial = 'Pirámide';

-- AÑADIR LOS SIGUIENTES LIBROS

INSERT INTO libros (strISBN, strTitulo, strAutores, strEditorial, strMateria, intEstante, intExistencias, monPrecio) 
VALUES 
('7614', 'DBase II Plus', 'Russel A. Stulz', 'Anaya', 'Informática', 22, 80, 13.00::money),
('3621', 'El enfermo imaginario', 'Moliere', 'Salvat', 'Novelas', 15, 39, 27.00::money),
('1976', '1984', 'George Orwell', 'Plaza & Janés', 'Novelas', 15, 15, 20.00::money),
('0742', 'Novelas Ejemplares', 'M. Cervantes', 'Publicidad', 'Literatura', 7, 25, 19.00::money),
('4371', 'Redes locales', 'R. Howlth', 'Pirámide', 'Informática', 20, 156, 26.00::money),
('451', 'Usted y la microinformática', 'Scot Kamins', 'Mc. Graw-Hill', 'Informática', 20, 18, 45.00::money);

-- SE HAN RECIBIDO 10 UNIDADES DE CADA LIBRO QUE EDITA PLAZA Y JANÉS. ACTUALIZAR EXISTENCIAS

UPDATE libros SET intExistencias = intExistencias + 10 WHERE strEditorial = 'Plaza & Janés';

-- MODIFICAR EL PRECIO DEL LIBRO USTED Y LA MICROINFORMATICA A 43

UPDATE libros SET monPrecio = 43.00::money WHERE strTitulo = 'Usted y la microinformática';

-- BUSCAR LOS LIBROS DE INFORMATICA

SELECT * FROM libros WHERE strMateria = 'Informática';

-- BUSCAR AQUELLOS LIBROS EDITADOS POR PIRAMIDE

SELECT * FROM libros WHERE strEditorial = 'Pirámide';

-- BUSCAR LOS LIBRFOS QUE SE ENCUNTRAN EN EL ESTANTE 15

SELECT * FROM libros WHERE intEstante = 15;

-- MODIFICAR EL ISBN DEL LIBRO TRIBUTOS LOCALES A 368

UPDATE libros SET strISBN = '368' WHERE strTitulo = 'Tributos Locales';

-- BUSCAR LOS LIBROS EDITADOS POR MC. GRAW-HILL

SELECT * FROM libros WHERE strEditorial = 'Mc. Graw-Hill';


-- SE DECIDE REDUCIR EN 3 EL PRECIO DE TODOS LOS LIBROS CUYO PRECIO SEA MAYOR DE 24. ACTUALIZAR LOS PRECIOS

UPDATE libros SET monPrecio = monPrecio - 3.00::money WHERE monPrecio > 24.00::money;

-- CAMBIAR LA MATERIA DE TODOS LOS LIBROS DE NOVELAS A CLÁSICOS

UPDATE libros SET strMateria = 'Clásicos' WHERE strMateria = 'Novelas';

-- CAMBIAR LOS LIBROS DEL ESTANTE 4 Y 7 AL ESTANTE 15

UPDATE libros SET intEstante = 15 WHERE intEstante IN (4,7);

-- BUSCA LOS LIBROS QUE EDITA PLAZA Y JANÉS

SELECT * FROM libros WHERE strEditorial = 'Plaza & Janés';

-- BUSCAR TODOS LOS LIBROS DE ECONOMIA

SELECT * FROM libros WHERE strMateria = 'Economía'



