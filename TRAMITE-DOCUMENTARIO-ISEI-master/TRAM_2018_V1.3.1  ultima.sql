create database bd_tramite_documentario;
use bd_tramite_documentario

create table adm_sistema
(
Id_Usuario int identity(1,1)primary key,
Nombres varchar(200),
Apellidos varchar(200),
Correo_Electronico varchar(200),
Usuario varchar(100)not null,
Contraseña varchar(100)not null,
Tipo_Administrador varchar(20)not null
)

create table areas 
(
Id_Area int identity primary key not null,
Codigo as 'AREA-' + REPLACE(STR(id_area, 5), ' ', '0'),
Nombre_Area varchar(100),
Encargardo_Area varchar(200) not null
)
create  table documento_externo
(
Numero_Correlativo int  identity(1,1),
Numero_Registro_MP text ,
Tipo_documento text,
Nro_Documento int,
Numero_Folio int,
Nombre_Tramitante varchar(50),
Dni_Tramitante varchar(8),
Asunto_Tramitante varchar(500),
Id_Area int,
Nombre_Area varchar(100),
Fecha_Registro date,
Estado varchar(20),
Observacion varchar(8000),
Imagen image,
primary key (Numero_Correlativo),
foreign key (Id_Area)references areas
)

create  table detalle_documento_externo
(
Numero_Respuesta_Externo int identity(1,1),
Numero_Correlativo int ,
Asunto varchar (200),
Derivar_Area varchar(200),
Fecha_Salida date ,
Descripcion varchar(500),
Estado varchar(20),
Observacion varchar(8000),
foreign key (Numero_Correlativo)references documento_externo
)

create  table documento_interno
(
Numero_Correlativo int  identity(1,1) primary key,
Numero_Registro_MP text ,
Tipo_documento text,
Nro_Documento int,
Numero_Folio int,
Nombre_Tramitante varchar(50),
Dni_Tramitante varchar(8),
Asunto_Tramitante varchar(500),
Id_Area int,
Nombre_Area varchar(100),
Fecha_Registro date,
Estado varchar(20),
Observacion varchar(8000),
Imagen image,
foreign key (Id_Area)references areas,
)


create  table detalle_documento_interno
(
Numero_Respuesta_Interno int identity(1,1) primary key,
Numero_Correlativo int ,
Asunto varchar(200),
Derivar_Area varchar(200) ,
Fecha_Salida date ,
Descripcion varchar(500),
Estado varchar(20),
Observacion varchar(8000),
foreign key (Numero_Correlativo)references documento_interno
)

insert into areas values('RECTORADO(R)','Juan Jose')
insert into areas values('VICE RECTORADO ACADEMICO (VRA)','Juan Jose')
insert into areas values('VICE RECTORADO DE INVESTIGACION','Juan Jose')
insert into areas values('OFICINA DE CONTROL INTERNO (OCI)','Juan Jose')
insert into areas values('OFICINA DE ASESORIA JURIDICA (AOJ)','Juan Jose')
insert into areas values('OFICINA DE IMAGEN INSTITUCIONAL (OII)','Juan Jose')
insert into areas values('OFICINA DE PLANIFICACION DE DESARROLLO UNIVERSITARIO (OPDU)','Juan Jose')
insert into areas values('OF. COOPERACION TECNICA Y RALACIONES UNIVERSITARIAS','Juan Jose')
insert into areas values('DIRECCION GENERAL DE ADMINISTRACION (GIGA)','Juan Jose')
insert into areas values('SUB DIRECCION DE CONTABILIDAD (SD. CONT.)','Juan Jose')
insert into areas values('SUB DIRECCION DE TESORERIA','Juan Jose')
insert into areas values('AREA CUENTAS POR COBRAR','Juan Jose')
insert into areas values('SUB DIRECCION DE LOGISTICA Y SERVICIOS GENERALES','Juan Jose')
insert into areas values('SUB DIRECCION DE PROYECTOS Y OBRAS','Juan Jose')
insert into areas values('SUB DIRECCION DE RECURSOS HUMANOS','Juan Jose')
insert into areas values('SUB DIRECCION DE PRODUCCIONES DE BIENES Y SERVICIOS','Juan Jose')
insert into areas values('DIRECCION  DE SERVICIOS ACADEMICOS','Juan Jose')
insert into areas values('SUB DIRECCION DE COMPUTO E INFORMATICA','Juan Jose')
insert into areas values('DIRECCION DE RESPONSABILIDAD SOCIAL','Juan Jose')
insert into areas values('BIBLIOTECA','Juan Jose')
insert into areas values('BIENESTAR UNIVERSITARIO','Juan Jose')
insert into areas values('GRADOS Y TITULOS','Juan Jose')
insert into areas values('TRIBUNAL DE HONOR','Juan Jose')
insert into areas values('CAJA','Juan Jose')
insert into areas values('DIRECCION DE LA ESCUELA DE PROSGRADO (EPG)','Juan Jose')
insert into areas values('DIRECCION DE LA ESCUELA DE PROSGRADO (EPG)','Juan Jose')
insert into areas values('FACULTAD DE CIENCIAS JURIDICAS, CONTABLES Y SOCIALES','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE DERECHO','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE CONTABILIDAD','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE EDUCACION','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE TURISMO, HOTELERIA Y GASTRONOMIA)','Juan Jose')
insert into areas values('FACULTAD DE CIENCIAS DE LA SALUD','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE ENFERMERIA','Juan Jose')
insert into areas values('FACULTAD DE INGENIERIA','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE AGRONOMIA','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE INGENIERIA AMBIENTAL Y RECURSOS NATURALES','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE INGENIERIA CIVIL','Juan Jose')
insert into areas values('ESCUELA PROFECIONAL DE INGENIERIA DE SISTEMAS E INFORMATICA)','Juan Jose')
insert into areas values('OFICINA DE TECNOLOGIA E INFORMATICA (OTI)','Juan Jose')

