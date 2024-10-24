using System;
using Internal;

//Classe STATIC
static public class Jogador{
    static public int energia;
    
    static public bool vivo;

    static public string nome;


    static public void iniciar (string n) {
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info () {
        Console.WriteLine("Nome Jogador: {0}", nome);
        Console.WriteLine("Vida do Jogador: {0}", energia);
        Console.WriteLine("Status do Jogador: {0}\n", vivo);
    }
}

class Inimigo {
    static public bool alerta;
    public string nome;

    public Inimigo (string n) {
        alerta = false;
        nome = n;
    }

    public void info () {
        Console.WriteLine("Nome do inimigo: {0}",nome);
        Console.WriteLine("Alerta: {0}\n",alerta);

    }
}

class Aula28{
    static void Main(){

        //Acessando métdoos da classe Jogador
        Jogador.iniciar("Neto");
        Jogador.info();

        Inimigo i1 = new Inimigo("zumbi");
        Inimigo i2 = new Inimigo("dragão");
        Inimigo i3 = new Inimigo("infectado");

        //Mudando o estado da propriedade 'alerta'
        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();
    }
}