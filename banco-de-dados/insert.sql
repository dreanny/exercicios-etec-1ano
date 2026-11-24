USE ClinicaVet;
create table clientes(
id_cliente int auto_increment primary key,
nome varchar(20),
email varchar (20)
);

insert into clientes(id_cliente, nome, email)
values (01,"Maria","maria@gmail.com");
insert into clientes(id_cliente, nome, email)
values (02,"Bella","bella@gmail.com");
insert into clientes(id_cliente, nome, email)
values (03,"Shinobu","shinobu@gmail.com");
insert into clientes(id_cliente, nome, email)
values (04,"Tokito","tokito@gmail.com");
insert into clientes(id_cliente, nome, email)
values (05,"Solivan","solivan@gmail.com");
insert into clientes(id_cliente, nome, email)
values (06,"Ren","ren@gmail.com");

create table animais (
id_animais int auto_increment primary key,
nome_animal varchar (200) not null,
espécie varchar (200),
raca varchar (200),
idade int ,
sexo enum ("m", "f"),
peso float,
id_cliente int, foreign key(id_cliente)references clientes(id_cliente)
);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (01, "Ramon", "Cachorro", "Shitzu", 13, "m", 20, 01);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (02, "Key", "Cachorro", "Border Collie", 13, "f", 10, 02);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (03, "Aurora", "Cachorro", "Pug", 5, "f", 10, 03);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (04, "Ellen", "Cachorro", "Yorkshire terrier", 11, "f", 11, 04);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (05, "Mirian", "Cachorro", "Chow chow", 7, "f", 18, 05);

create table veterinários(
id_veterinario int auto_increment primary key,
nome varchar(20) not null,
crmv varchar (20) unique,
especialidade varchar (20)
);

USE ClinicaVet;
create table clientes(
id_cliente int auto_increment primary key,
nome varchar(20),
email varchar (20)
);

insert into clientes(id_cliente, nome, email)
values (01,"Maria","maria@gmail.com");
insert into clientes(id_cliente, nome, email)
values (02,"Bella","bella@gmail.com");
insert into clientes(id_cliente, nome, email)
values (03,"Shinobu","shinobu@gmail.com");
insert into clientes(id_cliente, nome, email)
values (04,"Tokito","tokito@gmail.com");
insert into clientes(id_cliente, nome, email)
values (05,"Solivan","solivan@gmail.com");
insert into clientes(id_cliente, nome, email)
values (06,"Ren","ren@gmail.com");

create table animais (
id_animais int auto_increment primary key,
nome_animal varchar (200) not null,
espécie varchar (200),
raca varchar (200),
idade int ,
sexo enum ("m", "f"),
peso float,
id_cliente int, foreign key(id_cliente)references clientes(id_cliente)
);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (01, "Ramon", "Cachorro", "Shitzu", 13, "m", 20, 01);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (02, "Key", "Cachorro", "Border Collie", 13, "f", 10, 02);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (03, "Aurora", "Cachorro", "Pug", 5, "f", 10, 03);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (04, "Ellen", "Cachorro", "Yorkshire terrier", 11, "f", 11, 04);
insert into animais(id_animais, nome_animal, espécie, raca, idade, sexo, peso, id_cliente)
values (05, "Mirian", "Cachorro", "Chow chow", 7, "f", 18, 05);

create table veterinários(
id_veterinario int auto_increment primary key,
nome varchar(20) not null,
crmv varchar (20) unique,
especialidade varchar (20)
);

insert into veterinários(id_veterinario, nome, crmv, especialidade)
values (01, "Jonathan", "56", "cardiologia");
insert into veterinários(id_veterinario, nome, crmv, especialidade)
values (02, "Marian", "76", "oncologia");
insert into veterinários(id_veterinario, nome, crmv, especialidade)
values (03, "Karen", "88", "ortopedia");
