public class Program
{
    public static void Main(string[] args)
    {
        int opt = 0;
        Console.WriteLine("== Desafio Estacionamento - DIO Decola Tech 2024 ==");
        Veiculo veiculo = new Veiculo();

        do
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Adicionar veículo \n2 - Remover veículo \n3 - Listar veículos \n4 - Encerrar");
            opt = int.Parse(Console.ReadLine());
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
            }

        } while (opt != 4);

    }
}