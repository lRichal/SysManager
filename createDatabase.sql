-- criação do banco de dados para projeto estudo
CREATE SCHEMA IF NOT EXISTS sysManager;

-- marcar banco de dados para uso
USE sysManager;

-- criação da tabela de users
CREATE TABLE IF NOT EXISTS sysManager.user
(
 `id` char(36) NOT NULL Default 'uuid()' COMMENT 'Identificador unico do registro',
 `userName` varchar(50) NOT NULL COMMENT 'nome de usuário',
 `email` varchar(100) NOT NULL COMMENT 'email do usuário',
 `password` varchar(50) NOT NULL COMMENT 'senha do usuário',
 `active` bit NOT NULL DEFAULT false COMMENT 'indicador se o usuário esta ativo ou unativo',
 `createdDate` DateTime NOT NULL DEFAULT NOW() COMMENT 'Data de criação do usuário',
 `updatedDate` Datetime NULL COMMENT 'Data de alteração do reguistro',
 PRIMARY KEY(`id`)
);