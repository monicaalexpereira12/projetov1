-- Drop existing procedures
DROP PROCEDURE IF EXISTS igreja.GetAllPessoas;
DROP PROCEDURE IF EXISTS igreja.GetAllGrupos;
DROP PROCEDURE IF EXISTS igreja.GetAllEventos;
DROP PROCEDURE IF EXISTS igreja.GetParticipacoesEvento;
DROP PROCEDURE IF EXISTS igreja.DeleteGrupoWithMembros;

-- Drop existing functions
DROP FUNCTION IF EXISTS igreja.TotalPessoas;
DROP FUNCTION IF EXISTS igreja.TotalEventos;
DROP FUNCTION IF EXISTS igreja.TotalGrupos;
DROP FUNCTION IF EXISTS igreja.TotalEscalas;
DROP FUNCTION IF EXISTS igreja.PessoasSemGrupo;
DROP FUNCTION IF EXISTS igreja.FilterDisponibilidadeByMotivo;
DROP FUNCTION IF EXISTS igreja.MostFrequentFuncao;
DROP FUNCTION IF EXISTS igreja.GetPessoaByDisponibilidade;

GO

-- Stored Procedures

CREATE PROCEDURE igreja.GetAllPessoas
AS
BEGIN
   SELECT id_pessoa, nome_completo, morada, email, data_entrada, data_nascimento
   FROM igreja.Pessoa
END;
GO

CREATE PROCEDURE igreja.GetAllGrupos
AS
BEGIN
   SELECT id_grupo, nome_grupo, descricao
   FROM igreja.Grupo
END;
GO

CREATE PROCEDURE igreja.GetAllEventos
AS
BEGIN
   SELECT id_evento, titulo, tipo_evento, data_hora_inicio
   FROM igreja.Evento
END;
GO

-- Get all participations in events, joined with people (through Disponibilidade)
CREATE PROCEDURE igreja.GetParticipacoesEvento
AS
BEGIN
   SELECT 
      p.id_pessoa,
      p.nome_completo,
      e.id_evento,
      e.titulo,
      pe.funcao,
      d.data_inicio AS disponibilidade_inicio
   FROM igreja.ParticipacaoEvento pe
   JOIN igreja.Disponibilidade d ON pe.id_pessoa_part = d.id_disponibilidade
   JOIN igreja.Pessoa p ON d.id_pessoa_disp = p.id_pessoa
   JOIN igreja.Evento e ON pe.id_evento_part = e.id_evento
END;
GO

-- Delete a group and its members
CREATE PROCEDURE igreja.DeleteGrupoWithMembros
   @GrupoID INT
AS
BEGIN
   SET NOCOUNT ON;
   BEGIN TRY
      BEGIN TRANSACTION;

      DELETE FROM igreja.MembroGrupo
      WHERE id_grupo_membro = @GrupoID;

      DELETE FROM igreja.Grupo
      WHERE id_grupo = @GrupoID;

      COMMIT TRANSACTION;
   END TRY
   BEGIN CATCH
      IF @@TRANCOUNT > 0
         ROLLBACK TRANSACTION;
      THROW;
   END CATCH;
END;
GO

-- Scalar and Table-Valued Functions

CREATE FUNCTION igreja.TotalPessoas()
RETURNS INT
AS
BEGIN
   DECLARE @Total INT;
   SELECT @Total = COUNT(*) FROM igreja.Pessoa;
   RETURN @Total;
END;
GO

CREATE FUNCTION igreja.TotalEventos()
RETURNS INT
AS
BEGIN
   DECLARE @Total INT;
   SELECT @Total = COUNT(*) FROM igreja.Evento;
   RETURN @Total;
END;
GO

CREATE FUNCTION igreja.TotalGrupos()
RETURNS INT
AS
BEGIN
   DECLARE @Total INT;
   SELECT @Total = COUNT(*) FROM igreja.Grupo;
   RETURN @Total;
END;
GO

CREATE FUNCTION igreja.TotalEscalas()
RETURNS INT
AS
BEGIN
   DECLARE @Total INT;
   SELECT @Total = COUNT(*) FROM igreja.Escala;
   RETURN @Total;
END;
GO

-- Pessoas que não pertencem a nenhum grupo
CREATE FUNCTION igreja.PessoasSemGrupo()
RETURNS TABLE
AS
RETURN (
   SELECT p.*
   FROM igreja.Pessoa p
   WHERE NOT EXISTS (
      SELECT 1
      FROM igreja.MembroGrupo mg
      WHERE mg.id_pessoa_membro = p.id_pessoa
   )
);
GO

-- Filtro de disponibilidade por motivo
CREATE FUNCTION igreja.FilterDisponibilidadeByMotivo (@Motivo VARCHAR(200))
RETURNS TABLE
AS
RETURN (
   SELECT *
   FROM igreja.Disponibilidade
   WHERE motivo LIKE '%' + @Motivo + '%'
);
GO

-- Função para obter pessoa a partir de uma disponibilidade
CREATE FUNCTION igreja.GetPessoaByDisponibilidade (@IdDisponibilidade INT)
RETURNS TABLE
AS
RETURN (
   SELECT p.*
   FROM igreja.Disponibilidade d
   JOIN igreja.Pessoa p ON d.id_pessoa_disp = p.id_pessoa
   WHERE d.id_disponibilidade = @IdDisponibilidade
);
GO

-- Função: função mais comum nos grupos
CREATE FUNCTION igreja.MostFrequentFuncao()
RETURNS TABLE
AS
RETURN (
   SELECT TOP 1 funcao, COUNT(*) AS ocorrencias
   FROM igreja.MembroGrupo
   GROUP BY funcao
   ORDER BY ocorrencias DESC
);
GO
