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

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);


// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("----- HOTEL VIVA A VIDA -----");
Console.WriteLine("");

Console.Write("=> Adicione os dias que foram reservados: ");

Reserva reserva = new Reserva(diasReservados: Convert.ToInt32(Console.ReadLine()));
Console.Clear();

Console.WriteLine("----- HOTEL VIVA A VIDA -----");
Console.WriteLine("");

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"=> Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"=> Valor diária: {reserva.CalcularValorDiaria()}");

