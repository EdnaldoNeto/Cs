using System;
using Internal;

//Herança
class Veiculo{ //classe vase
    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar () {
        ligado = true;
    }

    public void desligar () {
        ligado = false;
    }

    public string GetLigado () {
        if (ligado) {
            return "sim";
        } else { return "não";}
    }
}

class Carro:Veiculo{ //clase derivada
    public string nome;
    public string cor;

    public Carro(string nome, string cor) {
        this.nome = nome;
        this.cor = cor;
        rodas = 4;
        velMax = 120;
    }
}



class Aula34{
    static void Main () {
        Carro c1 = new Carro("mustang", "preto");

        c1.ligar();

        Console.WriteLine("nome: {0}", c1.nome);
        Console.WriteLine("cor: {0}", c1.cor);
        Console.WriteLine("rodas: {0}", c1.rodas);
        Console.WriteLine("velocidade máxima: {0}", c1.velMax);
        Console.WriteLine("ligado: {0}", c1.GetLigado());

    }
}