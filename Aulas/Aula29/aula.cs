using System;
using Internal;

public class Jogador{
    public int energia;
    
    public bool vivo;

    public string nome;

    //Método Construtor
    public Jogador (string n) {
        energia = 100;
        vivo = true;
        nome = n;
    }

    //Método destrutor
    ~Jogador () {
        Console.WriteLine("Jogador: {0} foi destruido", nome);
    }
}

class Aula28{
    static void Main(){
         Jogador j1 = new Jogador("Gau");
         Jogador j2 = new Jogador("Alan");

         Console.WriteLine("Nome do Jogador 1: {0}", j1.nome);
         Console.WriteLine("Nome do Jogador 2: {0}", j2.nome);
    }
}