using System;

public class Jogo {
    public string Jogador1;
    public string Jogador2;
    public string Resultado;

    public void Result() {

        if (Jogador1 == "Pedra" && Jogador2 == "Papel") {
            Console.WriteLine("Jogador 2 Venceu");
        }
        else if (Jogador1 == "Papel" && Jogador2 == "Pedra") {
            Console.WriteLine("Jogador 1 Venceu");
        }

        else if (Jogador1 == "Tesoura" && Jogador2 == "Pedra") {
            Console.WriteLine("Jogador 2 Venceu");
        }

        else if (Jogador1 == "Pedra" && Jogador2 == "Tesoura") {
            Console.WriteLine("Jogador 1 Venceu");
        }

        else if (Jogador1 == "Tesoura" && Jogador2 == "Papel"){
            Console.WriteLine("Jogador 1 Venceu");
        }

        else if (Jogador1 == "Papel" && Jogador2 == "Tesoura"){
            Console.WriteLine("Jogador 2 Venceu");
        }

        else{
            Console.WriteLine("A Partida terminou empatada!!");
        }
    }
}