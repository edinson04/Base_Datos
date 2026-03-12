CREATE DATABASE semillero_BD
GO
USE semillero_BD
GO

CREATE TABLE usuario(
idUsuario INT PRIMARY KEY,
claveUsuario VARCHAR(25),
tipoUsuario VARCHAR(25),
)

CREATE TABLE proyectos (
idProyecto INT PRIMARY KEY,
tituloProyecto VARCHAR(27),
duracionProyecto INT,
objetivoProyecto VARCHAR(255),
fechainicioProyecto DATE,
estadoProyecto VARCHAR(27)
)

CREATE TABLE semillero (
idSemillero INT PRIMARY KEY,
nombreSemillero VARCHAR(27),
fechacreacionSemillero DATE,
lineainvestigativaSemillero VARCHAR(27)
)

CREATE TABLE eventos (
idEvento INT PRIMARY KEY,
nombreEvento VARCHAR(27),
fechaEvento DATE,
lugarEvento VARCHAR(27),
tipoEvento VARCHAR(27),
nombreorganizadorEvento VARCHAR(27)
)

CREATE TABLE investigadores (
idInvestigador INT PRIMARY KEY,
nombreInvestigador VARCHAR(27),
rolInvestigador VARCHAR(27),
edadInvestigador INT,
generoInvestigador VARCHAR(20),
correoInvestigador VARCHAR(30),
numerocelularInvestigador VARCHAR(11),
nombreprogramaInvestigador VARCHAR(27),
idSemillero INT,
FOREIGN KEY (idSemillero) REFERENCES semillero(idSemillero)
)

CREATE TABLE reuniones (
idReunion INT PRIMARY KEY,
fechaReunion DATE,
horaReunion TIME,
lugarReunion VARCHAR(27),
enlaceReunion VARCHAR(70),
motivoReunion VARCHAR(70),
idInvestigador INT,
FOREIGN KEY (idInvestigador) REFERENCES investigadores(idInvestigador)
)

CREATE TABLE fases (
idFase INT PRIMARY KEY,
nombreFase VARCHAR(27),
duracionFase INT,
idProyecto INT,
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto)
)

CREATE TABLE actividades (
idActividad INT PRIMARY KEY,
nombreActividad VARCHAR(27),
duracionActividad INT,
fechaentregaActividad DATE,
idFase INT,
FOREIGN KEY (idFase) REFERENCES fases(idFase)
)

CREATE TABLE proyectos_investigadores (
idProyecto INT, idInvestigador INT,
PRIMARY KEY (idProyecto, idInvestigador),
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto),
FOREIGN KEY (idInvestigador) REFERENCES investigadores(idInvestigador)
)

CREATE TABLE eventos_proyectos (
idEvento INT, idProyecto INT,
PRIMARY KEY (idProyecto, idEvento),
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto),
FOREIGN KEY (idEvento) REFERENCES eventos(idEvento)
)

INSERT INTO usuario VALUES
(130, '130.000', 'administrador'),
(1281, 'liderana', 'lider'),
(2221, 'carlos', 'investigador')

INSERT INTO proyectos VALUES
(1, 'proyecto tic', 1, 'Hacelo bien pa que trin', '2026-02-01', 'terminado'),
(2, 'proyecto tac', 2, 'Hacelo bien pa que tran', '2026-02-10', 'en ejecucion'),
(3, 'proyecto toc', 2, 'Hacelo bien pa que tron', '2026-02-20', 'en ejecucion'),
(4, 'proyecto tec', 3, 'Hacelo bien pa que tren', '2026-03-17', 'terminado'),
(5, 'proyecto tuc', 4, 'Hacelo bien pa que trun', '2026-04-11', 'terminado')

INSERT INTO semillero VALUES
(1, 'investic', '2024-02-01', 'tecnologia'),
(2, 'innova', '2023-03-15', 'software'),
(3, 'dataLab', '2022-05-10', 'datos')

INSERT INTO eventos VALUES
(1, 'congreso tic', '2026-01-15', 'bogota', 'ponencia', 'universidad nacional'),
(2, 'feria innovacion', '2026-02-10', 'medellin', 'exposicion', 'minciencias'),
(3, 'simposio tech', '2026-01-25', 'cali', 'ponencia', 'universidad valle'),
(4, 'foro digital', '2026-03-05', 'bogota', 'conferencia', 'ministerio tic')

INSERT INTO investigadores VALUES
(1, 'ana lopez', 'lider', 28, 'femenino', 'ana@gmail.com', '3001112233', 'ingenieria sistemas', 1),
(2, 'carlos perez', 'integrante', 22, 'masculino', 'carlos@gmail.com', '3002223344', 'ingenieria sistemas', 1),
(3, 'maria gomez', 'integrante', 25, 'femenino', 'maria@gmail.com', '3003334455', 'ingenieria software', 2),
(4, 'juan rojas', 'lider', 35, 'masculino', 'juan@gmail.com', '3004445566', 'ingenieria sistemas', 2),
(5, 'laura diaz', 'integrante', 27, 'femenino', 'laura@gmail.com', '3005556677', 'ciencia datos', 3)

INSERT INTO reuniones VALUES
(1, '2026-02-05', '10:00:00', 'sala 1', 'https://meet1.com', 'avance proyecto', 1),
(2, '2026-02-12', '14:00:00', 'sala 2', 'https://meet2.com', 'revision actividades', 2),
(3, '2026-02-18', '09:00:00', 'sala 3', 'https://meet3.com', 'planeacion fase', 3)

INSERT INTO fases VALUES
(1, 'analisis', 1, 1),
(2, 'desarrollo', 2, 1),
(3, 'pruebas', 1, 2),
(4, 'implementacion', 1, 3),
(5, 'evaluacion', 1, 4)

INSERT INTO actividades VALUES
(1, 'recoleccion datos', 5, '2026-02-05', 1),
(2, 'diseno sistema', 7, '2026-02-10', 1),
(3, 'programacion', 10, '2026-02-15', 2),
(4, 'testing', 6, '2026-02-18', 3),
(5, 'documentacion', 4, '2026-03-01', 4)

INSERT INTO proyectos_investigadores VALUES
(1,1),
(1,2),
(2,3),
(2,4),
(3,5),
(4,1),
(5,2)

INSERT INTO eventos_proyectos VALUES
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