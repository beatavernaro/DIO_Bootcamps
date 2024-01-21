public class Program
{
    public static void Main(string[] args)
    {
        int opt = 0;
        Veiculo veiculo = new();

        do
        {
            Console.WriteLine("== Desafio Estacionamento - DIO Decola Tech 2024 ==");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Adicionar veículo \n2 - Remover veículo \n3 - Listar veículos \n4 - Encerrar");
            int.TryParse(Console.ReadLine(), out opt);
            switch (opt)
            {
                case 1:
                    veiculo.AdicionarVeiculo();
                    break;
                case 2:
                    veiculo.RemoverVeiculo();
                    break;
                case 3:
                    veiculo.ListarVeiculos();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    veiculo.Limpar(1000);
                    break;
            }
            veiculo.Limpar(2000);
        } while (opt != 4);

    }
}