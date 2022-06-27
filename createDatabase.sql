-- cria��o do banco de dados para projeto estudo
CREATE SCHEMA IF NOT EXISTS sysManager;

-- marcar banco de dados para uso
USE sysManager;

-- cria��o da tabela de users
CREATE TABLE IF NOT EXISTS sysManager.user
(
 `id` char(36) NOT NULL Default 'uuid()' COMMENT 'Identificador unico do registro',
 `userName` varchar(50) NOT NULL COMMENT 'nome de usu�rio',
 `email` varchar(100) NOT NULL COMMENT 'email do usu�rio',
 `password` varchar(50) NOT NULL COMMENT 'senha do usu�rio',
 `active` bit NOT NULL DEFAULT false COMMENT 'indicador se o usu�rio esta ativo ou unativo',
 `createdDate` DateTime NOT NULL DEFAULT NOW() COMMENT 'Data de cria��o do usu�rio',
 `updatedDate` Datetime NULL COMMENT 'Data de altera��o do reguistro',
 PRIMARY KEY(`id`)
);