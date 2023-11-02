using System.Globalization;
using DesafioHotel.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new (
    nome: "turista",
    sobrenome: "1"
);
Pessoa p2 = new (
    nome: "turista",
    sobrenome: "2"
);
// Pessoa p3 = new (
//     nome: "turista",
//     sobrenome: "3"
// );

hospedes.Add(p1);
hospedes.Add(p2);
// hospedes.Add(p3);

Suite s1 = new(
    tipoSuite: "Casal",
    capacidade: 2,
    valorDiaria: 200
);

Reserva r1 = new(
    diasReservados: 15
);

r1.FazerReserva(s1, hospedes);

int quantidadeHospedes = r1.ObterQuantidadeHospedes();
decimal valorHospedagem = r1.CalcularValorHospedagem();

Console.WriteLine($"Hóspedes: {quantidadeHospedes}");
Console.WriteLine($"Valor da Hospedagem: {valorHospedagem.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"))}");


