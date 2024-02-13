
namespace Atividade10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro[] vect = new Cadastro[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.WriteLine("Nome do Inquilino :");
                string nome = Console.ReadLine();
                Console.WriteLine("E-mail do Inquilino :");
                string email = Console.ReadLine();
                Console.WriteLine("Escolha o Quarto de 1 a 10 :");
                int quarto = int.Parse(Console.ReadLine());
                if (quarto < 0 || quarto > 10)
                {
                    Console.WriteLine("Digite um número de quarto válido!!");
                }
                else
                {
                    vect[quarto] = new Cadastro(nome, email);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Os quartos ocupados são: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i].ToString());
                }
            }
        }
    }
}