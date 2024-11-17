using System;
using Internal;

struct Carro{
    public string nome;
    public string cor;

    public Carro(string nome, string cor) {
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula44{
    static void Main() {

        Carro c1 = new Carro("Mustang", "Carro");
        //c1.nome = "Mustang";
        //c1.cor = "Preto";



        Console.WriteLine("Nome do carro: {0}", c1.nome);
        Console.WriteLine("Cor do carro: {0}", c1.cor);
    }
}