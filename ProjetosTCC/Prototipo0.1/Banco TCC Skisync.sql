Create database Skisync
go
use Skisync
go
Create table CadCliente (
IdCli int identity primary key,
NomeCli varchar(40) not null,
CpfCli char(15) not null unique,
EmailCli varchar(50) not null,
FoneCli varchar(24) not null,
EnderecoCli varchar(50) not null,
CepCli varchar(10) not null,
CidadeCli varchar(20) not null,
);

Create table CadVeiculo(
IdVeiculo int identity primary key,
MarcaVeiculo varchar(40) not null,
ModeloVeiculo varchar(40) not null,
PlacaVeiculo varchar(40) not null,
IdCli int references CadCliente(IdCli)
);

Create table Servico(
IdServico int identity primary key,
DescricaoServico varchar(100) not null,
CustoServico decimal(10,2) not null
);

Create table Agendamento(
IdAgendamento int identity primary key,
IdCli int references CadCliente(IdCli),
IdVeiculo int references CadVeiculo(IdVeiculo),
DataAgendamento date not null,
horario time not null,
IdServico int references Servico(IdServico)
);

Create table Id_Login(
Id int primary key identity,
Email varchar(50) unique not null,
Senha varchar(20) not null
)

INSERT INTO Id_Login(Email, Senha) 
VALUES
('maria@teste2.com','1234'),
('joao@test.com', '4321')

INSERT INTO CadCliente (NomeCli, CpfCli, EmailCli, FoneCli, EnderecoCli, CepCli, CidadeCli) 
VALUES 
('João Silva', '123.456.789-00', 'joao@test.com', '(11) 91234-5678', 'Rua A, 123', '12345-678', 'São Paulo'),
('Maria Souza', '987.654.321-00', 'maria@teste2.com', '(21) 98765-4321', 'Av. B, 456', '87654-321', 'Rio de Janeiro');


INSERT INTO CadVeiculo (MarcaVeiculo, ModeloVeiculo, PlacaVeiculo, IdCli) 
VALUES 
('Toyota', 'Corolla', 'ABC-1234', 1),
('Honda', 'Civic', 'XYZ-9876', 2);

INSERT INTO Servico (DescricaoServico, CustoServico) 
VALUES 
('Troca de óleo', 120.00),
('Alinhamento e balanceamento', 200.00);

INSERT INTO Agendamento (IdCli, IdVeiculo, DataAgendamento, horario, IdServico) 
VALUES 
(1, 1, '2024-11-01', '10:00:00', 1),
(2, 2, '2024-11-02', '14:30:00', 2);

Select CadCliente.NomeCli, CadCliente.CpfCli, CadVeiculo.MarcaVeiculo, CadVeiculo.ModeloVeiculo, CadVeiculo.PlacaVeiculo 
	from CadCliente join CadVeiculo 
		on CadCliente.IdCli = CadVeiculo.IdCli
			where CadCliente.CpfCli = '123.456.789-00';

Select CadCliente.NomeCli, CadCliente.CpfCli, CadVeiculo.MarcaVeiculo, CadVeiculo.ModeloVeiculo, CadVeiculo.PlacaVeiculo 
	from CadCliente join CadVeiculo 
		on CadCliente.IdCli = CadVeiculo.IdCli
			where CadCliente.CpfCli = '987.654.321-00';

select CadCliente.NomeCli, Servico.DescricaoServico, Servico.CustoServico 
	from Agendamento join CadCliente
		on Agendamento.IdCli = CadCliente.IdCli join Servico
			on Agendamento.IdServico = Servico.IdServico
				where Servico.CustoServico > 150;

select*from CadCliente

select * from Id_Login
use master
drop database Skisync

update CadCliente set NomeCli= 'João Freitas' where IdCli=1