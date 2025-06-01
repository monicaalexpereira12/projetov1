-- Drop views if they exist
DROP VIEW IF EXISTS igreja.ViewPessoasSemGrupo;
DROP VIEW IF EXISTS igreja.EventosSemParticipantes;
DROP VIEW IF EXISTS igreja.GruposSemEscala;
DROP VIEW IF EXISTS igreja.ParticipantesEventos;

GO

-- View: Pessoas que não pertencem a nenhum grupo
CREATE VIEW igreja.ViewPessoasSemGrupo AS
SELECT 
   p.id_pessoa,
   p.nome_completo,
   p.email,
   p.data_entrada
FROM igreja.Pessoa p
WHERE NOT EXISTS (
   SELECT 1
   FROM igreja.MembroGrupo mg
   WHERE mg.id_pessoa_membro = p.id_pessoa
);
GO

-- View: Eventos que não têm nenhum participante registado
CREATE VIEW igreja.EventosSemParticipantes AS
SELECT 
   e.id_evento,
   e.titulo,
   e.tipo_evento,
   e.data_hora_inicio
FROM igreja.Evento e
WHERE NOT EXISTS (
   SELECT 1
   FROM igreja.ParticipacaoEvento pe
   WHERE pe.id_evento_part = e.id_evento
);
GO

-- View: Grupos sem escalas associadas
CREATE VIEW igreja.GruposSemEscala AS
SELECT 
   g.id_grupo,
   g.nome_grupo,
   g.descricao
FROM igreja.Grupo g
WHERE NOT EXISTS (
   SELECT 1
   FROM igreja.Escala e
   WHERE e.escala_grupo = g.id_grupo
);
GO

-- View: Participações completas em eventos, com nomes de pessoas
CREATE VIEW igreja.ParticipantesEventos AS
SELECT 
   pe.id_evento_part,
   e.titulo AS evento,
   p.nome_completo AS participante,
   pe.funcao,
   d.data_inicio AS disponibilidade_inicio
FROM igreja.ParticipacaoEvento pe
JOIN igreja.Disponibilidade d ON pe.id_pessoa_part = d.id_disponibilidade
JOIN igreja.Pessoa p ON d.id_pessoa_disp = p.id_pessoa
JOIN igreja.Evento e ON pe.id_evento_part = e.id_evento;
GO
