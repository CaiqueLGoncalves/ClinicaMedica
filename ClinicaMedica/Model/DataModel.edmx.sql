
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2017 19:48:31
-- Generated from EDMX file: C:\Users\Caique\Documents\Visual Studio 2015\Projects\ClinicaMedica\ClinicaMedica\Model\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClinicaMedicaBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PessoaLocalidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Usuario] DROP CONSTRAINT [FK_PessoaLocalidade];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionarioFuncao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Usuario_Funcionario] DROP CONSTRAINT [FK_FuncionarioFuncao];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionarioQuadroFuncionarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_QuadroFuncionarios] DROP CONSTRAINT [FK_FuncionarioQuadroFuncionarios];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultorioQuadroFuncionarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_QuadroFuncionarios] DROP CONSTRAINT [FK_ConsultorioQuadroFuncionarios];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultorioLocalidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Consultorio] DROP CONSTRAINT [FK_ConsultorioLocalidade];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Consulta] DROP CONSTRAINT [FK_PacienteConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Consulta] DROP CONSTRAINT [FK_MedicoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultorioConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Consulta] DROP CONSTRAINT [FK_ConsultorioConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteAgendaExame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_AgendaExame] DROP CONSTRAINT [FK_PacienteAgendaExame];
GO
IF OBJECT_ID(N'[dbo].[FK_ExameAgendaExame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_AgendaExame] DROP CONSTRAINT [FK_ExameAgendaExame];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultorioAgendaExame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_AgendaExame] DROP CONSTRAINT [FK_ConsultorioAgendaExame];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultorioConsultorioExame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_ConsultorioExame] DROP CONSTRAINT [FK_ConsultorioConsultorioExame];
GO
IF OBJECT_ID(N'[dbo].[FK_ExameConsultorioExame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_ConsultorioExame] DROP CONSTRAINT [FK_ExameConsultorioExame];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoMedicoEspecialidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_MedicoEspecialidade] DROP CONSTRAINT [FK_MedicoMedicoEspecialidade];
GO
IF OBJECT_ID(N'[dbo].[FK_EspecialidadeMedicoEspecialidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_MedicoEspecialidade] DROP CONSTRAINT [FK_EspecialidadeMedicoEspecialidade];
GO
IF OBJECT_ID(N'[dbo].[FK_Funcionario_inherits_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Usuario_Funcionario] DROP CONSTRAINT [FK_Funcionario_inherits_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_Paciente_inherits_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Usuario_Paciente] DROP CONSTRAINT [FK_Paciente_inherits_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_Medico_inherits_Funcionario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Usuario_Medico] DROP CONSTRAINT [FK_Medico_inherits_Funcionario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TB_Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Usuario];
GO
IF OBJECT_ID(N'[dbo].[TB_Localidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Localidade];
GO
IF OBJECT_ID(N'[dbo].[TB_Funcao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Funcao];
GO
IF OBJECT_ID(N'[dbo].[TB_Consultorio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Consultorio];
GO
IF OBJECT_ID(N'[dbo].[TB_QuadroFuncionarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_QuadroFuncionarios];
GO
IF OBJECT_ID(N'[dbo].[TB_Especialidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Especialidade];
GO
IF OBJECT_ID(N'[dbo].[TB_Exame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Exame];
GO
IF OBJECT_ID(N'[dbo].[TB_Consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Consulta];
GO
IF OBJECT_ID(N'[dbo].[TB_AgendaExame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_AgendaExame];
GO
IF OBJECT_ID(N'[dbo].[TB_ConsultorioExame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_ConsultorioExame];
GO
IF OBJECT_ID(N'[dbo].[TB_MedicoEspecialidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_MedicoEspecialidade];
GO
IF OBJECT_ID(N'[dbo].[TB_Usuario_Funcionario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Usuario_Funcionario];
GO
IF OBJECT_ID(N'[dbo].[TB_Usuario_Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Usuario_Paciente];
GO
IF OBJECT_ID(N'[dbo].[TB_Usuario_Medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Usuario_Medico];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TB_Usuario'
CREATE TABLE [dbo].[TB_Usuario] (
    [Identificacao] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [CPF] nvarchar(11)  NULL,
    [RG] nvarchar(12)  NULL,
    [DataNascimento] datetime  NOT NULL,
    [Sexo] nvarchar(10)  NOT NULL,
    [TelefoneResidencial] nvarchar(12)  NULL,
    [TelefoneComercial] nvarchar(12)  NULL,
    [TelefoneCelular] nvarchar(15)  NULL,
    [Email] nvarchar(100)  NULL,
    [IdLocalidade] int  NOT NULL
);
GO

-- Creating table 'TB_Localidade'
CREATE TABLE [dbo].[TB_Localidade] (
    [IdLocalidade] int IDENTITY(1,1) NOT NULL,
    [Endereco] nvarchar(150)  NOT NULL,
    [Numero] nvarchar(5)  NULL,
    [Complemento] nvarchar(100)  NULL,
    [CEP] nvarchar(8)  NULL,
    [Bairro] nvarchar(100)  NULL,
    [Cidade] nvarchar(100)  NOT NULL,
    [Estado] nvarchar(2)  NOT NULL
);
GO

-- Creating table 'TB_Funcao'
CREATE TABLE [dbo].[TB_Funcao] (
    [IdFuncao] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(30)  NOT NULL,
    [Descricao] nvarchar(max)  NULL
);
GO

-- Creating table 'TB_Consultorio'
CREATE TABLE [dbo].[TB_Consultorio] (
    [IdConsultorio] int IDENTITY(1,1) NOT NULL,
    [NomeFantasia] nvarchar(100)  NULL,
    [RazaoSocial] nvarchar(100)  NOT NULL,
    [CNPJ] nvarchar(14)  NOT NULL,
    [HorarioAbertura] time  NOT NULL,
    [HorarioFechamento] time  NOT NULL,
    [Telefone] nvarchar(12)  NULL,
    [Localidade_IdLocalidade] int  NOT NULL
);
GO

-- Creating table 'TB_QuadroFuncionarios'
CREATE TABLE [dbo].[TB_QuadroFuncionarios] (
    [IdConsultorio] int  NOT NULL,
    [IdFuncionario] int  NOT NULL,
    [DataAdmissao] datetime  NOT NULL,
    [DataDemissao] datetime  NULL,
    [Status] bit  NOT NULL
);
GO

-- Creating table 'TB_Especialidade'
CREATE TABLE [dbo].[TB_Especialidade] (
    [IdEspecialidade] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(30)  NOT NULL,
    [Descricao] nvarchar(max)  NULL
);
GO

-- Creating table 'TB_Exame'
CREATE TABLE [dbo].[TB_Exame] (
    [IdExame] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Recomendacoes] nvarchar(max)  NULL
);
GO

-- Creating table 'TB_Consulta'
CREATE TABLE [dbo].[TB_Consulta] (
    [IdConsulta] int IDENTITY(1,1) NOT NULL,
    [IdentificacaoPaciente] int  NOT NULL,
    [IdentificacaoMedico] int  NOT NULL,
    [IdConsultorio] int  NOT NULL,
    [DataHoraInicio] datetime  NOT NULL,
    [DataHoraFim] datetime  NOT NULL,
    [Comparecimento] bit  NOT NULL,
    [Anotacoes] nvarchar(max)  NULL
);
GO

-- Creating table 'TB_AgendaExame'
CREATE TABLE [dbo].[TB_AgendaExame] (
    [IdAgendaExame] int IDENTITY(1,1) NOT NULL,
    [IdentificacaoPaciente] int  NOT NULL,
    [IdExame] int  NOT NULL,
    [IdConsultorio] int  NOT NULL,
    [DataHoraInicio] datetime  NOT NULL,
    [DataHoraFim] datetime  NOT NULL,
    [Comparecimento] bit  NOT NULL,
    [Anotacoes] nvarchar(max)  NULL
);
GO

-- Creating table 'TB_ConsultorioExame'
CREATE TABLE [dbo].[TB_ConsultorioExame] (
    [IdConsultorio] int  NOT NULL,
    [IdExame] int  NOT NULL
);
GO

-- Creating table 'TB_MedicoEspecialidade'
CREATE TABLE [dbo].[TB_MedicoEspecialidade] (
    [IdentificacaoMedico] int  NOT NULL,
    [IdEspecialidade] int  NOT NULL
);
GO

-- Creating table 'TB_Usuario_Funcionario'
CREATE TABLE [dbo].[TB_Usuario_Funcionario] (
    [IdFuncao] int  NOT NULL,
    [Identificacao] int  NOT NULL
);
GO

-- Creating table 'TB_Usuario_Paciente'
CREATE TABLE [dbo].[TB_Usuario_Paciente] (
    [Identificacao] int  NOT NULL
);
GO

-- Creating table 'TB_Usuario_Medico'
CREATE TABLE [dbo].[TB_Usuario_Medico] (
    [CRM] nvarchar(10)  NOT NULL,
    [EspecialidadeIdEspecialidade] int  NOT NULL,
    [Identificacao] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Identificacao] in table 'TB_Usuario'
ALTER TABLE [dbo].[TB_Usuario]
ADD CONSTRAINT [PK_TB_Usuario]
    PRIMARY KEY CLUSTERED ([Identificacao] ASC);
GO

-- Creating primary key on [IdLocalidade] in table 'TB_Localidade'
ALTER TABLE [dbo].[TB_Localidade]
ADD CONSTRAINT [PK_TB_Localidade]
    PRIMARY KEY CLUSTERED ([IdLocalidade] ASC);
GO

-- Creating primary key on [IdFuncao] in table 'TB_Funcao'
ALTER TABLE [dbo].[TB_Funcao]
ADD CONSTRAINT [PK_TB_Funcao]
    PRIMARY KEY CLUSTERED ([IdFuncao] ASC);
GO

-- Creating primary key on [IdConsultorio] in table 'TB_Consultorio'
ALTER TABLE [dbo].[TB_Consultorio]
ADD CONSTRAINT [PK_TB_Consultorio]
    PRIMARY KEY CLUSTERED ([IdConsultorio] ASC);
GO

-- Creating primary key on [IdConsultorio], [IdFuncionario] in table 'TB_QuadroFuncionarios'
ALTER TABLE [dbo].[TB_QuadroFuncionarios]
ADD CONSTRAINT [PK_TB_QuadroFuncionarios]
    PRIMARY KEY CLUSTERED ([IdConsultorio], [IdFuncionario] ASC);
GO

-- Creating primary key on [IdEspecialidade] in table 'TB_Especialidade'
ALTER TABLE [dbo].[TB_Especialidade]
ADD CONSTRAINT [PK_TB_Especialidade]
    PRIMARY KEY CLUSTERED ([IdEspecialidade] ASC);
GO

-- Creating primary key on [IdExame] in table 'TB_Exame'
ALTER TABLE [dbo].[TB_Exame]
ADD CONSTRAINT [PK_TB_Exame]
    PRIMARY KEY CLUSTERED ([IdExame] ASC);
GO

-- Creating primary key on [IdConsulta] in table 'TB_Consulta'
ALTER TABLE [dbo].[TB_Consulta]
ADD CONSTRAINT [PK_TB_Consulta]
    PRIMARY KEY CLUSTERED ([IdConsulta] ASC);
GO

-- Creating primary key on [IdAgendaExame] in table 'TB_AgendaExame'
ALTER TABLE [dbo].[TB_AgendaExame]
ADD CONSTRAINT [PK_TB_AgendaExame]
    PRIMARY KEY CLUSTERED ([IdAgendaExame] ASC);
GO

-- Creating primary key on [IdConsultorio], [IdExame] in table 'TB_ConsultorioExame'
ALTER TABLE [dbo].[TB_ConsultorioExame]
ADD CONSTRAINT [PK_TB_ConsultorioExame]
    PRIMARY KEY CLUSTERED ([IdConsultorio], [IdExame] ASC);
GO

-- Creating primary key on [IdentificacaoMedico], [IdEspecialidade] in table 'TB_MedicoEspecialidade'
ALTER TABLE [dbo].[TB_MedicoEspecialidade]
ADD CONSTRAINT [PK_TB_MedicoEspecialidade]
    PRIMARY KEY CLUSTERED ([IdentificacaoMedico], [IdEspecialidade] ASC);
GO

-- Creating primary key on [Identificacao] in table 'TB_Usuario_Funcionario'
ALTER TABLE [dbo].[TB_Usuario_Funcionario]
ADD CONSTRAINT [PK_TB_Usuario_Funcionario]
    PRIMARY KEY CLUSTERED ([Identificacao] ASC);
GO

-- Creating primary key on [Identificacao] in table 'TB_Usuario_Paciente'
ALTER TABLE [dbo].[TB_Usuario_Paciente]
ADD CONSTRAINT [PK_TB_Usuario_Paciente]
    PRIMARY KEY CLUSTERED ([Identificacao] ASC);
GO

-- Creating primary key on [Identificacao] in table 'TB_Usuario_Medico'
ALTER TABLE [dbo].[TB_Usuario_Medico]
ADD CONSTRAINT [PK_TB_Usuario_Medico]
    PRIMARY KEY CLUSTERED ([Identificacao] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdLocalidade] in table 'TB_Usuario'
ALTER TABLE [dbo].[TB_Usuario]
ADD CONSTRAINT [FK_PessoaLocalidade]
    FOREIGN KEY ([IdLocalidade])
    REFERENCES [dbo].[TB_Localidade]
        ([IdLocalidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaLocalidade'
CREATE INDEX [IX_FK_PessoaLocalidade]
ON [dbo].[TB_Usuario]
    ([IdLocalidade]);
GO

-- Creating foreign key on [IdFuncao] in table 'TB_Usuario_Funcionario'
ALTER TABLE [dbo].[TB_Usuario_Funcionario]
ADD CONSTRAINT [FK_FuncionarioFuncao]
    FOREIGN KEY ([IdFuncao])
    REFERENCES [dbo].[TB_Funcao]
        ([IdFuncao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioFuncao'
CREATE INDEX [IX_FK_FuncionarioFuncao]
ON [dbo].[TB_Usuario_Funcionario]
    ([IdFuncao]);
GO

-- Creating foreign key on [IdFuncionario] in table 'TB_QuadroFuncionarios'
ALTER TABLE [dbo].[TB_QuadroFuncionarios]
ADD CONSTRAINT [FK_FuncionarioQuadroFuncionarios]
    FOREIGN KEY ([IdFuncionario])
    REFERENCES [dbo].[TB_Usuario_Funcionario]
        ([Identificacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioQuadroFuncionarios'
CREATE INDEX [IX_FK_FuncionarioQuadroFuncionarios]
ON [dbo].[TB_QuadroFuncionarios]
    ([IdFuncionario]);
GO

-- Creating foreign key on [IdConsultorio] in table 'TB_QuadroFuncionarios'
ALTER TABLE [dbo].[TB_QuadroFuncionarios]
ADD CONSTRAINT [FK_ConsultorioQuadroFuncionarios]
    FOREIGN KEY ([IdConsultorio])
    REFERENCES [dbo].[TB_Consultorio]
        ([IdConsultorio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Localidade_IdLocalidade] in table 'TB_Consultorio'
ALTER TABLE [dbo].[TB_Consultorio]
ADD CONSTRAINT [FK_ConsultorioLocalidade]
    FOREIGN KEY ([Localidade_IdLocalidade])
    REFERENCES [dbo].[TB_Localidade]
        ([IdLocalidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultorioLocalidade'
CREATE INDEX [IX_FK_ConsultorioLocalidade]
ON [dbo].[TB_Consultorio]
    ([Localidade_IdLocalidade]);
GO

-- Creating foreign key on [IdentificacaoPaciente] in table 'TB_Consulta'
ALTER TABLE [dbo].[TB_Consulta]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([IdentificacaoPaciente])
    REFERENCES [dbo].[TB_Usuario_Paciente]
        ([Identificacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[TB_Consulta]
    ([IdentificacaoPaciente]);
GO

-- Creating foreign key on [IdentificacaoMedico] in table 'TB_Consulta'
ALTER TABLE [dbo].[TB_Consulta]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([IdentificacaoMedico])
    REFERENCES [dbo].[TB_Usuario_Medico]
        ([Identificacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsulta'
CREATE INDEX [IX_FK_MedicoConsulta]
ON [dbo].[TB_Consulta]
    ([IdentificacaoMedico]);
GO

-- Creating foreign key on [IdConsultorio] in table 'TB_Consulta'
ALTER TABLE [dbo].[TB_Consulta]
ADD CONSTRAINT [FK_ConsultorioConsulta]
    FOREIGN KEY ([IdConsultorio])
    REFERENCES [dbo].[TB_Consultorio]
        ([IdConsultorio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultorioConsulta'
CREATE INDEX [IX_FK_ConsultorioConsulta]
ON [dbo].[TB_Consulta]
    ([IdConsultorio]);
GO

-- Creating foreign key on [IdentificacaoPaciente] in table 'TB_AgendaExame'
ALTER TABLE [dbo].[TB_AgendaExame]
ADD CONSTRAINT [FK_PacienteAgendaExame]
    FOREIGN KEY ([IdentificacaoPaciente])
    REFERENCES [dbo].[TB_Usuario_Paciente]
        ([Identificacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteAgendaExame'
CREATE INDEX [IX_FK_PacienteAgendaExame]
ON [dbo].[TB_AgendaExame]
    ([IdentificacaoPaciente]);
GO

-- Creating foreign key on [IdExame] in table 'TB_AgendaExame'
ALTER TABLE [dbo].[TB_AgendaExame]
ADD CONSTRAINT [FK_ExameAgendaExame]
    FOREIGN KEY ([IdExame])
    REFERENCES [dbo].[TB_Exame]
        ([IdExame])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExameAgendaExame'
CREATE INDEX [IX_FK_ExameAgendaExame]
ON [dbo].[TB_AgendaExame]
    ([IdExame]);
GO

-- Creating foreign key on [IdConsultorio] in table 'TB_AgendaExame'
ALTER TABLE [dbo].[TB_AgendaExame]
ADD CONSTRAINT [FK_ConsultorioAgendaExame]
    FOREIGN KEY ([IdConsultorio])
    REFERENCES [dbo].[TB_Consultorio]
        ([IdConsultorio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultorioAgendaExame'
CREATE INDEX [IX_FK_ConsultorioAgendaExame]
ON [dbo].[TB_AgendaExame]
    ([IdConsultorio]);
GO

-- Creating foreign key on [IdConsultorio] in table 'TB_ConsultorioExame'
ALTER TABLE [dbo].[TB_ConsultorioExame]
ADD CONSTRAINT [FK_ConsultorioConsultorioExame]
    FOREIGN KEY ([IdConsultorio])
    REFERENCES [dbo].[TB_Consultorio]
        ([IdConsultorio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdExame] in table 'TB_ConsultorioExame'
ALTER TABLE [dbo].[TB_ConsultorioExame]
ADD CONSTRAINT [FK_ExameConsultorioExame]
    FOREIGN KEY ([IdExame])
    REFERENCES [dbo].[TB_Exame]
        ([IdExame])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExameConsultorioExame'
CREATE INDEX [IX_FK_ExameConsultorioExame]
ON [dbo].[TB_ConsultorioExame]
    ([IdExame]);
GO

-- Creating foreign key on [IdentificacaoMedico] in table 'TB_MedicoEspecialidade'
ALTER TABLE [dbo].[TB_MedicoEspecialidade]
ADD CONSTRAINT [FK_MedicoMedicoEspecialidade]
    FOREIGN KEY ([IdentificacaoMedico])
    REFERENCES [dbo].[TB_Usuario_Medico]
        ([Identificacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEspecialidade] in table 'TB_MedicoEspecialidade'
ALTER TABLE [dbo].[TB_MedicoEspecialidade]
ADD CONSTRAINT [FK_EspecialidadeMedicoEspecialidade]
    FOREIGN KEY ([IdEspecialidade])
    REFERENCES [dbo].[TB_Especialidade]
        ([IdEspecialidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EspecialidadeMedicoEspecialidade'
CREATE INDEX [IX_FK_EspecialidadeMedicoEspecialidade]
ON [dbo].[TB_MedicoEspecialidade]
    ([IdEspecialidade]);
GO

-- Creating foreign key on [Identificacao] in table 'TB_Usuario_Funcionario'
ALTER TABLE [dbo].[TB_Usuario_Funcionario]
ADD CONSTRAINT [FK_Funcionario_inherits_Usuario]
    FOREIGN KEY ([Identificacao])
    REFERENCES [dbo].[TB_Usuario]
        ([Identificacao])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Identificacao] in table 'TB_Usuario_Paciente'
ALTER TABLE [dbo].[TB_Usuario_Paciente]
ADD CONSTRAINT [FK_Paciente_inherits_Usuario]
    FOREIGN KEY ([Identificacao])
    REFERENCES [dbo].[TB_Usuario]
        ([Identificacao])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Identificacao] in table 'TB_Usuario_Medico'
ALTER TABLE [dbo].[TB_Usuario_Medico]
ADD CONSTRAINT [FK_Medico_inherits_Funcionario]
    FOREIGN KEY ([Identificacao])
    REFERENCES [dbo].[TB_Usuario_Funcionario]
        ([Identificacao])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------