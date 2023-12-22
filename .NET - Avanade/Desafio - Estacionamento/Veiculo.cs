public class Veiculo{
    private List<string> listaCarros = new List<string>();
    private decimal valorFixo = 10.00M;
    private decimal valorHora = 2.00M;

    public void AdicionarVeiculo(){
        Console.WriteLine("Digite a placa do veiculo: ");
        listaCarros.Add(Console.ReadLine());
        Console.WriteLine("Veiculo adicionado com sucesso! ");
        Thread.Sleep(2000);
        Console.Clear();
    }

    public void RemoverVeiculo(){
        Console.WriteLine("Digite a placa do veiculo: ");
        string placa = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de horas: ");
        int horas = int.Parse(Console.ReadLine());
        Console.WriteLine(CalculaValor(horas));
        listaCarros.Remove(placa);
        Thread.Sleep(3000);
    }

    public string CalculaValor(int horas){
        decimal valorTotal = valorFixo + (horas * valorHora);
        return $"Valor Total: {valorTotal}";
    }

    public void ListarVeiculos(){
        foreach(string veiculo in listaCarros){
            Console.WriteLine(veiculo);
        }
        Console.WriteLine("Digite qualquer tecla para voltar.");
        Console.ReadKey();
    }
}