SELECT*FROM areas


Insert into documento_interno values('0044','Solicitud N° 0800230','01','Guillermo Montaño Delgado','75648545','Solicito revisión del examen del curso de física I','38','ESCUELA PROFECIONAL DE INGENIERIA DE SISTEMAS E INFORMATICA','05/12/2018','Revisado','Ninguna','')
Insert into documento_interno values('','Memorando N° 026-2018-UTEA-FI','15','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. no procede la solicitud de los estudiantes','13','SUB DIRECCION DE LOGISTICA Y SERVICIOS GENERALES','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('0044','Solicitud N° 0800230','01','Guillermo Montaño Delgado','75648545','Solicito revisión del examen del curso de física I','38','ESCUELA PROFECIONAL DE INGENIERIA DE SISTEMAS E INFORMATICA','05/12/2018','Revisado','Ninguna','')
Insert into documento_interno values('','Memorando N° 026-2018-UTEA-FI','15','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. no procede la solicitud de los estudiantes','13','SUB DIRECCION DE LOGISTICA Y SERVICIOS GENERALES','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('0044','Solicitud N° 0800230','01','Guillermo Montaño Delgado','75648545','Solicito revisión del examen del curso de física I','38','ESCUELA PROFECIONAL DE INGENIERIA DE SISTEMAS E INFORMATICA','05/12/2018','Revisado','Ninguna','')
Insert into documento_interno values('','Memorando N° 026-2018-UTEA-FI','15','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. no procede la solicitud de los estudiantes','13','SUB DIRECCION DE LOGISTICA Y SERVICIOS GENERALES','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('0044','Solicitud N° 0800230','01','Guillermo Montaño Delgado','75648545','Solicito revisión del examen del curso de física I','38','ESCUELA PROFECIONAL DE INGENIERIA DE SISTEMAS E INFORMATICA','05/12/2018','Revisado','Ninguna','')
Insert into documento_interno values('','Memorando N° 026-2018-UTEA-FI','15','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. no procede la solicitud de los estudiantes','13','SUB DIRECCION DE LOGISTICA Y SERVICIOS GENERALES','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('0044','Solicitud N° 0800230','01','Guillermo Montaño Delgado','75648545','Solicito revisión del examen del curso de física I','38','ESCUELA PROFECIONAL DE INGENIERIA DE SISTEMAS E INFORMATICA','05/12/2018','Revisado','Ninguna','')
Insert into documento_interno values('Informe 475-56 G.T','Resolución Decanal N° 1206-2018-UTEA-FI','02','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. no procede la solicitud de los estudiantes','13','SUB DIRECCION DE LOGISTICA Y SERVICIOS GENERALES','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('Informe 477-56 G.T','Resolución Decanal N° 1207-2018-UTEA-FI','20','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. s','22','GRADOS Y TITULOS','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('Informe 511-56 G.T','Resolución Decanal N° 1230-2018-UTEA-FI','21','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. ','22','GRADOS Y TITULOS','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('Informe 05-56 G.T','Resolución Decanal N° 011-2018-UTEA-FI','12','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco. ','22','GRADOS Y TITULOS','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('Informe 12-56 G.T','Resolución Decanal N° 054-2018-UTEA-FI','14','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco.','22','GRADOS Y TITULOS','04/01/2018','Revisado','Ninguna','')
Insert into documento_interno values('Informe 15-56 G.T','Resolución Decanal N° 057-2018-UTEA-FI','14','Roxana Meza Aparicio','30254154','Devuelvo expedientes de prorrateo de la filial cusco.','22','GRADOS Y TITULOS','05/01/2018','Revisado','Ninguna','')

select*from documento_interno

--PROCEDIMIENTOS ALMACENADO PARA REPORTES DEL TRAMITE DOCUMENTARIO

--Procedimiento para mostrar documentos internos por area
create proc sp_documentointernoporarea
@area varchar(100)
as
select Numero_Registro_MP ,Nro_Documento, Tipo_documento,Numero_Folio ,Nombre_Tramitante,Dni_Tramitante,Asunto_Tramitante,Nombre_Area ,
		Fecha_Registro,Estado
from documento_interno
where Nombre_Area=@area
go

--Procedimiento para mostrar documentos externos por area
Create proc sp_documentoexternoporarea
@area varchar(100)
as
select Numero_Registro_MP ,Nro_Documento, Tipo_documento,Numero_Folio ,Nombre_Tramitante,Dni_Tramitante,Asunto_Tramitante,Nombre_Area ,
		Fecha_Registro,Estado
from documento_externo
where Nombre_Area=@area
go

--Procedimiento Almacenado Para Buscar documentos INTERNOS por fechas
create proc sp_reportededcomentosINTERporfechas
@FechaInicio date,
@FechaFin date
as
select*from documento_interno
where Fecha_Registro between @FechaInicio and @FechaFin

EXEC sp_reportededcomentosINTERporfechas '05/12/2018','05/12/2018'

--Procedimiento Almacenado Para Buscar documentos EXTERNOS por fechas
create proc sp_reportededcomentosEXTERporfechas
@FechaInicio date,
@FechaFin date
as
select*from documento_externo
where Fecha_Registro between @FechaInicio and @FechaFin


--Procedimiento almacenado para ver que documento llega mas a un area
Create proc sp_documencontarporareas
as
select nombre_tramitante,dni_tramitante,asunto_tramitante,nombre_area,count(nombre_area) as Total 
from documento_interno
group by  nombre_tramitante,dni_tramitante,asunto_tramitante,nombre_area, fecha_registro,estado
go

EXEC sp_documencontarporareas

































