public class Veiculo
{
    private List<string> listaCarros = [];
    private decimal valorFixo = 10.00M;
    private decimal valorHora = 2.00M;

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo: ");
        string? novaPlaca = Console.ReadLine();

        if (string.IsNullOrEmpty(novaPlaca))
        {
            Console.WriteLine("Digite uma placa válida!");
        }
        else if (listaCarros.Contains(novaPlaca))
        {
            Console.WriteLine("Veiculo já estacionado!");
        }
        else
        {
            listaCarros.Add(novaPlaca);
            Console.WriteLine("Veiculo adicionado com sucesso!");
        }
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo: ");
        string? placa = Console.ReadLine();
        if (listaCarros.Contains(placa))
        {
            Console.WriteLine("Digite a quantidade de horas: ");
            if (!int.TryParse(Console.ReadLine(), out int horas))
            {
                Console.WriteLine("Digite um número válido!");
                return;
            }

            Console.WriteLine(CalculaValor(horas));
            listaCarros.Remove(placa);
        }
        else
        {
            Console.WriteLine("Veículo não encontrado!");
        }
    }

    public string CalculaValor(int horas)
    {
        decimal valorTotal = valorFixo + (horas * valorHora);
        return $"Valor Total: {valorTotal.ToString("c")}";

    }

    public void ListarVeiculos()
    {
        if (listaCarros.Count == 0)
        {
            Console.WriteLine("Não há veículos cadastrados! ");
            return;
        }

        foreach (string veiculo in listaCarros)
        {
            Console.WriteLine(veiculo);
        }
        Console.WriteLine("Digite qualquer tecla para voltar.");
        Console.ReadKey();
    }

    public void Limpar(int tempo)
    {
        Thread.Sleep(tempo);
        Console.Clear();
    }
}