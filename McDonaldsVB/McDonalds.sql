create database mcdonalds;
use mcdonalds;

create table contas (username varchar(20),passwords varchar(20),nome varchar(50),morada varchar(100),Contato varchar(9), Email varchar(30));
create table bebidas (id_bebida int primary key auto_increment,nome varchar(20), preco decimal(10,2));
Create table comida  (id_comida int primary key auto_increment,nome varchar(20), preco decimal(10,2));
create table sobremesa (id_sobremesa int primary key auto_increment,nome varchar(20), preco decimal(10,2));
create table acompanhamentos_molhos (id_acompanhamento int primary key auto_increment,nome varchar(20), preco decimal(10,2));
create table faturas (id_fatura int primary key, valor decimal (10.2));




insert into contas values
("admin","admin", "Marcelo Carriço","--","934569118","youremail@gmail.com");

insert into comida (nome ,preco) values 
("Big Mac",5.70),("Double Cheeseburguer",5.50),("CBO",7.60),
("McChiken",5.50),("McRoyal Bacon",6.50),("Big Tasty Single",7.60),
("McCrispy Original",8.30),("McCrispy Creamy BBQ",8.30),("Big Tasty Double",9.60),
("McRoyal Deluxe",6.5),("McRoyal Cheese", 6.50),("McPlant", 6.5),
("Maestro Cogumelos e Maionese Trufada",8.5),("Filet-o-fish",5.50),("Happy meal Cheeseburger",4.95),
("Happy meal Chiken Nuggets",4.95),("Happy meal Hamburger",4.95),("Happy meal Chiken Mayo",4.95),
("Happy meal Douradinhos",4.95),("Salada Mista",2.70);

insert into bebidas (nome, preco) values
("Agua 0.33cl",1.50),("Agua 0.5cl", 1.80),("Coca-cola",2.00),("Coca-Cola Zero",2.00),
("Lipton Pessego",2.00),("Fanta Laranja",2.00),("Limonada",2.00),
("Compal Manga/Laranja",2.20),("Bongo Manga",2.00),("Um Bongo 8 frutos",2.00),
("Compal Pessego",2.20),("Compal Laranja do Algarve",2.20),("Lipton Chá Verde Hortela e Lima",2.00);

insert into sobremesa (nome,preco) values 
("McFlurry Lion",3.57),("McFlurry M&M's",3.12),("McFlurry Oreo",3.12),
("McFlurry Snikkers",3.57),("McFlurry kit-kat",3.12),("Sunday Chocolate",2.10),
("Sundae Caramelo",2.10),("Sunday Morango",2.10),("Abacaxi",1.70),
("Fatias Maçã",1.70),("Polpa Fruta",1.70);

insert into acompanhamentos_molhos (nome,preco) values
("ShareBox 10 McNuggets",4.90),("ShareBox 20 McNuggets",8.50),("Chicken McNuggets 4",2.80),
("Chicken Delight's",3.20),("McDouradinhos",3.20),("CheeseBurguer",2.20),
("Chicken Bacon",3.20),("Hamburguer",2.00),("Double Cheeseburger",5.50),
("McChicken",5.50),("Snack McWrap Chicken Cheese",3.20),("Snack McWrap Chicken Mayo",3.20),
("Cenouras Baby",1.70),("Molho Maionese e alho",0.90),("Molho Batatas",0.90),
("Molho agridoce",0.90),("Molho Barbecue",0.90);




select avg(valor) from faturas;



