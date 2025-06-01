-- Clean existing data (FK-safe order)
DELETE FROM igreja.Contem;
DELETE FROM igreja.ParticipacaoEvento;
DELETE FROM igreja.Disponibilidade;
DELETE FROM igreja.MembroGrupo;

DELETE FROM igreja.Catequizandos;
DELETE FROM igreja.Catequistas;
DELETE FROM igreja.Coristas;
DELETE FROM igreja.MinistrosComunhao;
DELETE FROM igreja.Acolitos;
DELETE FROM igreja.Leitores;

DELETE FROM igreja.Tarefa;
DELETE FROM igreja.Escala;
DELETE FROM igreja.Evento;
DELETE FROM igreja.Grupo;
DELETE FROM igreja.Pessoa;
GO

-- Insert Pessoas
INSERT INTO igreja.Pessoa (id_pessoa, nome_completo, morada, email, data_entrada, data_nascimento) VALUES
(1, 'João Silva', 'Rua das Oliveiras, 12', 'joao.silva@email.com', '2021-05-10', '1985-04-20'),
(2, 'Maria Fernandes', 'Av. Central, 201', 'maria.fernandes@email.com', '2022-03-14', '1990-09-12'),
(3, 'Carlos Pinto', 'Travessa da Paz, 8', 'carlos.pinto@email.com', '2023-01-22', '1978-12-05'),
(4, 'Ana Gomes', 'Rua da Igreja, 33', 'ana.gomes@email.com', '2020-09-01', '1995-06-30');
GO

-- Insert Grupos
INSERT INTO igreja.Grupo (id_grupo, nome_grupo, descricao) VALUES
(1, 'Leitores', 'Grupo de leitura nas missas'),
(2, 'Coro Jovem', 'Grupo coral da missa das 18h'),
(3, 'Acolitos', 'Serviço de apoio ao altar');
GO

-- Membros em grupos
INSERT INTO igreja.MembroGrupo (id_pessoa_membro, id_grupo_membro, funcao, data_entrada) VALUES
(1, 1, 'Leitor Principal', '2021-06-01'),
(2, 2, 'Soprano', '2022-04-01'),
(3, 3, 'Acolito', '2023-02-01');
GO

-- Disponibilidade (pré-requisito para participar em eventos)
INSERT INTO igreja.Disponibilidade (id_disponibilidade, data_inicio, data_fim, motivo, id_pessoa_disp) VALUES
(101, '2025-06-01', '2025-06-01', 'Disponível para missa dominical', 1),
(102, '2025-06-03', '2025-06-03', 'Disponível para encontro', 2);
GO

-- Eventos
INSERT INTO igreja.Evento (id_evento, titulo, tipo_evento, data_hora_inicio) VALUES
(10, 'Missa Dominical', 'Missa', '2025-06-01 10:00:00'),
(11, 'Encontro de Jovens', 'Reunião', '2025-06-03 18:00:00');
GO

-- Participações (referem Disponibilidade IDs)
INSERT INTO igreja.ParticipacaoEvento (id_pessoa_part, id_evento_part, funcao) VALUES
(101, 10, 'Leitura'),
(102, 11, 'Canto');
GO

-- Escalas
INSERT INTO igreja.Escala (id_escala, escala_grupo, descricao, data_inicio, data_fim) VALUES
(201, 1, 'Escala de Leitura - Junho', '2025-06-01', '2025-06-30');
GO

-- Tarefas
INSERT INTO igreja.Tarefa (id_tarefa, funcao) VALUES
(301, 'Leitura da Primeira Leitura'),
(302, 'Leitura da Segunda Leitura');
GO

-- Escala inclui tarefas
INSERT INTO igreja.Contem (contem_tarefas, para_escala) VALUES
(301, 201),
(302, 201);
GO

-- Subtipo: Leitores
INSERT INTO igreja.Leitores (grupo_leitores, leitura_preferida, nivel_leitura) VALUES
(1, 'Epístolas', 'Avançado');
GO
