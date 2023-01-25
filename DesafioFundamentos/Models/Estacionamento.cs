namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
            private decimal precoInicial = 0;
            private decimal precoPorHora = 0;
            private List<string> veiculos = new List<string>();

            public Estacionamento(decimal precoInicial, decimal precoPorHora)
            {
                this.precoInicial = precoInicial;
                this.precoPorHora = precoPorHora;
            }

            public void AdicionarVeiculo()
            {
                Console.WriteLine("Digite a placa do veículo para estacionar");
                string placa = Console.ReadLine();
                veiculos.Add(placa);
            }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            if (veiculos.Contains(placa))
            {
                veiculos.Remove(placa);
                Console.WriteLine("Veículo removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
              Console.WriteLine("Não existe nenhum veiculo na lista.");
            }
            else
            {
                Console.WriteLine("Os veículos estacionados são ");
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine(veiculos[i]);
                }
            }
        }
    }
}
