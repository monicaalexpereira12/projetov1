-- MembroGrupo indexes
IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_MembroGrupo_Pessoa')
DROP INDEX idx_MembroGrupo_Pessoa ON igreja.MembroGrupo;
CREATE INDEX idx_MembroGrupo_Pessoa ON igreja.MembroGrupo (id_pessoa_membro);

IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_MembroGrupo_Grupo')
DROP INDEX idx_MembroGrupo_Grupo ON igreja.MembroGrupo;
CREATE INDEX idx_MembroGrupo_Grupo ON igreja.MembroGrupo (id_grupo_membro);

-- ParticipacaoEvento indexes
IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_Participacao_Evento')
DROP INDEX idx_Participacao_Evento ON igreja.ParticipacaoEvento;
CREATE INDEX idx_Participacao_Evento ON igreja.ParticipacaoEvento (id_evento_part);

IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_Participacao_Disponibilidade')
DROP INDEX idx_Participacao_Disponibilidade ON igreja.ParticipacaoEvento;
CREATE INDEX idx_Participacao_Disponibilidade ON igreja.ParticipacaoEvento (id_pessoa_part);

-- Disponibilidade index
IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_Disponibilidade_Pessoa')
DROP INDEX idx_Disponibilidade_Pessoa ON igreja.Disponibilidade;
CREATE INDEX idx_Disponibilidade_Pessoa ON igreja.Disponibilidade (id_pessoa_disp);

-- Escala index
IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_Escala_Grupo')
DROP INDEX idx_Escala_Grupo ON igreja.Escala;
CREATE INDEX idx_Escala_Grupo ON igreja.Escala (escala_grupo);

-- Contem indexes
IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_Contem_Tarefa')
DROP INDEX idx_Contem_Tarefa ON igreja.Contem;
CREATE INDEX idx_Contem_Tarefa ON igreja.Contem (contem_tarefas);

IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_Contem_Escala')
DROP INDEX idx_Contem_Escala ON igreja.Contem;
CREATE INDEX idx_Contem_Escala ON igreja.Contem (para_escala);

-- Pessoa: index on nome_completo for search performance
IF EXISTS (SELECT name FROM sys.indexes WHERE name = 'idx_Pessoa_Nome')
DROP INDEX idx_Pessoa_Nome ON igreja.Pessoa;
CREATE INDEX idx_Pessoa_Nome ON igreja.Pessoa (nome_completo);
