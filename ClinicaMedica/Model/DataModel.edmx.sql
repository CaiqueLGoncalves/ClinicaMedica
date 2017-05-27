
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/27/2017 15:50:22
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Email] nvarchar(64)  NULL,
    [IdLocalidade] int  NOT NULL
);
GO

-- Creating table 'TB_Localidade'
CREATE TABLE [dbo].[TB_Localidade] (
    [IdLocalidade] int IDENTITY(1,1) NOT NULL,
    [Endereco] nvarchar(100)  NOT NULL,
    [Numero] nvarchar(6)  NULL,
    [Complemento] nvarchar(25)  NULL,
    [CEP] nvarchar(8)  NOT NULL,
    [Bairro] nvarchar(25)  NULL,
    [Cidade] nvarchar(25)  NOT NULL,
    [Estado] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'TB_Telefone'
CREATE TABLE [dbo].[TB_Telefone] (
    [DDI] nvarchar(3)  NOT NULL,
    [DDD] nvarchar(3)  NOT NULL,
    [Numero] nvarchar(10)  NOT NULL,
    [IdentificacaoPessoa] int  NULL,
    [IdConsultorio] int  NULL,
    [Tipo] int  NOT NULL
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
    [Localidade_IdLocalidade] int  NOT NULL
);
GO

-- Creating table 'TB_QuadroFuncionarios'
CREATE TABLE [dbo].[TB_QuadroFuncionarios] (
    [IdConsultorio] int  NOT NULL,
    [IdFuncionario] int  NOT NULL,
    [DataAdmissao] datetime  NOT NULL,
    [DataDemissao] datetime  NULL
);
GO

-- Creating table 'TB_Estoque'
CREATE TABLE [dbo].[TB_Estoque] (
    [IdEstoque] int IDENTITY(1,1) NOT NULL,
    [IdConsultorio] int  NOT NULL,
    [Nome] nvarchar(30)  NOT NULL,
    [Descricao] nvarchar(max)  NULL,
    [Refrigeracao] bit  NOT NULL
);
GO

-- Creating table 'TB_Produto'
CREATE TABLE [dbo].[TB_Produto] (
    [IdProduto] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Descricao] nvarchar(max)  NULL,
    [Tipo] int  NOT NULL
);
GO

