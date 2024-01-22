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
            Console.WriteLine("Digite uma placa v�lida!");
        }
        else if (ListaCarros.Contains(novaPlaca))
        {
            Console.WriteLine("Veiculo j� estacionado!");
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
                Console.WriteLine("Digite um n�mero v�lido!");
        }
        else
        {
            Console.WriteLine("Ve�culo n�o encontrado!");
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
            Console.WriteLine("N�o h� ve�culos cadastrados!");
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