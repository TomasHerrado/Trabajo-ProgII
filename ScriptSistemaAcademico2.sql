USE [Sistema_Academico2]
GO
/****** Object:  Table [dbo].[Calificaciones]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calificaciones](
	[id_calificacion] [int] IDENTITY(1,1) NOT NULL,
	[nota] [int] NULL,
	[id_tipo_nota] [int] NULL,
	[id_inscripcion] [int] NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [pk_calificacion] PRIMARY KEY CLUSTERED 
(
	[id_calificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[nombre_carrera] [varchar](150) NULL,
	[descripcion] [varchar](300) NULL,
	[duracion] [varchar](100) NULL,
	[titulo_otorgado] [varchar](200) NULL,
 CONSTRAINT [pk_carrera] PRIMARY KEY CLUSTERED 
(
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Catedras]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catedras](
	[id_catedra] [int] IDENTITY(1,1) NOT NULL,
	[nombre_catedra] [varchar](100) NULL,
	[id_horario] [int] NULL,
	[id_materia] [int] NULL,
	[id_docente] [int] NULL,
	[id_comision] [int] NULL,
	[año] [varchar](10) NULL,
	[cuatrimestre] [varchar](100) NULL,
 CONSTRAINT [pk_catedras] PRIMARY KEY CLUSTERED 
(
	[id_catedra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comisiones]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comisiones](
	[id_comision] [int] IDENTITY(1,1) NOT NULL,
	[nombre_comision] [varchar](200) NULL,
 CONSTRAINT [pk_comision] PRIMARY KEY CLUSTERED 
(
	[id_comision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Examen]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Examen](
	[id_detalle_examen] [int] IDENTITY(1,1) NOT NULL,
	[id_examen_final] [int] NULL,
	[id_estudiante] [int] NULL,
	[nota] [int] NULL,
 CONSTRAINT [pk_detalleExamen] PRIMARY KEY CLUSTERED 
(
	[id_detalle_examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docentes]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docentes](
	[id_docente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_docente] [varchar](50) NULL,
	[apellido_docente] [varchar](50) NULL,
	[fec_nac] [datetime] NULL,
	[dni] [int] NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [int] NULL,
	[email] [varchar](100) NULL,
 CONSTRAINT [pk_docentes] PRIMARY KEY CLUSTERED 
(
	[id_docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados_Materias]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados_Materias](
	[id_estado_materia] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado_materia] [varchar](100) NULL,
 CONSTRAINT [pk_estado_materia] PRIMARY KEY CLUSTERED 
(
	[id_estado_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante_Carrera]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante_Carrera](
	[id_estudiante_carrera] [int] IDENTITY(1,1) NOT NULL,
	[id_estudiante] [int] NULL,
	[id_carrera] [int] NULL,
 CONSTRAINT [pk_estudiante_carrera] PRIMARY KEY CLUSTERED 
(
	[id_estudiante_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[id_estudiante] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estudiante] [varchar](100) NULL,
	[apellido_estudiante] [varchar](100) NULL,
	[fecha_nac] [datetime] NULL,
	[dni] [int] NULL,
	[direccion] [varchar](500) NULL,
	[telefono] [int] NULL,
	[email] [varchar](200) NULL,
	[estado_civil] [varchar](50) NULL,
	[situacion_habitacional] [varchar](100) NULL,
	[situacion_laboral] [varchar](100) NULL,
 CONSTRAINT [pk_estudiantes] PRIMARY KEY CLUSTERED 
(
	[id_estudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examen_Final]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen_Final](
	[id_examen_final] [int] IDENTITY(1,1) NOT NULL,
	[turno] [varchar](100) NULL,
	[fecha_examen] [datetime] NULL,
	[id_docente] [int] NULL,
	[id_materia] [int] NULL,
 CONSTRAINT [pk_examen_final] PRIMARY KEY CLUSTERED 
(
	[id_examen_final] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horarios](
	[id_horario] [int] IDENTITY(1,1) NOT NULL,
	[dia_semana] [varchar](100) NULL,
	[hora_inicio] [varchar](100) NULL,
	[hora_fin] [varchar](100) NULL,
	[aula] [int] NULL,
 CONSTRAINT [pk_horarios] PRIMARY KEY CLUSTERED 
(
	[id_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion_Carrera]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion_Carrera](
	[id_inscripcion_carrera] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Inscripcion] [datetime] NULL,
	[id_estudiante] [int] NULL,
	[id_carrera] [int] NULL,
 CONSTRAINT [pk_inscripcion_carrera] PRIMARY KEY CLUSTERED 
(
	[id_inscripcion_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion_Materias]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion_Materias](
	[id_inscripcion] [int] IDENTITY(1,1) NOT NULL,
	[id_catedra] [int] NULL,
	[id_estudiante] [int] NULL,
	[fecha] [datetime] NULL,
	[id_estado_materia] [int] NULL,
 CONSTRAINT [pk_id_inscripcion] PRIMARY KEY CLUSTERED 
(
	[id_inscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[nombre_materia] [varchar](100) NULL,
	[id_carrera] [int] NULL,
 CONSTRAINT [pk_materias] PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Notas]    Script Date: 19/11/2023 19:58:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Notas](
	[id_tipo_nota] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_tipo] [varchar](100) NULL,
 CONSTRAINT [pk_tipo_nota] PRIMARY KEY CLUSTERED 
(
	[id_tipo_nota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Calificaciones] ON 
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (1, 8, 1, 1, CAST(N'2023-05-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (2, 9, 2, 2, CAST(N'2023-07-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (3, 6, 3, 3, CAST(N'2023-04-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (4, 7, 4, 4, CAST(N'2023-03-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (5, 8, 5, 5, CAST(N'2023-09-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (6, 5, 1, 1, CAST(N'2023-05-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (7, 7, 2, 2, CAST(N'2023-07-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (8, 4, 3, 3, CAST(N'2023-04-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (9, 6, 4, 4, CAST(N'2023-03-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Calificaciones] ([id_calificacion], [nota], [id_tipo_nota], [id_inscripcion], [fecha]) VALUES (10, 9, 5, 5, CAST(N'2023-09-05T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Calificaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Carreras] ON 
GO
INSERT [dbo].[Carreras] ([id_carrera], [nombre_carrera], [descripcion], [duracion], [titulo_otorgado]) VALUES (1, N'Tecnicatura Universitaria en Programación', N'Carrera enfocada en el desarrollo de software y sistemas informáticos.', N'2 años', N'Técnico en Programación')
GO
INSERT [dbo].[Carreras] ([id_carrera], [nombre_carrera], [descripcion], [duracion], [titulo_otorgado]) VALUES (2, N'Tecnicatura Universitaria en Industrias Alimentarias', N'Carrera que ofrece conocimientos tecnologicos sobre produccion alimentaria y controles de calidad.', N'2 años', N'Técnico en Industrias Alimentarias')
GO
INSERT [dbo].[Carreras] ([id_carrera], [nombre_carrera], [descripcion], [duracion], [titulo_otorgado]) VALUES (3, N'Tecnicatura Universitaria en Mecatrónica', N'Carrera que tiene como fin la aplicación de las últimas técnicas en la ingeniería mecánica de precisión, electrónica, teoría de control y ciencias de la computación.', N'2 años', N'Técnico en Mecatrónica')
GO
INSERT [dbo].[Carreras] ([id_carrera], [nombre_carrera], [descripcion], [duracion], [titulo_otorgado]) VALUES (4, N'Tecnicatura Universitaria en Telecomunicaciones', N'Carrera que brinda el conocimiento para realizar las tareas técnicas y gestiones requeridas por el área de las Telecomunicaciones.', N'2 años', N'Técnico en Telecomunicaciones')
GO
INSERT [dbo].[Carreras] ([id_carrera], [nombre_carrera], [descripcion], [duracion], [titulo_otorgado]) VALUES (5, N'Tecnicatura Universitaria en Mantenimiento Industrial', N'Carrera que busca formar un técnico acorde a las actuales necesidades de nuestra industria', N'2 años', N'Técnico en Mantenimiento Industrial')
GO
SET IDENTITY_INSERT [dbo].[Carreras] OFF
GO
SET IDENTITY_INSERT [dbo].[Catedras] ON 
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (1, N'Cátedra de Matemáticas', 1, 1, 1, 1, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (2, N'Cátedra de Estadistica', 2, 2, 2, 2, N'2023', N'Segundo Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (3, N'Cátedra de Inglés', 3, 3, 3, 3, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (4, N'Cátedra de Programación', 4, 4, 4, 4, N'2023', N'Segundo Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (5, N'Cátedra de Laboratorio de Computacion', 5, 5, 5, 5, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (6, N'Cátedra de Matemáticas', 1, 1, 1, 2, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (7, N'Cátedra de Estadistica', 2, 2, 2, 3, N'2023', N'Segundo Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (8, N'Cátedra de Inglés', 3, 3, 3, 4, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (9, N'Cátedra de Programación', 4, 4, 4, 5, N'2023', N'Segundo Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (10, N'Cátedra de Laboratorio de Computacion', 5, 5, 5, 1, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (11, N'Cátedra de Matemáticas', 1, 1, 1, 1, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (12, N'Cátedra de Estadistica', 2, 2, 2, 2, N'2023', N'Segundo Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (13, N'Cátedra de Inglés', 3, 3, 3, 3, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (14, N'Cátedra de Programación', 4, 4, 4, 4, N'2023', N'Segundo Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (15, N'Cátedra de Laboratorio de Computacion', 5, 5, 5, 5, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (22, N'Cátedra de Matemáticas', 1, 2, 1, 1, N'2023', N'Primer Cuatrimestre')
GO
INSERT [dbo].[Catedras] ([id_catedra], [nombre_catedra], [id_horario], [id_materia], [id_docente], [id_comision], [año], [cuatrimestre]) VALUES (23, N'Cátedra de Estadistica', 3, 2, 1, 3, N'2023', N'Primer Cuatrimestre')
GO
SET IDENTITY_INSERT [dbo].[Catedras] OFF
GO
SET IDENTITY_INSERT [dbo].[Comisiones] ON 
GO
INSERT [dbo].[Comisiones] ([id_comision], [nombre_comision]) VALUES (1, N'1w1')
GO
INSERT [dbo].[Comisiones] ([id_comision], [nombre_comision]) VALUES (2, N'1w2')
GO
INSERT [dbo].[Comisiones] ([id_comision], [nombre_comision]) VALUES (3, N'2w1')
GO
INSERT [dbo].[Comisiones] ([id_comision], [nombre_comision]) VALUES (4, N'2w2')
GO
INSERT [dbo].[Comisiones] ([id_comision], [nombre_comision]) VALUES (5, N'1w3')
GO
SET IDENTITY_INSERT [dbo].[Comisiones] OFF
GO
SET IDENTITY_INSERT [dbo].[Detalle_Examen] ON 
GO
INSERT [dbo].[Detalle_Examen] ([id_detalle_examen], [id_examen_final], [id_estudiante], [nota]) VALUES (1, 1, 1, 2)
GO
INSERT [dbo].[Detalle_Examen] ([id_detalle_examen], [id_examen_final], [id_estudiante], [nota]) VALUES (2, 2, 2, 6)
GO
INSERT [dbo].[Detalle_Examen] ([id_detalle_examen], [id_examen_final], [id_estudiante], [nota]) VALUES (3, 3, 3, 7)
GO
INSERT [dbo].[Detalle_Examen] ([id_detalle_examen], [id_examen_final], [id_estudiante], [nota]) VALUES (4, 4, 4, 8)
GO
INSERT [dbo].[Detalle_Examen] ([id_detalle_examen], [id_examen_final], [id_estudiante], [nota]) VALUES (5, 5, 5, 6)
GO
SET IDENTITY_INSERT [dbo].[Detalle_Examen] OFF
GO
SET IDENTITY_INSERT [dbo].[Docentes] ON 
GO
INSERT [dbo].[Docentes] ([id_docente], [nombre_docente], [apellido_docente], [fec_nac], [dni], [direccion], [telefono], [email]) VALUES (1, N'Hector', N'García', CAST(N'1980-05-10T00:00:00.000' AS DateTime), 44567915, N'Rondeau 895', 4873251, N'juanG133@gmail.com')
GO
INSERT [dbo].[Docentes] ([id_docente], [nombre_docente], [apellido_docente], [fec_nac], [dni], [direccion], [telefono], [email]) VALUES (2, N'Ana', N'Herrado', CAST(N'1985-03-15T00:00:00.000' AS DateTime), 23589467, N'Independencia 343', 43658525, N'mariaLopez@gmail.com')
GO
INSERT [dbo].[Docentes] ([id_docente], [nombre_docente], [apellido_docente], [fec_nac], [dni], [direccion], [telefono], [email]) VALUES (3, N'Lautaro', N'Martínez', CAST(N'1978-11-20T00:00:00.000' AS DateTime), 23687954, N'San Martin 145', 44935184, N'martinez.Lautaro56@gmail.com')
GO
INSERT [dbo].[Docentes] ([id_docente], [nombre_docente], [apellido_docente], [fec_nac], [dni], [direccion], [telefono], [email]) VALUES (4, N'Luisa', N'Dominguez', CAST(N'1982-09-25T00:00:00.000' AS DateTime), 23647596, N'Belgrano 25', 4584512, N'luDominguez@gmail.com')
GO
INSERT [dbo].[Docentes] ([id_docente], [nombre_docente], [apellido_docente], [fec_nac], [dni], [direccion], [telefono], [email]) VALUES (5, N'Pedro', N'Olivera', CAST(N'1976-07-05T00:00:00.000' AS DateTime), 35469852, N'Richeri 754', 6548512, N'p.Olivera@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Docentes] OFF
GO
SET IDENTITY_INSERT [dbo].[Estados_Materias] ON 
GO
INSERT [dbo].[Estados_Materias] ([id_estado_materia], [nombre_estado_materia]) VALUES (1, N'Aprobada')
GO
INSERT [dbo].[Estados_Materias] ([id_estado_materia], [nombre_estado_materia]) VALUES (2, N'Desaprobado')
GO
INSERT [dbo].[Estados_Materias] ([id_estado_materia], [nombre_estado_materia]) VALUES (3, N'Regular')
GO
INSERT [dbo].[Estados_Materias] ([id_estado_materia], [nombre_estado_materia]) VALUES (4, N'Promocionado')
GO
INSERT [dbo].[Estados_Materias] ([id_estado_materia], [nombre_estado_materia]) VALUES (5, N'Libre')
GO
SET IDENTITY_INSERT [dbo].[Estados_Materias] OFF
GO
SET IDENTITY_INSERT [dbo].[Estudiante_Carrera] ON 
GO
INSERT [dbo].[Estudiante_Carrera] ([id_estudiante_carrera], [id_estudiante], [id_carrera]) VALUES (1, 1, 1)
GO
INSERT [dbo].[Estudiante_Carrera] ([id_estudiante_carrera], [id_estudiante], [id_carrera]) VALUES (2, 2, 3)
GO
INSERT [dbo].[Estudiante_Carrera] ([id_estudiante_carrera], [id_estudiante], [id_carrera]) VALUES (3, 3, 2)
GO
INSERT [dbo].[Estudiante_Carrera] ([id_estudiante_carrera], [id_estudiante], [id_carrera]) VALUES (4, 4, 4)
GO
INSERT [dbo].[Estudiante_Carrera] ([id_estudiante_carrera], [id_estudiante], [id_carrera]) VALUES (5, 5, 5)
GO
SET IDENTITY_INSERT [dbo].[Estudiante_Carrera] OFF
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] ON 
GO
INSERT [dbo].[Estudiantes] ([id_estudiante], [nombre_estudiante], [apellido_estudiante], [fecha_nac], [dni], [direccion], [telefono], [email], [estado_civil], [situacion_habitacional], [situacion_laboral]) VALUES (1, N'Juan', N'Pérez', CAST(N'2000-05-15T00:00:00.000' AS DateTime), 123456789, N'Juan B Justo 165', -679, N'juanperez@gmail.com', N'Soltero', N'Alquilando', N'Estudiante')
GO
INSERT [dbo].[Estudiantes] ([id_estudiante], [nombre_estudiante], [apellido_estudiante], [fecha_nac], [dni], [direccion], [telefono], [email], [estado_civil], [situacion_habitacional], [situacion_laboral]) VALUES (2, N'María', N'Gómez', CAST(N'1999-08-20T00:00:00.000' AS DateTime), 987654321, N'Valparaiso 456', -5123, N'mariagomez@gmail.com', N'Soltero', N'Vivienda propia', N'Estudiante')
GO
INSERT [dbo].[Estudiantes] ([id_estudiante], [nombre_estudiante], [apellido_estudiante], [fecha_nac], [dni], [direccion], [telefono], [email], [estado_civil], [situacion_habitacional], [situacion_laboral]) VALUES (3, N'Carlos', N'Rodríguez', CAST(N'2001-03-10T00:00:00.000' AS DateTime), 555555555, N'Celso Barrios 789', -8457, N'carlosrodriguez@gmail.com', N'Casado', N'Alquilando', N'Estudiante')
GO
INSERT [dbo].[Estudiantes] ([id_estudiante], [nombre_estudiante], [apellido_estudiante], [fecha_nac], [dni], [direccion], [telefono], [email], [estado_civil], [situacion_habitacional], [situacion_laboral]) VALUES (4, N'Luisa', N'López', CAST(N'2002-11-25T00:00:00.000' AS DateTime), 111111111, N'Copina 1011', -2901, N'luisalopez@gmail.com', N'Soltero', N'Vivienda propia', N'Estudiante')
GO
INSERT [dbo].[Estudiantes] ([id_estudiante], [nombre_estudiante], [apellido_estudiante], [fecha_nac], [dni], [direccion], [telefono], [email], [estado_civil], [situacion_habitacional], [situacion_laboral]) VALUES (5, N'Pedro', N'Sánchez', CAST(N'1998-07-05T00:00:00.000' AS DateTime), 999999999, N'Chacabuco #1213', -7335, N'pedrosanchez@gmail.com', N'Casado', N'Alquilando', N'Estudiante')
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] OFF
GO
SET IDENTITY_INSERT [dbo].[Examen_Final] ON 
GO
INSERT [dbo].[Examen_Final] ([id_examen_final], [turno], [fecha_examen], [id_docente], [id_materia]) VALUES (1, N'Mañana', CAST(N'2023-11-15T09:00:00.000' AS DateTime), 1, 1)
GO
INSERT [dbo].[Examen_Final] ([id_examen_final], [turno], [fecha_examen], [id_docente], [id_materia]) VALUES (2, N'Tarde', CAST(N'2023-11-20T14:30:00.000' AS DateTime), 2, 2)
GO
INSERT [dbo].[Examen_Final] ([id_examen_final], [turno], [fecha_examen], [id_docente], [id_materia]) VALUES (3, N'Noche', CAST(N'2023-11-22T20:00:00.000' AS DateTime), 3, 3)
GO
INSERT [dbo].[Examen_Final] ([id_examen_final], [turno], [fecha_examen], [id_docente], [id_materia]) VALUES (4, N'Tarde', CAST(N'2023-11-25T15:00:00.000' AS DateTime), 4, 4)
GO
INSERT [dbo].[Examen_Final] ([id_examen_final], [turno], [fecha_examen], [id_docente], [id_materia]) VALUES (5, N'Noche', CAST(N'2023-11-30T21:30:00.000' AS DateTime), 5, 5)
GO
SET IDENTITY_INSERT [dbo].[Examen_Final] OFF
GO
SET IDENTITY_INSERT [dbo].[Horarios] ON 
GO
INSERT [dbo].[Horarios] ([id_horario], [dia_semana], [hora_inicio], [hora_fin], [aula]) VALUES (1, N'Lunes', N'08:00 AM', N'10:00 AM', 101)
GO
INSERT [dbo].[Horarios] ([id_horario], [dia_semana], [hora_inicio], [hora_fin], [aula]) VALUES (2, N'Martes', N'10:30 AM', N'12:30 PM', 102)
GO
INSERT [dbo].[Horarios] ([id_horario], [dia_semana], [hora_inicio], [hora_fin], [aula]) VALUES (3, N'Miércoles', N'01:00 PM', N'03:00 PM', 103)
GO
INSERT [dbo].[Horarios] ([id_horario], [dia_semana], [hora_inicio], [hora_fin], [aula]) VALUES (4, N'Jueves', N'03:30 PM', N'05:30 PM', 104)
GO
INSERT [dbo].[Horarios] ([id_horario], [dia_semana], [hora_inicio], [hora_fin], [aula]) VALUES (5, N'Viernes', N'09:00 AM', N'11:00 AM', 105)
GO
SET IDENTITY_INSERT [dbo].[Horarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Inscripcion_Carrera] ON 
GO
INSERT [dbo].[Inscripcion_Carrera] ([id_inscripcion_carrera], [Fecha_Inscripcion], [id_estudiante], [id_carrera]) VALUES (1, CAST(N'2023-01-15T08:30:00.000' AS DateTime), 1, 1)
GO
INSERT [dbo].[Inscripcion_Carrera] ([id_inscripcion_carrera], [Fecha_Inscripcion], [id_estudiante], [id_carrera]) VALUES (2, CAST(N'2023-01-20T10:15:00.000' AS DateTime), 2, 3)
GO
INSERT [dbo].[Inscripcion_Carrera] ([id_inscripcion_carrera], [Fecha_Inscripcion], [id_estudiante], [id_carrera]) VALUES (3, CAST(N'2023-01-05T14:45:00.000' AS DateTime), 3, 2)
GO
INSERT [dbo].[Inscripcion_Carrera] ([id_inscripcion_carrera], [Fecha_Inscripcion], [id_estudiante], [id_carrera]) VALUES (4, CAST(N'2023-01-10T11:00:00.000' AS DateTime), 4, 4)
GO
INSERT [dbo].[Inscripcion_Carrera] ([id_inscripcion_carrera], [Fecha_Inscripcion], [id_estudiante], [id_carrera]) VALUES (5, CAST(N'2023-01-15T09:30:00.000' AS DateTime), 5, 5)
GO
SET IDENTITY_INSERT [dbo].[Inscripcion_Carrera] OFF
GO
SET IDENTITY_INSERT [dbo].[Inscripcion_Materias] ON 
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (1, 1, 1, CAST(N'2023-11-19T17:13:21.033' AS DateTime), 1)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (2, 2, 2, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 2)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (3, 3, 3, CAST(N'2023-11-19T17:14:01.413' AS DateTime), 3)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (4, 4, 4, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 4)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (5, 5, 5, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (6, 1, 2, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (7, 2, 1, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 2)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (8, 3, 4, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 3)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (9, 4, 5, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 4)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (10, 5, 3, CAST(N'2023-02-12T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (11, 1, 2, CAST(N'2023-11-18T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Inscripcion_Materias] ([id_inscripcion], [id_catedra], [id_estudiante], [fecha], [id_estado_materia]) VALUES (12, 12, 2, CAST(N'2023-11-19T00:00:00.000' AS DateTime), 2)
GO
SET IDENTITY_INSERT [dbo].[Inscripcion_Materias] OFF
GO
SET IDENTITY_INSERT [dbo].[Materias] ON 
GO
INSERT [dbo].[Materias] ([id_materia], [nombre_materia], [id_carrera]) VALUES (1, N'Matemáticas', 1)
GO
INSERT [dbo].[Materias] ([id_materia], [nombre_materia], [id_carrera]) VALUES (2, N'Inglés ', 2)
GO
INSERT [dbo].[Materias] ([id_materia], [nombre_materia], [id_carrera]) VALUES (3, N'Estadística', 3)
GO
INSERT [dbo].[Materias] ([id_materia], [nombre_materia], [id_carrera]) VALUES (4, N'Programación', 4)
GO
INSERT [dbo].[Materias] ([id_materia], [nombre_materia], [id_carrera]) VALUES (5, N'Laboratorio de Computación', 5)
GO
SET IDENTITY_INSERT [dbo].[Materias] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Notas] ON 
GO
INSERT [dbo].[Tipo_Notas] ([id_tipo_nota], [descripcion_tipo]) VALUES (1, N'Examen')
GO
INSERT [dbo].[Tipo_Notas] ([id_tipo_nota], [descripcion_tipo]) VALUES (2, N'Tarea')
GO
INSERT [dbo].[Tipo_Notas] ([id_tipo_nota], [descripcion_tipo]) VALUES (3, N'Participación')
GO
INSERT [dbo].[Tipo_Notas] ([id_tipo_nota], [descripcion_tipo]) VALUES (4, N'Proyecto')
GO
INSERT [dbo].[Tipo_Notas] ([id_tipo_nota], [descripcion_tipo]) VALUES (5, N'Trabajo Práctico')
GO
SET IDENTITY_INSERT [dbo].[Tipo_Notas] OFF
GO
ALTER TABLE [dbo].[Calificaciones]  WITH CHECK ADD  CONSTRAINT [fk_inscrip_calificaciones] FOREIGN KEY([id_inscripcion])
REFERENCES [dbo].[Inscripcion_Materias] ([id_inscripcion])
GO
ALTER TABLE [dbo].[Calificaciones] CHECK CONSTRAINT [fk_inscrip_calificaciones]
GO
ALTER TABLE [dbo].[Calificaciones]  WITH CHECK ADD  CONSTRAINT [fk_tipoNota_Calificaciones] FOREIGN KEY([id_tipo_nota])
REFERENCES [dbo].[Tipo_Notas] ([id_tipo_nota])
GO
ALTER TABLE [dbo].[Calificaciones] CHECK CONSTRAINT [fk_tipoNota_Calificaciones]
GO
ALTER TABLE [dbo].[Catedras]  WITH CHECK ADD  CONSTRAINT [fk_catedra_comision] FOREIGN KEY([id_comision])
REFERENCES [dbo].[Comisiones] ([id_comision])
GO
ALTER TABLE [dbo].[Catedras] CHECK CONSTRAINT [fk_catedra_comision]
GO
ALTER TABLE [dbo].[Catedras]  WITH CHECK ADD  CONSTRAINT [fk_catedra_docente] FOREIGN KEY([id_docente])
REFERENCES [dbo].[Docentes] ([id_docente])
GO
ALTER TABLE [dbo].[Catedras] CHECK CONSTRAINT [fk_catedra_docente]
GO
ALTER TABLE [dbo].[Catedras]  WITH CHECK ADD  CONSTRAINT [fk_catedra_materia] FOREIGN KEY([id_materia])
REFERENCES [dbo].[Materias] ([id_materia])
GO
ALTER TABLE [dbo].[Catedras] CHECK CONSTRAINT [fk_catedra_materia]
GO
ALTER TABLE [dbo].[Catedras]  WITH CHECK ADD  CONSTRAINT [fk_horarios_catedras] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Horarios] ([id_horario])
GO
ALTER TABLE [dbo].[Catedras] CHECK CONSTRAINT [fk_horarios_catedras]
GO
ALTER TABLE [dbo].[Detalle_Examen]  WITH CHECK ADD  CONSTRAINT [fk_detalle_estudiante] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[Estudiantes] ([id_estudiante])
GO
ALTER TABLE [dbo].[Detalle_Examen] CHECK CONSTRAINT [fk_detalle_estudiante]
GO
ALTER TABLE [dbo].[Detalle_Examen]  WITH CHECK ADD  CONSTRAINT [fk_examenFinal_Detalle] FOREIGN KEY([id_examen_final])
REFERENCES [dbo].[Examen_Final] ([id_examen_final])
GO
ALTER TABLE [dbo].[Detalle_Examen] CHECK CONSTRAINT [fk_examenFinal_Detalle]
GO
ALTER TABLE [dbo].[Estudiante_Carrera]  WITH CHECK ADD  CONSTRAINT [fk_carrera_est] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[Carreras] ([id_carrera])
GO
ALTER TABLE [dbo].[Estudiante_Carrera] CHECK CONSTRAINT [fk_carrera_est]
GO
ALTER TABLE [dbo].[Estudiante_Carrera]  WITH CHECK ADD  CONSTRAINT [fk_est_carrera] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[Estudiantes] ([id_estudiante])
GO
ALTER TABLE [dbo].[Estudiante_Carrera] CHECK CONSTRAINT [fk_est_carrera]
GO
ALTER TABLE [dbo].[Examen_Final]  WITH CHECK ADD  CONSTRAINT [fk_examenFinal_docente] FOREIGN KEY([id_docente])
REFERENCES [dbo].[Docentes] ([id_docente])
GO
ALTER TABLE [dbo].[Examen_Final] CHECK CONSTRAINT [fk_examenFinal_docente]
GO
ALTER TABLE [dbo].[Examen_Final]  WITH CHECK ADD  CONSTRAINT [fk_materia_examenFinal] FOREIGN KEY([id_materia])
REFERENCES [dbo].[Materias] ([id_materia])
GO
ALTER TABLE [dbo].[Examen_Final] CHECK CONSTRAINT [fk_materia_examenFinal]
GO
ALTER TABLE [dbo].[Inscripcion_Carrera]  WITH CHECK ADD  CONSTRAINT [fk_carrera_inscripcion] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[Carreras] ([id_carrera])
GO
ALTER TABLE [dbo].[Inscripcion_Carrera] CHECK CONSTRAINT [fk_carrera_inscripcion]
GO
ALTER TABLE [dbo].[Inscripcion_Carrera]  WITH CHECK ADD  CONSTRAINT [fk_estudiante_InscCarrera] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[Estudiantes] ([id_estudiante])
GO
ALTER TABLE [dbo].[Inscripcion_Carrera] CHECK CONSTRAINT [fk_estudiante_InscCarrera]
GO
ALTER TABLE [dbo].[Inscripcion_Materias]  WITH CHECK ADD  CONSTRAINT [fk_estadoMateria_Inscripcion] FOREIGN KEY([id_estado_materia])
REFERENCES [dbo].[Estados_Materias] ([id_estado_materia])
GO
ALTER TABLE [dbo].[Inscripcion_Materias] CHECK CONSTRAINT [fk_estadoMateria_Inscripcion]
GO
ALTER TABLE [dbo].[Inscripcion_Materias]  WITH CHECK ADD  CONSTRAINT [fk_estudiante_inscripcion] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[Estudiantes] ([id_estudiante])
GO
ALTER TABLE [dbo].[Inscripcion_Materias] CHECK CONSTRAINT [fk_estudiante_inscripcion]
GO
ALTER TABLE [dbo].[Inscripcion_Materias]  WITH CHECK ADD  CONSTRAINT [fk_inscripMateria_catedra] FOREIGN KEY([id_catedra])
REFERENCES [dbo].[Catedras] ([id_catedra])
GO
ALTER TABLE [dbo].[Inscripcion_Materias] CHECK CONSTRAINT [fk_inscripMateria_catedra]
GO
ALTER TABLE [dbo].[Materias]  WITH CHECK ADD  CONSTRAINT [fk_materias_carrera] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[Carreras] ([id_carrera])
GO
ALTER TABLE [dbo].[Materias] CHECK CONSTRAINT [fk_materias_carrera]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarDocentes]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ConsultarDocentes]
@apellido varchar(50)
as
BEGIN
	select count(ca.id_comision)'Cantidad de comisiones', upper(d.apellido_docente)+', '+d.nombre_docente 'Docente',
	ca.cuatrimestre 'Cuatrimestre'
	from docentes d join catedras ca on d.id_docente=ca.id_docente
		join comisiones co on ca.id_comision=co.id_comision
	where co.nombre_comision like '1w1' and ca.cuatrimestre like 'Primer Cuatrimestre'
	and @apellido=d.apellido_docente
	group by d.apellido_docente,d.nombre_docente,ca.cuatrimestre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AlumnosEstado]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_AlumnosEstado]
@apellido varchar(100)
as
begin
select distinct apellido_estudiante + ' ' + nombre_estudiante 'Alumno', nota 'Nota', 'Promocionado' 'Estado'
from Estudiantes e join Inscripcion_Materias im on e.id_estudiante = im.id_estudiante
join Calificaciones c on c.id_inscripcion = im.id_inscripcion
join Tipo_Notas tn on c.id_tipo_nota = tn.id_tipo_nota
join Estados_Materias em on im.id_estado_materia = im.id_estado_materia
where apellido_estudiante like '[a-m]%' and nota >= 8
and @apellido= e.apellido_estudiante
group by nota, apellido_estudiante, nombre_estudiante
union
select distinct apellido_estudiante + ',' + nombre_estudiante 'Alumno', nota 'Nota', 'Regular'
from Estudiantes e join Inscripcion_Materias im on e.id_estudiante = im.id_estudiante
join Calificaciones c on c.id_inscripcion = im.id_inscripcion
join Tipo_Notas tn on c.id_tipo_nota = tn.id_tipo_nota
join Estados_Materias em on im.id_estado_materia = im.id_estado_materia
where apellido_estudiante like '[a-m]%' and nota > 6 and nota <8
and @apellido= e.apellido_estudiante
group by nota, apellido_estudiante , nombre_estudiante
end

GO
/****** Object:  StoredProcedure [dbo].[SP_BORRAR_CARGA]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_BORRAR_CARGA]

@id_catedra int
as
begin
DELETE [dbo].[Inscripcion_Materias]
where id_catedra=@id_catedra
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BORRAR_INSCRIPICION]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BORRAR_INSCRIPICION]
@Id_inscripcion int
AS
BEGIN
UPDATE [dbo].[Inscripcion_Materias]
SET fecha = getdate()
WHERE id_inscripcion=@Id_inscripcion
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CATEDRA]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_CATEDRA]
as
begin
select* from [dbo].[Catedras]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_COMISIONES]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_COMISIONES]
AS
BEGIN
SELECT*FROM[dbo].[Comisiones]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_DETALLE_INSCRIPCION]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CONSULTAR_DETALLE_INSCRIPCION]
@id_catedra int
as
begin
SELECT distinct e.nombre_estudiante,i.fecha,es.nombre_estado_materia,c.nombre_catedra,h.dia_semana,m.nombre_materia,d.nombre_docente,
com.nombre_comision,c.año,c.cuatrimestre
FROM [dbo].[Inscripcion_Materias] i join [dbo].[Catedras] c on i.id_catedra=c.id_catedra
	join[dbo].[Materias] m on m.id_materia=c.id_materia
	join [dbo].[Estudiantes] e on e.id_estudiante=i.id_estudiante
	join[dbo].[Estados_Materias] es on es.id_estado_materia=i.id_estado_materia
	join [dbo].[Docentes] d on d.id_docente=c.id_docente
	join [dbo].[Comisiones] com on com.id_comision=c.id_comision
	join[dbo].[Horarios] h on h.id_horario=c.id_horario
WHERE @id_catedra=c.id_catedra
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_DOCENTES]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_DOCENTES]
AS
BEGIN
SELECT * FROM [dbo].[Docentes]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ESTADOMATERIA]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_ESTADOMATERIA]
AS
BEGIN
SELECT*FROM[dbo].[Estados_Materias]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ESTUDIANTES]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_ESTUDIANTES]
AS
BEGIN
SELECT * FROM [dbo].[Estudiantes]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_HORARIO]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_HORARIO]
as
begin
select * from[dbo].[Horarios]
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_INSCRIPCION]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_INSCRIPCION]
	@fecha_desde Datetime,
	@fecha_hasta Datetime,
	@materia varchar(255)
AS
BEGIN
SELECT *
FROM [dbo].[Inscripcion_Materias] i join [dbo].[Catedras] c on i.id_catedra=c.id_catedra
	join[dbo].[Materias] m on m.id_materia=c.id_materia
	join [dbo].[Estudiantes] e on e.id_estudiante=i.id_estudiante
	join[dbo].[Estados_Materias] es on es.id_estado_materia=i.id_estado_materia
	join [dbo].[Docentes] d on d.id_docente=c.id_docente
	join [dbo].[Comisiones] com on com.id_comision=c.id_comision
WHERE(@fecha_desde is null OR fecha >= @fecha_desde)
	AND (@fecha_hasta is null OR fecha <= @fecha_hasta)
	AND (@materia is null OR m.nombre_materia LIKE '%' + @materia + '%');
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_MATERIAS]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_MATERIAS]
AS
BEGIN
SELECT* FROM [dbo].[Materias]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ConsultarDocentes]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ConsultarDocentes]
@nombre varchar(50)
as
BEGIN
	select count(ca.id_comision)'CantidadComisiones', upper(d.apellido_docente)+', '+d.nombre_docente 'Docente',
	ca.cuatrimestre 'Cuatrimestre'
	from docentes d join catedras ca on d.id_docente=ca.id_docente
		join comisiones co on ca.id_comision=co.id_comision
	where co.nombre_comision like '1w1' and ca.cuatrimestre like 'Primer Cuatrimestre'
	and @nombre=d.nombre_docente
	group by d.apellido_docente,d.nombre_docente,ca.cuatrimestre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ESTUDIANTES_APROBADOS]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ESTUDIANTES_APROBADOS]
@materia varchar(50)
as
begin
	Select e.nombre_estudiante + ' '+ e.apellido_estudiante 'Alumno',m.nombre_materia 'Materia'
	from [dbo].[Estudiantes] e join [dbo].[Inscripcion_Materias] im on e.id_estudiante=im.id_estudiante
	join [dbo].[Catedras] c on c.id_catedra=im.id_catedra
	join [dbo].[Materias] m on m.id_materia=c.id_materia
	where exists ( select  distinct c2.id_materia
					from [dbo].[Materias]m2 left join [dbo].[Catedras] c2 on c2.id_materia=m2.id_materia
					where c2.id_catedra not in(
						select distinct im2.id_catedra
						from [dbo].[Inscripcion_Materias] im2
						inner join Calificaciones cal on im2.id_inscripcion=cal.id_inscripcion
						where im2.id_estudiante=e.id_estudiante and cal.nota<6))
	and @materia=m.nombre_materia
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CATEDRA]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERTAR_CATEDRA]
@id_catedra int output,
@descripcion varchar(100),
@id_horario int,
@id_materia int,
@id_docente int,
@id_comision int,
@año varchar(10),
@cuatri varchar(100)
as
begin
insert into catedras (nombre_catedra,id_horario,id_materia,id_docente,id_comision,año,cuatrimestre)
values (@descripcion,@id_horario,@id_materia,@id_docente,@id_comision,@año,@cuatri)
set @id_catedra= SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_INSCRIPCION_MATERIA]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_INSERTAR_INSCRIPCION_MATERIA]
@id_catedra int,
@id_estudiante int,
@fecha datetime,
@id_estado_materia int,
@id_inscripcion int output
as
begin
insert into [dbo].[Inscripcion_Materias](id_catedra,id_estudiante,fecha,id_estado_materia) values ( @id_catedra, @id_estudiante,@fecha,@id_estado_materia)
set @id_inscripcion=SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTER_ESTUDIANTE]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_INSERTER_ESTUDIANTE]
@id_estudiante int output,
@nombre_estudiante varchar(100),
@apellido_estudiante varchar(100),
@fecha_nac datetime,
@dni int,
@direccion varchar(500),
@telefono int,
@email varchar(200),
@estado_civil varchar(50),
@situacion_hab varchar(100),
@situacion_lab varchar(100)
as
begin
insert into [dbo].[Estudiantes](nombre_estudiante,apellido_estudiante,fecha_nac,dni,direccion,telefono,email,estado_civil,situacion_habitacional,situacion_laboral)
values (@nombre_estudiante,@apellido_estudiante,@fecha_nac,@dni,@direccion,@telefono,@email,@estado_civil,@situacion_hab,@situacion_lab)
set @id_estudiante=SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarAlumno]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ListarAlumno]
@nombre varchar(50)
as
begin
select im.id_estudiante  , apellido_estudiante + ',' + nombre_estudiante 'Alumno', 
MAX(nota)'NotaMaxima', MIN(nota) 'NotaMinima'
from Calificaciones c 
join Inscripcion_Materias im on c.id_inscripcion=im.id_inscripcion
join Estudiantes e on e.id_estudiante=im.id_estudiante
where DATEDIFF(YEAR,c.fecha,GETDATE()) = 0 
and e.id_estudiante between 1 and 3
and @nombre = e.nombre_estudiante
group by im.id_estudiante, apellido_estudiante,nombre_estudiante
having MAX(nota)> 6 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_PromedioNotas]    Script Date: 19/11/2023 19:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_PromedioNotas]
@nombre varchar (100)
as
begin
select e.nombre_estudiante+' '+ e.apellido_estudiante 'Nombre',
 (select avg(c.nota)
 from Calificaciones c INNER JOIN Inscripcion_Materias im on c.id_inscripcion = im.id_inscripcion
 where im.id_estudiante = e.id_estudiante) as 'PromedioNotas'
 from Estudiantes e
 where e.nombre_estudiante = @nombre
end
GO
