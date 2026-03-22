CREATE DATABASE semillero_BD
GO
USE Semillero_BD
GO

CREATE TABLE Usuario(
idUsuario VARCHAR(11) PRIMARY KEY,
claveUsuario VARCHAR(255) NOT NULL,
tipoUsuario VARCHAR(25) NOT NULL
)

CREATE TABLE Proyectos (
idProyecto INT IDENTITY(1,1) PRIMARY KEY,
tituloProyecto VARCHAR(27) NOT NULL,
duracionMesesProyecto INT NOT NULL,
objetivoProyecto VARCHAR(255) NOT NULL,
fechainicioProyecto DATE NOT NULL,
estadoProyecto VARCHAR(27) NOT NULL
)

CREATE TABLE Semillero (
idSemillero INT IDENTITY(1,1) PRIMARY KEY,
nombreSemillero VARCHAR(27) NOT NULL,
fechacreacionSemillero DATE NOT NULL,
lineainvestigativaSemillero VARCHAR(27) NOT NULL
)

CREATE TABLE Eventos (
idEvento INT IDENTITY(1,1) PRIMARY KEY,
nombreEvento VARCHAR(27) NOT NULL,
fechaEvento DATE NOT NULL,
lugarEvento VARCHAR(27) NOT NULL,
tipoEvento VARCHAR(27) NOT NULL,
nombreorganizadorEvento VARCHAR(27) NOT NULL
)

CREATE TABLE Investigadores (
idInvestigador INT IDENTITY(1,1) PRIMARY KEY,
cedulaInvestigador VARCHAR(11) NOT NULL,
nombreInvestigador VARCHAR(27) NOT NULL,
rolInvestigador VARCHAR(27) NOT NULL,
fechanacimientoInvestigador DATE NOT NULL,
generoInvestigador VARCHAR(20) NOT NULL,
correoInvestigador VARCHAR(30) NOT NULL,
numerocelularInvestigador VARCHAR(11) NOT NULL,
nombreprogramaInvestigador VARCHAR(27) NOT NULL,
idSemillero INT NOT NULL,
idUsuario VARCHAR(11),
FOREIGN KEY (idSemillero) REFERENCES semillero(idSemillero),
FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
)

CREATE TABLE Reuniones (
idReunion INT IDENTITY(1,1) PRIMARY KEY,
fechaReunion DATE NOT NULL,
horaReunion TIME NOT NULL,
lugarReunion VARCHAR(27) NOT NULL,
enlaceReunion VARCHAR(70) NOT NULL,
motivoReunion VARCHAR(70) NOT NULL,
idInvestigador INT NOT NULL,
FOREIGN KEY (idInvestigador) REFERENCES investigadores(idInvestigador)
)

CREATE TABLE Fases (
idFase INT IDENTITY(1,1) PRIMARY KEY,
nombreFase VARCHAR(27) NOT NULL,
duracionFase INT NOT NULL,
idProyecto INT NOT NULL,
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto)
)

CREATE TABLE Actividades (
idActividad INT IDENTITY(1,1) PRIMARY KEY,
nombreActividad VARCHAR(27) NOT NULL,
duraciondiasActividad INT NOT NULL,
fechaentregaActividad DATE NOT NULL,
idFase INT NOT NULL,
FOREIGN KEY (idFase) REFERENCES fases(idFase)
)

CREATE TABLE Proyectos_investigadores (
idProyecto INT NOT NULL, idInvestigador INT NOT NULL,
PRIMARY KEY (idProyecto, idInvestigador),
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto),
FOREIGN KEY (idInvestigador) REFERENCES investigadores(idInvestigador)
)

CREATE TABLE Eventos_proyectos (
idEvento INT NOT NULL, idProyecto INT NOT NULL,
PRIMARY KEY (idProyecto, idEvento),
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto),
FOREIGN KEY (idEvento) REFERENCES eventos(idEvento)
)

INSERT INTO Usuario VALUES
('1001234567', 'hash_admin', 'Administrador'),
('1002345678', 'hash_lider1', 'Lider'),
('1003456789', 'hash_lider2', 'Lider'),
('1004567890', 'hash_user1', 'Integrante')


INSERT INTO Proyectos VALUES
('proyecto tic', 1, 'Hacelo bien pa que trin', '2026-02-01', 'terminado'),
('proyecto tac', 2, 'Hacelo bien pa que tran', '2026-02-10', 'en ejecucion'),
('proyecto toc', 2, 'Hacelo bien pa que tron', '2026-02-20', 'en ejecucion'),
('proyecto tec', 3, 'Hacelo bien pa que tren', '2026-03-17', 'terminado'),
('proyecto tuc', 4, 'Hacelo bien pa que trun', '2026-04-11', 'terminado')

