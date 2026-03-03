Create database semillero_BD
use semillero_BD



create table usuario(
idUsuario int primary key,
nombreUsuario varchar (25),
tipoUsuario varchar (25),
emailUsuario varchar (30)
)

create table investigadores(
idInvestigadores int primary key,
nombreInvestigador varchar (25),
tipoInvestigador varchar (25),
telefonoInvestigador numeric,
emailInvestigador varchar (25),
idUsuario int,
idSemillero int,
foreign key (idUsuario) references usuario(idUsuario),
foreign key (idSemillero) references semillero(idSemillero) 
)

create table semillero(
idSemillero int primary key,
nombreSemillero varchar (25),
fechaCreacionSemillero date,
)

