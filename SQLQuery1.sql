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
cedulaInvestigador VARCHAR(11) PRIMARY KEY NOT NULL,
nombreInvestigador VARCHAR(27) NOT NULL,
rolInvestigador VARCHAR(27) NOT NULL,
fechanacimientoInvestigador DATE NOT NULL,
generoInvestigador VARCHAR(20) NOT NULL,
correoInvestigador VARCHAR(30) NOT NULL,
numerocelularInvestigador VARCHAR(11) NOT NULL,
nombreprogramaInvestigador VARCHAR(27) NOT NULL,
idSemillero INT NOT NULL,
FOREIGN KEY (idSemillero) REFERENCES semillero(idSemillero),
)

CREATE TABLE Reuniones (
idReunion INT IDENTITY(1,1) PRIMARY KEY,
fechaReunion DATE NOT NULL,
horaReunion TIME NOT NULL,
lugarReunion VARCHAR(27) NOT NULL,
enlaceReunion VARCHAR(70) NOT NULL,
motivoReunion VARCHAR(70) NOT NULL,
cedulaInvestigador VARCHAR(11) NOT NULL,
FOREIGN KEY (cedulaInvestigador) REFERENCES Investigadores(cedulaInvestigador)
)

CREATE TABLE Fases (
idFase INT IDENTITY(1,1) PRIMARY KEY,
nombreFase VARCHAR(27) NOT NULL,
duracionFaseMeses INT NOT NULL,
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
idProyecto INT NOT NULL, cedulaInvestigador VARCHAR(11) NOT NULL,
PRIMARY KEY (idProyecto, cedulaInvestigador),
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto),
FOREIGN KEY (cedulaInvestigador) REFERENCES Investigadores(cedulaInvestigador)
)

CREATE TABLE Eventos_proyectos (
idEvento INT NOT NULL, idProyecto INT NOT NULL,
PRIMARY KEY (idProyecto, idEvento),
FOREIGN KEY (idProyecto) REFERENCES proyectos(idProyecto),
FOREIGN KEY (idEvento) REFERENCES eventos(idEvento)
)

INSERT INTO Usuario VALUES
('1001234567', 'clave admin', 'Administrador'),
('1002345678', 'clave lider investic', 'Lider'),
('1003456789', 'clave lider innova', 'Lider'),
('1009876543', 'clave lider datalab', 'Lider'),
('1004567890', 'clave integrante investic1', 'integrante'),
('1009012345', 'clave integrante innova1', 'integrante'),
('1013456789', 'clave integrante datalab1', 'integrante')

INSERT INTO Proyectos VALUES
('proyecto tic', 1, 'Hacelo bien pa que trin', '2026-02-01', 'en ejecucion'),
('proyecto tac', 2, 'Hacelo bien pa que tran', '2026-02-10', 'en ejecucion'),
('proyecto toc', 2, 'Hacelo bien pa que tron', '2026-02-20', 'en ejecucion'),
('proyecto tec', 3, 'Hacelo bien pa que tren', '2026-03-17', 'en ejecucion'),
('proyecto tuc', 4, 'Hacelo bien pa que trun', '2026-04-11', 'en ejecucion')

INSERT INTO Semillero VALUES
('investic', '2024-02-01', 'tecnologia'),
('innova', '2023-03-15', 'software'),
('datalab', '2022-05-10', 'datos')

INSERT INTO Eventos VALUES
('congreso tic', '2026-01-15', 'bogota', 'ponencia', 'universidad nacional'),
('feria innovacion', '2026-02-10', 'medellin', 'exposicion', 'minciencias'),
('simposio tech', '2026-01-25', 'cali', 'ponencia', 'universidad valle'),
('foro digital', '2026-03-05', 'bogota', 'conferencia', 'ministerio tic')

INSERT INTO Investigadores VALUES

('1002345678', 'Ana Lopez', 'Lider', '1995-04-12', 'Femenino', 'ana@soy.sena.edu.co', '3001112233', 'Ing Sistemas', 1),
('1004567890', 'Carlos Perez', 'Integrante', '2001-07-25', 'Masculino', 'carlos@soy.sena.edu.co', '3002223344', 'Ing Software', 1),
('1006789012', 'Luis Torres', 'Integrante', '2002-11-05', 'Masculino', 'luis@soy.sena.edu.co', '3005556677', 'Ing Sistemas', 1),
('1007890123', 'Andres Ruiz', 'Integrante', '2000-01-10', 'Masculino', 'andres@soy.sena.edu.co', '3007778899', 'Ing Sistemas', 1),
--('1008901234', 'Sofia Martinez', 'Integrante', '2001-05-21', 'Femenino', 'sofia@soy.sena.edu.co', '3008889900', 'Ing Software', 1),

