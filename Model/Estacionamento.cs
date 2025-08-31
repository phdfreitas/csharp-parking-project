namespace Model.Estacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo no estacionamento:");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"O veículo de placa {placa} já está no estacionamento");
            }
            else
            {
                veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {   
            Console.WriteLine("Informe a placa do veículo para retirar do estacionamento");

            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"Por quantas horas o veículo {placa} ficou no estacionamento?");
                int totalHoras = int.Parse(Console.ReadLine());

                Console.WriteLine($"O carro {placa} ficou {totalHoras} hora(s) no estacionamento e deve pagar R$ {calculaPrecoTotal(totalHoras).ToString("C2")}.");

                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine($"O carro de placa {placa} não está no estacionamento. Verifique se a placa é essa mesmo. ");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Lista de veículos: ");
                int indice = 1;
                foreach (var carro in veiculos)
                {
                    Console.WriteLine($"Carro {indice}.: {carro}");
                    indice++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados");
            }
        }

        private decimal calculaPrecoTotal(decimal totalHorasEstacionamento)
        {
            return precoInicial * precoPorHora * totalHorasEstacionamento;
        }
    }
}