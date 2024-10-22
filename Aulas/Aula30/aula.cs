using System;
using Internal;

public class Jogador{
    public int energia;
    
    public bool vivo;

    public string nome;

    //Método Construtor
    //Sobrecarga de construtores
    public Jogador () {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

    public Jogador (string n) {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador (string n, int e) {
        energia = e;
        vivo = true;
        nome = n;
    }

    public Jogador (string n, int e, bool v) {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info () {
        Console.WriteLine("Nome Jogador: {0}", nome);
        Console.WriteLine("Vida do Jogador: {0}", energia);
        Console.WriteLine("Status do Jogador: {0}\n", vivo);
    }
}

class Aula28{
    static void Main(){
         Jogador j1 = new Jogador("Gau", 77, true);
         Jogador j2 = new Jogador("Alan", 0, false);

         j1.info();
         j2.info();

    }
}