using System.Text;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            // *IMPLEMENTENTADO*
            if (hospedes.Count <= Suite.Capacidade)
            {

                Hospedes = hospedes;
            }
            else
            {

                // *IMPLEMENTENTADO*
                throw new Exception("Quantidade de pessoas execede o limite permitido");
            }


        }


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            // *IMPLEMENTENTADO*

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            // *IMPLEMENTENTADO*

            decimal valor = DiasReservados * Suite.ValorDiaria;

            // *IMPLEMENTENTADO*
            decimal valorFinal;
            if (DiasReservados >= 10)
            {

                decimal valorDesconto = valor * 0.10m;
                valorFinal = valor - valorDesconto;
            }
            else
            {
                valorFinal = valor;
            }

            return valorFinal;
        }
    }
}