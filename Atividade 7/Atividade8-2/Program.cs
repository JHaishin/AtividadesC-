using System;
public class Program{
    static void Main(){
        Jogo j = new Jogo();
        Console.WriteLine("Bem-vindo ao Jokempo do Juan");
        Console.WriteLine("");
        Console.WriteLine("Jogador 1, digite a sua jogada: ");
        j.Jogador1 = Console.ReadLine();
        Console.WriteLine("Jogador 2, digite a sua jogada: ");
        j.Jogador2 = Console.ReadLine();

        j.Result();
    }
}