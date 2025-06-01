create schema igreja

create table igreja.Pessoa (
   nome_completo varchar(100),
   morada varchar(200),
   email varchar(100),
   data_entrada date,
   data_nascimento date,
   id_pessoa int not null,
   primary key (id_pessoa)
)

create table igreja.Grupo (
   id_grupo int not null,
   descricao varchar(200),
   nome_grupo varchar(100),
   primary key (id_grupo)
)

create table igreja.MembroGrupo (
   funcao varchar(100),
   data_entrada date,
   id_pessoa_membro int not null,
   id_grupo_membro int not null,
   primary key (id_pessoa_membro, id_grupo_membro),
   foreign key (id_pessoa_membro) references igreja.Pessoa(id_pessoa),
   foreign key (id_grupo_membro) references igreja.Grupo(id_grupo)
)

create table igreja.Disponibilidade (
   id_disponibilidade int not null,
   data_inicio date,
   data_fim date,
   motivo varchar(200),
   id_pessoa_disp int not null,
   primary key (id_disponibilidade),
   foreign key (id_pessoa_disp) references igreja.Pessoa(id_pessoa)
)

create table igreja.Evento (
   id_evento int not null,
   titulo varchar(100),
   tipo_evento varchar(50),
   data_hora_inicio datetime2(0),
   primary key (id_evento)
)

create table igreja.ParticipacaoEvento (
   funcao varchar(100),
   id_pessoa_part int not null,
   id_evento_part int not null,
   primary key (id_pessoa_part, id_evento_part),
   foreign key (id_pessoa_part) references igreja.Disponibilidade(id_disponibilidade),
   foreign key (id_evento_part) references igreja.Evento(id_evento)
)

create table igreja.Escala (
   escala_grupo int,
   descricao varchar(200),
   data_fim date,
   data_inicio date,
   id_escala int not null,
   primary key (id_escala),
   foreign key (escala_grupo) references igreja.Grupo(id_grupo)
)

create table igreja.Tarefa (
   id_tarefa int not null,
   funcao varchar(100),
   primary key (id_tarefa)
)

create table igreja.Contem (
   contem_tarefas int not null,
   para_escala int not null,
   primary key (contem_tarefas, para_escala),
   foreign key (contem_tarefas) references igreja.Tarefa(id_tarefa),
   foreign key (para_escala) references igreja.Escala(id_escala)
)

create table igreja.Leitores (
   grupo_leitores int not null,
   leitura_preferida varchar(100),
   nivel_leitura varchar(50),
   primary key (grupo_leitores),
   foreign key (grupo_leitores) references igreja.Grupo(id_grupo)
)

create table igreja.Acolitos (
   grupo_acolitos int not null,
   padrinho varchar(100),
   alva varchar(50),
   nivel_formacao varchar(50),
   primary key (grupo_acolitos),
   foreign key (grupo_acolitos) references igreja.Grupo(id_grupo)
)

create table igreja.MinistrosComunhao (
   grupo_ministros int not null,
   area_atuacao varchar(100),
   data_inicio_ministerio date,
   primary key (grupo_ministros),
   foreign key (grupo_ministros) references igreja.Grupo(id_grupo)
)

create table igreja.Coristas (
   grupo_coro int not null,
   tipo_voz varchar(50),
   instrumento varchar(50),
   primary key (grupo_coro),
   foreign key (grupo_coro) references igreja.Grupo(id_grupo)
)

create table igreja.Catequistas (
   grupo_catequistas int not null,
   nivel_formacao varchar(50),
   anos_catequese int,
   primary key (grupo_catequistas),
   foreign key (grupo_catequistas) references igreja.Grupo(id_grupo)
)

create table igreja.Catequizandos (
   grupo_catequese int not null,
   idade int,
   ano_entrada int,
   primary key (grupo_catequese),
   foreign key (grupo_catequese) references igreja.Grupo(id_grupo)
)