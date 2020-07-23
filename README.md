# Rafa
<h1>Cadastro de Clientes</h1>

Esse projeto foi feito em Asp.Net.Core MVC, Entity Framework e Bootstrap.
É um projeto focado em cadastro de clientes.

<h4>Pré-requisitos :</h4>

1. <b>IDE :</b> Visual Studio 2017;
1. <b>SGBD:</b> SQL DEVELOPER;
1. <b>Packages Nuget:</b> Oracle.EntityFrameworkCore, Oracle.ManagedDataAcess.Core;
1. <b>appsettings.json:</b> Configurar de acordo com seus dados do banco;
1. <b>Query para criação do banco:</b>

CREATE TABLE CLIENTES 
(
  CD_CLIENTE NUMBER NOT NULL 
, NM_CLIENTE VARCHAR2(50 BYTE) NOT NULL 
, TIPO VARCHAR2(2 BYTE) NOT NULL 
, NR_DOCUMENTO VARCHAR2(17 BYTE) NOT NULL 
, DT_CADASTRO DATE NOT NULL 
, NR_TELEFONE VARCHAR2(15 BYTE) NOT NULL 
, ISDELETED CHAR(1 BYTE) NOT NULL 
, CONSTRAINT CLIENTES_PK PRIMARY KEY 
  (
    CD_CLIENTE 
  )
  USING INDEX 
  (
      CREATE UNIQUE INDEX CLIENTES_PK ON CLIENTES (CD_CLIENTE ASC) 
      LOGGING 
      TABLESPACE TBSPC_ALUNOS 
      PCTFREE 10 
      INITRANS 2 
      STORAGE 
      ( 
        INITIAL 65536 
        NEXT 1048576 
        MINEXTENTS 1 
        MAXEXTENTS UNLIMITED 
        BUFFER_POOL DEFAULT 
      ) 
      NOPARALLEL 
  )
  ENABLE 
) 
LOGGING 
TABLESPACE TBSPC_ALUNOS 
PCTFREE 10 
INITRANS 1 
STORAGE 
( 
  INITIAL 65536 
  NEXT 1048576 
  MINEXTENTS 1 
  MAXEXTENTS UNLIMITED 
  BUFFER_POOL DEFAULT 
) 
NOCOMPRESS 
NO INMEMORY 
NOPARALLEL;

<h4>Autoria e Contribuições</h4>

1. Contribuições : Fiap
1. Autoria : Rafael Carvalho Füllenbach
