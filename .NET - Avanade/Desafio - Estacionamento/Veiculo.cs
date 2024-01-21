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
            Console.WriteLine("Digite uma placa v�lida!");
        }
        else if (listaCarros.Contains(novaPlaca))
        {
            Console.WriteLine("Veiculo j� estacionado!");
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
                Console.WriteLine("Digite um n�mero v�lido!");
                return;
            }

            Console.WriteLine(CalculaValor(horas));
            listaCarros.Remove(placa);
        }
        else
        {
            Console.WriteLine("Ve�culo n�o encontrado!");
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
            Console.WriteLine("N�o h� ve�culos cadastrados! ");
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