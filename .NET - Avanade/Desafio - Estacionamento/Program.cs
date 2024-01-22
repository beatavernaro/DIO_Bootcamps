public class Program
{
    public static void Main(string[] args)
    {
        int opt;
        decimal valorFixo, valorHora;
        //
        do
        {
            Console.WriteLine("Digite o valor fixo por carro: ");
            decimal.TryParse(Console.ReadLine(), out valorFixo);
            if (valorFixo == 0)
            {
                Console.WriteLine("Digite um valor válido.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        } while (valorFixo == 0);

        do
        {
            Console.WriteLine("Digite o valor da hora por carro: ");
            decimal.TryParse(Console.ReadLine(), out valorHora);
            if (valorHora == 0)
            {
                Console.WriteLine("Digite um valor válido.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        } while (valorHora == 0);
        //
        Console.Clear();
        Veiculo veiculo = new(valorFixo, valorHora);
        //
        do
        {
            Console.WriteLine("== Desafio Estacionamento - DIO Decola Tech 2024 ==");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Adicionar veículo \n2 - Remover veículo \n3 - Listar veículos \n4 - Encerrar");
            //
            int.TryParse(Console.ReadLine(), out opt);
            //
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
                    break;
            }
            veiculo.Limpar(2000);
            //
        } while (opt != 4);

    }
}