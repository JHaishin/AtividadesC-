using System;

namespace Atividade8;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public double Altura;
    public string Dormindo;
    public int Andar;
    public string Aniversario;
    public int Estado;

    public void Dormir(string dormir)
    {
        if (dormir == "N") {
            Console.WriteLine("A pessoa está acordada!!");
            Estado = 0;
        }

        else {
            Console.WriteLine("A pessoa está dormindo, não pertube!!");
            Estado = 1;

        }

    }

         public void Andando(int passos)
    
    {
        if (passos >0) {
            Console.WriteLine($"A pessoa {Nome} deu {passos} passos!!");
            Andar += passos;
            

        }

        else {
            Console.WriteLine("A pessoa está parada, ou dormindo, não perturbe!!!");
        }
    }

    public void Parabens(string aniversario)
    {
        if (aniversario == "Sim") {
            Console.WriteLine($"Parabéns {Nome}, pelos seus {Idade} anos");
            Idade += 1;
        }

        else {
            Console.WriteLine("Não é o seu aniversário!!");
        }
    }

    public void MostrarInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Altura: {Altura:F2}");
        Console.WriteLine($"{Nome} deu {Andar} passos");
        
    }

    }