-- Creating table 'TB_Item'
CREATE TABLE [dbo].[TB_Item] (
    [IdEstoque] int  NOT NULL,
    [IdProduto] int  NOT NULL,
    [Quantidade] int  NOT NULL
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

-- Creating table 'TB_Usuario_Funcionario'
CREATE TABLE [dbo].[TB_Usuario_Funcionario] (
    [IdFuncao] int  NOT NULL,
    [Identificacao] int  NOT NULL
);
GO

-- Creating table 'TB_Usuario_Medico'
CREATE TABLE [dbo].[TB_Usuario_Medico] (
    [CRM] nvarchar(10)  NOT NULL,
    [Identificacao] int  NOT NULL
);
GO

-- Creating table 'TB_Usuario_Paciente'
CREATE TABLE [dbo].[TB_Usuario_Paciente] (
    [Identificacao] int  NOT NULL
);
GO

-- Creating table 'MedicoEspecialidade'
CREATE TABLE [dbo].[MedicoEspecialidade] (
    [Medico_Identificacao] int  NOT NULL,
    [Especialidade_IdEspecialidade] int  NOT NULL
);
GO

-- Creating table 'ConsultorioExame'
CREATE TABLE [dbo].[ConsultorioExame] (
    [Consultorio_IdConsultorio] int  NOT NULL,
    [Exame_IdExame] int  NOT NULL
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

-- Creating primary key on [DDI], [DDD], [Numero] in table 'TB_Telefone'
ALTER TABLE [dbo].[TB_Telefone]
ADD CONSTRAINT [PK_TB_Telefone]
    PRIMARY KEY CLUSTERED ([DDI], [DDD], [Numero] ASC);
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

-- Creating primary key on [IdEstoque] in table 'TB_Estoque'
ALTER TABLE [dbo].[TB_Estoque]
ADD CONSTRAINT [PK_TB_Estoque]
    PRIMARY KEY CLUSTERED ([IdEstoque] ASC);
GO

-- Creating primary key on [IdProduto] in table 'TB_Produto'
ALTER TABLE [dbo].[TB_Produto]
ADD CONSTRAINT [PK_TB_Produto]
    PRIMARY KEY CLUSTERED ([IdProduto] ASC);
GO

-- Creating primary key on [IdEstoque], [IdProduto] in table 'TB_Item'
ALTER TABLE [dbo].[TB_Item]
ADD CONSTRAINT [PK_TB_Item]
    PRIMARY KEY CLUSTERED ([IdEstoque], [IdProduto] ASC);
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

-- Creating primary key on [Identificacao] in table 'TB_Usuario_Funcionario'
ALTER TABLE [dbo].[TB_Usuario_Funcionario]
ADD CONSTRAINT [PK_TB_Usuario_Funcionario]
    PRIMARY KEY CLUSTERED ([Identificacao] ASC);
GO

-- Creating primary key on [Identificacao] in table 'TB_Usuario_Medico'
ALTER TABLE [dbo].[TB_Usuario_Medico]
ADD CONSTRAINT [PK_TB_Usuario_Medico]
    PRIMARY KEY CLUSTERED ([Identificacao] ASC);
GO

-- Creating primary key on [Identificacao] in table 'TB_Usuario_Paciente'
ALTER TABLE [dbo].[TB_Usuario_Paciente]
ADD CONSTRAINT [PK_TB_Usuario_Paciente]
    PRIMARY KEY CLUSTERED ([Identificacao] ASC);
GO

-- Creating primary key on [Medico_Identificacao], [Especialidade_IdEspecialidade] in table 'MedicoEspecialidade'
ALTER TABLE [dbo].[MedicoEspecialidade]
ADD CONSTRAINT [PK_MedicoEspecialidade]
    PRIMARY KEY CLUSTERED ([Medico_Identificacao], [Especialidade_IdEspecialidade] ASC);
GO

-- Creating primary key on [Consultorio_IdConsultorio], [Exame_IdExame] in table 'ConsultorioExame'
ALTER TABLE [dbo].[ConsultorioExame]
ADD CONSTRAINT [PK_ConsultorioExame]
    PRIMARY KEY CLUSTERED ([Consultorio_IdConsultorio], [Exame_IdExame] ASC);
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

-- Creating foreign key on [IdentificacaoPessoa] in table 'TB_Telefone'
ALTER TABLE [dbo].[TB_Telefone]
ADD CONSTRAINT [FK_TelefonePessoa]
    FOREIGN KEY ([IdentificacaoPessoa])
    REFERENCES [dbo].[TB_Usuario]
        ([Identificacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TelefonePessoa'
CREATE INDEX [IX_FK_TelefonePessoa]
ON [dbo].[TB_Telefone]
    ([IdentificacaoPessoa]);
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

-- Creating foreign key on [IdConsultorio] in table 'TB_Telefone'
ALTER TABLE [dbo].[TB_Telefone]
ADD CONSTRAINT [FK_ConsultorioTelefone]
    FOREIGN KEY ([IdConsultorio])
    REFERENCES [dbo].[TB_Consultorio]
        ([IdConsultorio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultorioTelefone'
CREATE INDEX [IX_FK_ConsultorioTelefone]
ON [dbo].[TB_Telefone]
    ([IdConsultorio]);
GO

-- Creating foreign key on [IdConsultorio] in table 'TB_Estoque'
ALTER TABLE [dbo].[TB_Estoque]
ADD CONSTRAINT [FK_ConsultorioEstoque]
    FOREIGN KEY ([IdConsultorio])
    REFERENCES [dbo].[TB_Consultorio]
        ([IdConsultorio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultorioEstoque'
CREATE INDEX [IX_FK_ConsultorioEstoque]
ON [dbo].[TB_Estoque]
    ([IdConsultorio]);
GO

-- Creating foreign key on [IdEstoque] in table 'TB_Item'
ALTER TABLE [dbo].[TB_Item]
ADD CONSTRAINT [FK_EstoqueItem]
    FOREIGN KEY ([IdEstoque])
    REFERENCES [dbo].[TB_Estoque]
        ([IdEstoque])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdProduto] in table 'TB_Item'
ALTER TABLE [dbo].[TB_Item]
ADD CONSTRAINT [FK_ProdutoItem]
    FOREIGN KEY ([IdProduto])
    REFERENCES [dbo].[TB_Produto]
        ([IdProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoItem'
CREATE INDEX [IX_FK_ProdutoItem]
ON [dbo].[TB_Item]
    ([IdProduto]);
GO

-- Creating foreign key on [Medico_Identificacao] in table 'MedicoEspecialidade'
ALTER TABLE [dbo].[MedicoEspecialidade]
ADD CONSTRAINT [FK_MedicoEspecialidade_Medico]
    FOREIGN KEY ([Medico_Identificacao])
    REFERENCES [dbo].[TB_Usuario_Medico]
        ([Identificacao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Especialidade_IdEspecialidade] in table 'MedicoEspecialidade'
ALTER TABLE [dbo].[MedicoEspecialidade]
ADD CONSTRAINT [FK_MedicoEspecialidade_Especialidade]
    FOREIGN KEY ([Especialidade_IdEspecialidade])
    REFERENCES [dbo].[TB_Especialidade]
        ([IdEspecialidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoEspecialidade_Especialidade'
CREATE INDEX [IX_FK_MedicoEspecialidade_Especialidade]
ON [dbo].[MedicoEspecialidade]
    ([Especialidade_IdEspecialidade]);
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

-- Creating foreign key on [Consultorio_IdConsultorio] in table 'ConsultorioExame'
ALTER TABLE [dbo].[ConsultorioExame]
ADD CONSTRAINT [FK_ConsultorioExame_Consultorio]
    FOREIGN KEY ([Consultorio_IdConsultorio])
    REFERENCES [dbo].[TB_Consultorio]
        ([IdConsultorio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Exame_IdExame] in table 'ConsultorioExame'
ALTER TABLE [dbo].[ConsultorioExame]
ADD CONSTRAINT [FK_ConsultorioExame_Exame]
    FOREIGN KEY ([Exame_IdExame])
    REFERENCES [dbo].[TB_Exame]
        ([IdExame])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultorioExame_Exame'
CREATE INDEX [IX_FK_ConsultorioExame_Exame]
ON [dbo].[ConsultorioExame]
    ([Exame_IdExame]);
GO

-- Creating foreign key on [Identificacao] in table 'TB_Usuario_Funcionario'
ALTER TABLE [dbo].[TB_Usuario_Funcionario]
ADD CONSTRAINT [FK_Funcionario_inherits_Usuario]
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

-- Creating foreign key on [Identificacao] in table 'TB_Usuario_Paciente'
ALTER TABLE [dbo].[TB_Usuario_Paciente]
ADD CONSTRAINT [FK_Paciente_inherits_Usuario]
    FOREIGN KEY ([Identificacao])
    REFERENCES [dbo].[TB_Usuario]
        ([Identificacao])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------