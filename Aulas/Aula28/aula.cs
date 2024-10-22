using System;
using Internal;

public class Jogador{
    public int energia = 100;
    public bool vivo = true;
}

class Aula28{
    static void Main(){
         Jogador j1 = new Jogador();
         Jogador j2 = new Jogador();
         Jogador j3 = new Jogador();
         Jogador j4 = new Jogador();

         //Alterando o valor da propriedade energia de j1
         j1.energia = 50;
         

         Console.WriteLine("Energia do Jogador 1: {0}%", j1.energia);
    }
}