INSERT INTO Semillero VALUES
('investic', '2024-02-01', 'tecnologia'),
('innova', '2023-03-15', 'software'),
('dataLab', '2022-05-10', 'datos')

INSERT INTO Eventos VALUES
('congreso tic', '2026-01-15', 'bogota', 'ponencia', 'universidad nacional'),
('feria innovacion', '2026-02-10', 'medellin', 'exposicion', 'minciencias'),
('simposio tech', '2026-01-25', 'cali', 'ponencia', 'universidad valle'),
('foro digital', '2026-03-05', 'bogota', 'conferencia', 'ministerio tic')

INSERT INTO Investigadores VALUES
('1002345678', 'Ana Lopez', 'lider', '1995-04-12', 'femenino', 'ana@soy.sena.edu.co', '3001112233', 'Ingenieria Sistemas', 1, '1002345678'),
('1003456789', 'Juan Rojas', 'lider', '1990-09-30', 'masculino', 'juan@soy.sena.edu.edu.co', '3004445566', 'Ingenieria Sistemas', 2, '1003456789'),
('1004567890', 'Carlos Perez', 'integrante', '2001-07-25', 'masculino', 'carlos@soy.sena.edu.co', '3002223344', 'Ingenieria Software', 1, '1004567890'),
('1005678901', 'Maria Gomez', 'integrante', '2000-03-18', 'femenino', 'maria@soy.sena.edu.co', '3003334455', 'Ciencia de Datos', 3, NULL),
('1006789012', 'Luis Torres', 'integrante', '2002-11-05', 'masculino', 'luis@soy.sena.edu.co', '3005556677', 'Ingenieria Sistemas', 1, NULL)

INSERT INTO Reuniones VALUES
('2026-02-05', '10:00:00', 'sala 1', 'https://meet1.com', 'avance proyecto', 1),
('2026-02-12', '14:00:00', 'sala 2', 'https://meet2.com', 'revision actividades', 2),
('2026-02-18', '09:00:00', 'sala 3', 'https://meet3.com', 'planeacion fase', 3)

INSERT INTO Fases VALUES
('analisis', 1, 1),
('desarrollo', 2, 1),
('pruebas', 1, 2),
('implementacion', 1, 3),
('evaluacion', 1, 4)

INSERT INTO Actividades VALUES
('recoleccion datos', 5, '2026-02-05', 1),
('diseno sistema', 7, '2026-02-10', 1),
('programacion', 10, '2026-02-15', 2),
('testing', 6, '2026-02-18', 3),
('documentacion', 4, '2026-03-01', 4)

INSERT INTO Proyectos_investigadores VALUES
(1,1),
(1,2),
(2,3),
(2,4),
(3,5),
(4,1),
(5,2)

INSERT INTO Eventos_proyectos VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(1,5)


-- 1. Mostrar titulo y estado del proyecto, cuya fecha de  inicio este entre el 1 de febrero del 2026 y el 25 de febrero del 2026 junto con el nombre del semillero al que pertenece y el nombre de los investigadores que lo integran

-- 2. Mostrar el rol de tipo lider de los investigadores del semillero investic, junto con los titulos de proyectos que esten en estado finalizado

-- 3. Mostrar la mayor edad de los investigadores de tipo integrantes que sean mujeres y los nombres de los semilleros al que pertenecen

-- 4. Mostrar la cantidad de fases y la cantidad de actividades que tiene el proyecto de titulo proyecto tic

-- 5. Mostrar los nombres de los proyectos, fases de aquellos proyectos con actividades cuya fecha de entrega este entre el 1 de febrero y el 18 de febrero del 2026

-- 6. Mostrar la fecha de finalizacion de los proyectos con estado en ejecucion cuya duracion del proyecto sea de dos meses

-- 7. Mostrar el nombre del evento, organizador y fecha en el que participa el proyecto de nombre desarrollo e innovacion, junto con la cantidad de investigadores que tiene ese proyecto

-- 8. Mostrar los nombres de los eventos con fecha entre 1 y 30 de enero de 2026 de los proyectos de tipo ponencia junto con los nombres de los proyectos relacionados con el rol de investigador

-- 9. Mostrar los nombres de los investigadores que sean mayor de edad de genero masculino, el nombre del proyecto al que pertenece y el tipo de evento en el que ha participado