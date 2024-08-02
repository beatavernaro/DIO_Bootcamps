using ReservaHotelDIO.Models;

List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Hospede 1");
Pessoa p2 = new(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva1 = new(diasReservados: 5);
reserva1.CadastrarSuite(suite);
reserva1.CadastrarHospede(hospedes);

Console.WriteLine($"Hospedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diaria: {reserva1.CalcularValorDiaria()}");
