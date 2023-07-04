-- Active: 1683856497522@@127.0.0.1@3306@dbmobiliteservice
drop database dbMobiliteService;
create database dbMobiliteService;

use dbMobiliteService;








create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100) not null,
email varchar(100),
cpf char(14) not null,
telefone char(15),
sexo varchar(10) check(sexo in ('Feminino','Masculino')),
endereco varchar(100),
numero char(10),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
primary key(codFunc));

create table tbUsuarios(
codUsu int not null auto_increment,
nomeUsu varchar (20) not null,
senhaUsu varchar(20) not null,
primary key(codUsu));

create table tbClientes(
codCli int not null auto_increment,
nome varchar(100) not null,
email varchar(100),
cpf char(14) not null,
telefone char(15),
sexo varchar(10)  check(sexo in ('Feminino','Masculino')),
endereco varchar(100),
numero char(10),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
primary key(codCli));

create table tbServicos(
codServ int not null auto_increment,
descricao varchar(100),
tipo int default 0 check(tipo >=0),
valor decimal(9,2) default 0 check(valor >=0),
primary key(codServ));

create table tbChamados(
codCham int not null auto_increment,
codCli int not null,
codFunc int not null,
codServ int not null,
primary key(codCham),
foreign key(codCli) references tbClientes(clodCli),
foreign key(codFunc) references tbFuncionarios(codFunc),
foreign key(codServ) references tbServicos(codServ));

insert into tbFuncionarios (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado) values ('felipe gomes', 'felipe.gomessan@gmail.com','21342-344','(34) 54446-3535','masculino','rua cristal',233,32432-545,'canduva','ribeirinho','bh');
insert into tbClientes (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado) values ('felipe gomes', 'felipe.gomessan@gmail.com','21342-344','(34) 54446-3535','masculino','rua cristal',233,32432-545,'canduva','ribeirinho','bh');
insert into tbUsuarios (nomeUsu, senhaUsu) values ('felipe@gomes','123456xs');
insert into tbServicos (descricao, tipo, valor) values ('Suporte do tipo N1', '1', 'à combinar');

