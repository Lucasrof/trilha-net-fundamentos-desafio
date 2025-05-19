namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 4;
        private decimal precoPorHora = 2;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            string placa = Console.ReadLine().ToUpper();
            

            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa {placa} foi removido e o valor total é de: R$ {valorTotal} reais");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
           
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
