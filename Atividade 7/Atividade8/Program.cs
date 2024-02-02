using System;
using Atividade8;
    public class Program{
    static void Main() {
       Pessoa p = new Pessoa();
      Console.WriteLine("Digite o nome da pessoa: ");
        p.Nome = Console.ReadLine();  
        Console.WriteLine("Digite a idade da pessoa: ");
        p.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura da pessoa: ");
        p.Altura= double.Parse(Console.ReadLine());
        
        Console.WriteLine("A pessoa está dormindo?");
        string dormir = Console.ReadLine();
        p.Dormir(dormir);

        if (dormir == "N") {
            Console.WriteLine("Digite a quantidade de passos que a pessoa deu: ");
            int passos = int.Parse(Console.ReadLine());
            p.Andando(passos);
        }

            if (dormir == "N") {
                Console.WriteLine("Hoje é o aniversário da pessoa?: ");
                string aniversario = Console.ReadLine();
                p.Parabens(aniversario);
            }

            Console.WriteLine($"Aqui estão as informações da Pessoa {p.Nome}: ");
            p.MostrarInformacoes();
    }
        
      
}


