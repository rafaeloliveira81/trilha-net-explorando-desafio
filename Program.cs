using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 35);

// Cria uma nova reserva, passando a suíte e os hóspedes
try
{
    Reserva reserva = new Reserva(diasReservados: 9);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao cadastrar reserva: {ex.Message}");
}

// Exibe a quantidade de hóspedes e o valor da diária
