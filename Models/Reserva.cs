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
            // Caso hospedes <= tamanho da suite
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Caso hospedes > tamanho da suite
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Valor diaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Valor diaria com desconto (10% caso dias reservados >= 10)
            if (DiasReservados >= 10)
            {
                valor *= 0.9m; // Desconto de 10% (1 - 0.1 = 0.9)
            }

            return valor;
        }
    }
}
