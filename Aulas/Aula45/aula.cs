using System;
using Internal;

struct Carro{
    public string nome;
    public string cor;

    public Carro(string nome, string cor) {
        this.nome = nome;
        this.cor = cor;
    }

    public void Info() {
        Console.WriteLine("Nome do carro: {0}", this.nome);
        Console.WriteLine("Cor do carro: {0}", this.cor);
    }
}

class Aula45{
    static void Main() {

        Carro c1 = new Carro("Mustang", "Preto");

        c1.Info();
    }
}