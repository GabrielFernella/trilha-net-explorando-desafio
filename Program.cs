﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "hospede 1");
Pessoa p2 = new Pessoa(nome: "hospede 2");
Pessoa p3 = new Pessoa(nome: "hospede 3");
Pessoa p4 = new Pessoa(nome: "hospede 4");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Platinum", capacidade: 4, valorDiaria: 254);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Qtd Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diaria: {reserva.CalcularValorDiaria()}");