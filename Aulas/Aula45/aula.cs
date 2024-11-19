using System;
using Internal;

struct Carro{
    public string nome;
    public string cor;

    public void Info() {
        Console.WriteLine("Nome do carro: {0}", this.nome);
        Console.WriteLine("Cor do carro: {0}", this.cor);
        Console.WriteLine("------------------");

    }
}

class Aula45{
    static void Main() {

        Carro[] carros = new Carro[3];

        carros[0].nome = "Mustag";
        carros[0].cor = "Preto";

        carros[1].nome = "BMW";
        carros[1].cor = "Prata";

        carros[2].nome = "Camaro";
        carros[2].cor = "Branco";


        for (int i = 0; i < carros.Length; i++) {
            carros[i].Info();
        }
    }
}