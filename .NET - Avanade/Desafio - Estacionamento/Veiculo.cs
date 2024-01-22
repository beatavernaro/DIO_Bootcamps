public class Veiculo
{
    private List<string> ListaCarros = [];
    private decimal ValorFixo { get; set; }
    private decimal ValorHora { get; set; }

    public Veiculo(decimal valorFixo, decimal valorHora)
    {
        ValorFixo = valorFixo;
        ValorHora = valorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo: ");
        string? novaPlaca = Console.ReadLine();

        if (string.IsNullOrEmpty(novaPlaca))
        {
            Console.WriteLine("Digite uma placa válida!");
        }
        else if (ListaCarros.Contains(novaPlaca))
        {
            Console.WriteLine("Veiculo já estacionado!");
        }
        else
        {
            ListaCarros.Add(novaPlaca);
            Console.WriteLine("Veiculo adicionado com sucesso!");
        }
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo: ");
        string? placa = Console.ReadLine();

        if (ListaCarros.Contains(placa))
        {
            Console.WriteLine("Digite a quantidade de horas: ");
            if (int.TryParse(Console.ReadLine(), out int horas))
            {
                Console.WriteLine(CalculaValor(horas));
                ListaCarros.Remove(placa);
                Console.WriteLine("Digite qualquer tecla para voltar.");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Digite um número válido!");
        }
        else
        {
            Console.WriteLine("Veículo não encontrado!");
        }
    }

    public string CalculaValor(int horas)
    {
        decimal valorTotal = ValorFixo + (horas * ValorHora);
        return $"Valor Total: {valorTotal.ToString("c")}";
    }

    public void ListarVeiculos()
    {
        if (ListaCarros.Count == 0)
        {
            Console.WriteLine("Não há veículos cadastrados!");
            return;
        }

        foreach (string veiculo in ListaCarros)
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