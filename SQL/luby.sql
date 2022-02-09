-- Resolva as questões utilizando as tabelas abaixo como referência\

-- +----+--------------+
-- | tabela_pessoa     |
-- +----+--------------+
-- | id | nome         |
-- +----+--------------+
-- |  1 | John Doe     |
-- |  2 | Jane Doe     |
-- |  3 | Alice Jones  |
-- |  4 | Bobby Louis  |
-- |  5 | Lisa Romero  |
-- +----+--------------+
-- +----+----------------+-----------+
-- | tabela_evento                   |
-- +----+----------------+-----------+
-- | id | evento         | pessoa_id |
-- +----+----------------+-----------+
-- |  1 | Evento A       |  2        |
-- |  2 | Evento B       |  3        |
-- |  3 | Evento C       |  2        |
-- |  4 | Evento D       |  NULL     |
-- +----+----------------+-----------+

-- 2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.

 SELECT * FROM pessoa
 WHERE id IN (SELECT pessoa_id FROM evento);

--  2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.

SELECT * FROM tabela_pessoa WHERE nome LIKE '%Doe';

-- 2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.

INSERT INTO tabela_evento(evento, pessoa_id) VALUES ('Evento E', '5');

-- 2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'

UPDATE tabela_evento SET pessoa_id = '1' WHERE evento ='Evento D';

-- 2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.

DELETE FROM tabela_evento WHERE evento = 'Evento B';

-- 2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.

DELETE FROM tabela_pessoa WHERE id NOT IN (SELECT pessoa_id FROM tabela_eventos);

-- Gerênciamento de tabelas

-- 2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)

ALTER TABLE tabela_pessoa ADD idade INT NULL;

-- 2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:\
--     id: int (PK)
--     telefone: varchar(200)
--     pessoa_id: int(FK)

CREATE TABLE tabela_telefone
(ID INT PRIMARY KEY IDENTITY NOT NULL,
telefone VARCHAR(200),
pessoa_id INT NULL,
FOREIGN KEY(pessoa_id)
REFERENCES tabela_pessoa(pessoa_id));

-- 2.9 Crie uma query para criar uma índice do tipo único na coluna telefone da 'tabela_telefone'.

CREATE unique index [UX_tabela_telefone.telefone] ON tabela_telefone(telefone);

-- 2.10 Crie uma query para remover a 'tabela_telefone'.

DROP TABLE tabela_telefone;