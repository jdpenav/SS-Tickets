USE [SeminarioTickets]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[IdBit] [int] identity(1,1) NOT NULL,
	[FchBit] [date] NOT NULL,
	[HrBit] [time](7) NOT NULL,
	[EmlUsu] [nvarchar](255) NOT NULL,
	[TipBit] [int] NOT NULL,
	[DscBit] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[IdBit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCli] [nvarchar](13) NOT NULL,
	[NomCli] [nvarchar](70) NOT NULL,
	[TelCli] [nvarchar](11) NOT NULL,
	[EmlCli] [nvarchar](255) NOT NULL,
	[DirCli] [nvarchar](500) NULL,
	[RtnCli] [nvarchar](15) NULL,
	[GnrCli] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colaboradores]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colaboradores](
	[IdEmp] [int] identity(1,1) NOT NULL,
	[NomEmp] [nvarchar](70) NOT NULL,
	[FchNacEmp] [date] NOT NULL,
	[EmlEmp] [nvarchar](255) NOT NULL,
	[DirEmp] [nvarchar](500) NOT NULL,
	[TelEmp] [nvarchar](11) NOT NULL,
	[GnrEmp] [bit] NOT NULL,
	[IdPst] [int] NOT NULL,
	[EmlUsu] [nvarchar](255) NULL,
 CONSTRAINT [PK_Colaboradores] PRIMARY KEY CLUSTERED 
(
	[IdEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[IdEvt] [int] identity(1,1) NOT NULL,
	[NomEvt] [nvarchar](70) NOT NULL,
	[IdEvn] [int] NOT NULL,
	[FchEvt] [date] NOT NULL,
	[HrEvt] [time](7) NOT NULL,
	[IdLug] [int] NOT NULL,
	[CapEvt] [int] NOT NULL,
	[ResEvt] [int] NOT NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[IdEvt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasDetalle]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalle](
	[NroFact] [int] NOT NULL,
	[IdTct] [int] NOT NULL,
	[CantTct] [int] NOT NULL,
 CONSTRAINT [PK_FacturasDetalle] PRIMARY KEY CLUSTERED 
(
	[NroFact] ASC,
	[IdTct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasEncabezado]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasEncabezado](
	[NroFact] [int] identity(1,1) NOT NULL,
	[IdCli] [nvarchar](13) NOT NULL,
	[IdEmp] [int] NOT NULL,
	[FchEmp] [date] NOT NULL,
 CONSTRAINT [PK_FacturasEncabezado] PRIMARY KEY CLUSTERED 
(
	[NroFact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugares]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugares](
	[IdLug] [int] identity(1,1) NOT NULL,
	[NomLug] [nvarchar](40) NOT NULL,
	[CapLug] [int] NOT NULL,
 CONSTRAINT [PK_Lugares] PRIMARY KEY CLUSTERED 
(
	[IdLug] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Niveles]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Niveles](
	[IdNvl] [int] identity(1,1) NOT NULL,
	[NomNvl] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Niveles] PRIMARY KEY CLUSTERED 
(
	[IdNvl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos](
	[IdPst] [int] identity(1,1) NOT NULL,
	[NomPst] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Puestos] PRIMARY KEY CLUSTERED 
(
	[IdPst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[IdTct] [int] identity(1,1) NOT NULL,
	[FchTct] [date] NOT NULL,
	[IdEvt] [int] NOT NULL,
	[IdCli] [nvarchar](13) NOT NULL,
	[IdUbc] [int] NOT NULL,
	[NumUbc] [int] NOT NULL,
	[PrcTct] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[IdTct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEventos]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEventos](
	[IdEvn] [int] identity(1,1) NOT NULL,
	[NomEvn] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TipoEventos] PRIMARY KEY CLUSTERED 
(
	[IdEvn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ubicaciones]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubicaciones](
	[IdUbc] [int] identity(1,1) NOT NULL,
	[ZonaUbc] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Ubicaciones] PRIMARY KEY CLUSTERED 
(
	[IdUbc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[EmlUsu] [nvarchar](255) NOT NULL,
	[ConUsu] [nvarchar](255) NOT NULL,
	[CodEnvUsu] [int] NULL,
	[IdNvl] [int] NOT NULL,
	[EstUsu] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[EmlUsu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuarios] FOREIGN KEY([EmlUsu])
REFERENCES [dbo].[Usuarios] ([EmlUsu])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuarios]
GO
ALTER TABLE [dbo].[Colaboradores]  WITH CHECK ADD FOREIGN KEY([EmlUsu])
REFERENCES [dbo].[Usuarios] ([EmlUsu])
GO
ALTER TABLE [dbo].[Colaboradores]  WITH CHECK ADD  CONSTRAINT [FK_Colaboradores_Puestos] FOREIGN KEY([IdPst])
REFERENCES [dbo].[Puestos] ([IdPst])
GO
ALTER TABLE [dbo].[Colaboradores] CHECK CONSTRAINT [FK_Colaboradores_Puestos]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_Lugares] FOREIGN KEY([IdLug])
REFERENCES [dbo].[Lugares] ([IdLug])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_Lugares]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_TipoEventos] FOREIGN KEY([IdEvn])
REFERENCES [dbo].[TipoEventos] ([IdEvn])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_TipoEventos]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_FacturasEncabezado] FOREIGN KEY([NroFact])
REFERENCES [dbo].[FacturasEncabezado] ([NroFact])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_FacturasEncabezado]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Tickets] FOREIGN KEY([IdTct])
REFERENCES [dbo].[Tickets] ([IdTct])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Tickets]
GO
ALTER TABLE [dbo].[FacturasEncabezado]  WITH CHECK ADD  CONSTRAINT [FK_FacturasEncabezado_Clientes] FOREIGN KEY([IdCli])
REFERENCES [dbo].[Clientes] ([IdCli])
GO
ALTER TABLE [dbo].[FacturasEncabezado] CHECK CONSTRAINT [FK_FacturasEncabezado_Clientes]
GO
ALTER TABLE [dbo].[FacturasEncabezado]  WITH CHECK ADD  CONSTRAINT [FK_FacturasEncabezado_Colaboradores] FOREIGN KEY([IdEmp])
REFERENCES [dbo].[Colaboradores] ([IdEmp])
GO
ALTER TABLE [dbo].[FacturasEncabezado] CHECK CONSTRAINT [FK_FacturasEncabezado_Colaboradores]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Clientes] FOREIGN KEY([IdCli])
REFERENCES [dbo].[Clientes] ([IdCli])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Clientes]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Eventos] FOREIGN KEY([IdEvt])
REFERENCES [dbo].[Eventos] ([IdEvt])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Eventos]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Ubicaciones] FOREIGN KEY([IdUbc])
REFERENCES [dbo].[Ubicaciones] ([IdUbc])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Ubicaciones]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Niveles] FOREIGN KEY([IdNvl])
REFERENCES [dbo].[Niveles] ([IdNvl])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Niveles]
GO
/****** Object:  StoredProcedure [dbo].[InsercionBitacora]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionBitacora]
	-- Add the parameters for the stored procedure here
	@FchBit date,
	@HrBit time (7),
	@EmlBit nvarchar(255),
	@TipBit nvarchar(10),
	@DscBit nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Bitacora values (@FchBit, @HrBit, @EmlBit, @TipBit, @DscBit)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionClientes]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionClientes] 
	@IdCli nvarchar (13),
	@NomCli nvarchar(70),
	@TelCli nvarchar(11),
	@EmlCli nvarchar(255),
	@DirCli nvarchar(500),
	@RtnCli nvarchar(15),
	@GnrCli bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Clientes values (@IdCli, @NomCli, @TelCli, @EmlCli,@DirCli, @RtnCli, @GnrCli)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionColaboradores]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionColaboradores]
	-- Add the parameters for the stored procedure here
	@NomEmp nvarchar(70),
	@FchNacEmp date,
	@EmlEmp nvarchar(255),
	@DirEmp nvarchar(500),
	@TelEmp nvarchar(11),
	@GnrEmp bit,
	@IdPst int,
	@EmlUsu nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Colaboradores values (@NomEmp, @FchNacEmp, @EmlEmp, @DirEmp, @TelEmp, @GnrEmp, @IdPst, @EmlUsu)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionesPuestos]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionesPuestos]
	-- Add the parameters for the stored procedure here
@NomPst nvarchar (20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Puestos values (@NomPst)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionesTickets]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionesTickets]
	-- Add the parameters for the stored procedure here
@FchTct date,
@IdEvt int,
@IdCli nvarchar(13),
@IdUbc int,
@NumUbc int,
@PrcTct int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Tickets values(@FchTct, @IdEvt, @IdCli, @IdUbc, @NumUbc, @PrcTct)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionesTipoEventos]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionesTipoEventos]
	-- Add the parameters for the stored procedure here
@NomEvn nvarchar(30)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into TipoEventos values (@NomEvn)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionesUsuarios]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionesUsuarios] 
	-- Add the parameters for the stored procedure here
@EmlUsu nvarchar(255),
@ConUsu nvarchar(255),
@CodEnvUsu int,
@IdNvl int, 
@EstUsu bit

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Usuarios values (@EmlUsu, @ConUsu, @CodEnvUsu, @IdNvl, @EstUsu)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionEventos]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionEventos]
	-- Add the parameters for the stored procedure here
	@NomEvt nvarchar(70),
	@IdEvn int,
	@FchEvt date,
	@HrEvt time(7),
	@IdLug int,
	@CapEvt int,
	@ResEvt int


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Eventos values (@NomEvt, @IdEvn, @FchEvt, @HrEvt, @IdLug, @CapEvt, @ResEvt)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionFacturaDetalle]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionFacturaDetalle] 
	-- Add the parameters for the stored procedure here
 @NroFact int,
 @IdTct int,
 @CantTct int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into FacturasDetalle values (@NroFact, @IdTct, @CantTct)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionFacturaEncabezado]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionFacturaEncabezado]
	-- Add the parameters for the stored procedure here
	@IdCli nvarchar(13),
	@IdEmp int, 
	@FchEmp date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into FacturasEncabezado values (@IdCli, @IdEmp, @FchEmp)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionLugares]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionLugares] 
	-- Add the parameters for the stored procedure here
	@NomLug nvarchar(40),
	@CapLug int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Lugares values (@NomLug, @CapLug)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionNiveles]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionNiveles] 
	-- Add the parameters for the stored procedure here
	@NomNvl nvarchar (20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
Insert into Niveles values(@NomNvl)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionUbicaciones]    Script Date: 1/7/2023 21:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionUbicaciones] 
	-- Add the parameters for the stored procedure here
	@ZonaUbc nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Ubicaciones VALUES (@ZonaUbc)
END
GO