-- Drop existing triggers
IF EXISTS (SELECT name FROM sys.triggers WHERE name = 'trg_AfterInsert_MembroGrupo')
DROP TRIGGER igreja.trg_AfterInsert_MembroGrupo;

IF EXISTS (SELECT name FROM sys.triggers WHERE name = 'trg_AfterDelete_MembroGrupo')
DROP TRIGGER igreja.trg_AfterDelete_MembroGrupo;

IF EXISTS (SELECT name FROM sys.triggers WHERE name = 'trg_AfterInsert_ParticipacaoEvento')
DROP TRIGGER igreja.trg_AfterInsert_ParticipacaoEvento;

IF EXISTS (SELECT name FROM sys.triggers WHERE name = 'trg_AfterDelete_ParticipacaoEvento')
DROP TRIGGER igreja.trg_AfterDelete_ParticipacaoEvento;

GO

-- Trigger: Log new group membership
CREATE TRIGGER igreja.trg_AfterInsert_MembroGrupo
ON igreja.MembroGrupo
AFTER INSERT
AS
BEGIN
   PRINT 'Novo membro foi adicionado a um grupo.';
END;
GO

-- Trigger: Log removal of group membership
CREATE TRIGGER igreja.trg_AfterDelete_MembroGrupo
ON igreja.MembroGrupo
AFTER DELETE
AS
BEGIN
   PRINT 'Um membro foi removido de um grupo.';
END;
GO

-- Trigger: Log event participation (via disponibilidade)
CREATE TRIGGER igreja.trg_AfterInsert_ParticipacaoEvento
ON igreja.ParticipacaoEvento
AFTER INSERT
AS
BEGIN
   PRINT 'Nova participação em evento foi registada.';
END;
GO

-- Trigger: Log when a participation is removed
CREATE TRIGGER igreja.trg_AfterDelete_ParticipacaoEvento
ON igreja.ParticipacaoEvento
AFTER DELETE
AS
BEGIN
   PRINT 'Uma participação em evento foi removida.';
END;
GO
