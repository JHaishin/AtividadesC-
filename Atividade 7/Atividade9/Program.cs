using Atividade9;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do titular da conta: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o número da conta: ");
        int num_conta = int.Parse(Console.ReadLine());
        Console.WriteLine("Deseja realizar um depósito inicial?");
        char resposta = char.Parse(Console.ReadLine());

        double dep_inicial = 0.0;
        if (resposta == 'S')
        {
            Console.WriteLine("Digite o valor do depósito: ");
            dep_inicial = double.Parse(Console.ReadLine());
        }

        Banco b = new Banco(nome, num_conta, dep_inicial); 

        Console.WriteLine("Dados da Conta: ");
        Console.WriteLine(b.ToString());

        Console.Write("Digite um valor para depósito: ");
        double valorDeposito = double.Parse(Console.ReadLine());
        b.Deposito(valorDeposito);

        Console.WriteLine("Dados da Conta: ");
        Console.WriteLine(b.ToString());

        Console.Write("\nEntre um valor para saque: ");
        double valorSaque = double.Parse(Console.ReadLine());
        b.Saque(valorSaque);

        Console.WriteLine("Dados da Conta: ");
        Console.WriteLine(b.ToString());
    }
}