('1003456789', 'Juan Rojas', 'Lider', '1990-09-30', 'Masculino', 'juan@soy.sena.edu.co', '3004445566', 'Ing Sistemas', 2),
('1009012345', 'Maria Gomez', 'Integrante', '2000-03-18', 'Femenino', 'maria@soy.sena.edu.co', '3003334455', 'Ciencia Datos', 2),
('1010123456', 'Pedro Castillo', 'Integrante', '1999-12-12', 'Masculino', 'pedro@soy.sena.edu.co', '3011112233', 'Ing Software', 2),
('1011234567', 'Laura Diaz', 'Integrante', '2002-06-14', 'Femenino', 'laura@soy.sena.edu.co', '3012223344', 'Ing Software', 2),
--('1012345678', 'David Herrera', 'Integrante', '2001-08-08', 'Masculino', 'david@soy.sena.edu.co', '3013334455', 'Ing Sistemas', 2),

('1009876543', 'Camilo Vargas', 'Lider', '1993-02-20', 'Masculino', 'camilo@soy.sena.edu.co', '3021112233', 'Ciencia Datos', 3),
('1013456789', 'Natalia Ruiz', 'Integrante', '2000-10-11', 'Femenino', 'natalia@soy.sena.edu.co', '3022223344', 'Ciencia Datos', 3),
('1014567890', 'Diego Peña', 'Integrante', '1998-03-03', 'Masculino', 'diego@soy.sena.edu.co', '3023334455', 'Ciencia Datos', 3),
('1015678901', 'Valeria Castro', 'Integrante', '2001-09-09', 'Femenino', 'valeria@soy.sena.edu.co', '3024445566', 'Analitica Datos', 3)
--('1016789012', 'Jorge Pineda', 'Integrante', '1999-07-07', 'Masculino', 'jorge@soy.sena.edu.co', '3025556677', 'Ciencia Datos', 3)


INSERT INTO Reuniones VALUES
('2026-02-05', '10:00', 'Sala 1', 'https://meet.google.com/a1', 'Inicio proyecto TIC','1002345678'),
('2026-02-15', '14:00', 'Sala 2', 'https://meet.google.com/a2', 'Inicio proyecto TAC','1002345678'),

('2026-02-12', '09:00', 'Sala 3', 'https://meet.google.com/b1', 'Planeacion proyecto TOC','1003456789'),
('2026-02-20', '11:00', 'Sala 4', 'https://meet.google.com/b2', 'Revis','1003456789'),

('2026-03-01', '08:00', 'Sala 5', 'https://meet.google.com/c1', 'Analisis de datos inicial','1009876543');

INSERT INTO Fases VALUES
('Analisis', 1, 1),
('Diseño', 1, 1),
('Desarrollo', 2, 1),

('Analisis', 1, 2),
('Desarrollo', 2, 2),

('Analisis de datos', 1, 3),
('Modelado', 2, 3),

('Implementacion', 1, 4),
('Pruebas', 1, 4),

('Planeacion', 1, 5),
('Ejecucion', 2, 5);

INSERT INTO Actividades VALUES
('Levantamiento de requisitos', 5, '2026-02-05', 1),
('Analisis de usuarios', 4, '2026-02-07', 1),

('Diseño de arquitectura', 6, '2026-02-12', 2),

('Desarrollo backend', 10, '2026-02-20', 3),
('Desarrollo frontend', 8, '2026-02-22', 3),

('Analisis inicial', 5, '2026-02-11', 4),
('Programacion', 10, '2026-02-25', 5),

('Recoleccion datos', 6, '2026-02-18', 6),
('Entrenamiento modelo', 10, '2026-02-28', 7),

('Despliegue sistema', 4, '2026-03-05', 8),
('Pruebas funcionales', 5, '2026-03-08', 9),

('Planificacion', 3, '2026-04-12', 10),
('Ejecucion tareas', 8, '2026-04-20', 11);

INSERT INTO Proyectos_investigadores 
SELECT 1, cedulaInvestigador FROM Investigadores WHERE idSemillero = 1
INSERT INTO Proyectos_investigadores 
SELECT 2, cedulaInvestigador FROM Investigadores WHERE idSemillero = 1
INSERT INTO Proyectos_investigadores 
SELECT 3, cedulaInvestigador FROM Investigadores WHERE idSemillero = 2
INSERT INTO Proyectos_investigadores 
SELECT 4, cedulaInvestigador FROM Investigadores WHERE idSemillero = 2
INSERT INTO Proyectos_investigadores 
SELECT 5, cedulaInvestigador FROM Investigadores WHERE idSemillero = 3

INSERT INTO Eventos_proyectos VALUES
(1,1), 
(2,2), 
(3,3), 
(4,4), 
(1,5), 
(2,3)
