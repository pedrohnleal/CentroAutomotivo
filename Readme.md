### CRIANDO O BANCO DE DADOS
CREATE DATABASE centroautomotivo;

### USANDO O BANCO DE DADOS
USE centroautomotivo;

### CRIANDO A TABELA PARA CADASTRO DAS INFORMAÇÕES
CREATE TABLE Cadastro(Cliente varchar(255) NOT NULL, Veiculo varchar(50) NOT NULL, Placa varchar(7) NOT NULL, KM int(6) NOT NULL, Telefone varchar(15), Email varchar(100), PRIMARY KEY(Placa));
