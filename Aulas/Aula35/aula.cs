using System;
using Internal;

//Herança
class Veiculo{ //classe vase
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo (int rodas){
        this.rodas = rodas;
    }

    public void ligar () {
        ligado = true;
    }

    public void desligar () {
        ligado = false;
    }

    public string GetLigado () {
        return (ligado?"sim":"não"); //Operador ternário
    }

    public int GetRodas () {
        return rodas;
    }

    public void SetRodas (int rodas) {
        if (rodas < 0) {
            this.rodas = 0;
        } else if (rodas > 40) {
            this.rodas = 40;
        } else {
            this.rodas = rodas;
        }
    }
}

class Carro:Veiculo{ //classe derivada
    public string nome;
    public string cor;

    public Carro(string nome, string cor):base(4) {
        desligar();
        this.nome = nome;
        this.cor = cor;
        velMax = 120;
    }
}

class CarroCombate:Carro{//classe derivada
    public int municao;
    public CarroCombate ():base("carro combate", "verde") {
        municao = 100;
        SetRodas(6);
    }
}



class Aula34{
    static void Main () {
        Carro c1 = new Carro("mustang", "preto");
        CarroCombate cc1 = new CarroCombate();

        Console.WriteLine("nome: {0}", c1.nome);
        Console.WriteLine("cor: {0}", c1.cor);
        Console.WriteLine("rodas: {0}", c1.GetRodas());
        Console.WriteLine("velocidade máxima: {0}", c1.velMax);
        Console.WriteLine("ligado: {0}\n", c1.GetLigado());

        Console.WriteLine("nome: {0}", cc1.nome);
        Console.WriteLine("cor: {0}", cc1.cor);
        Console.WriteLine("rodas: {0}", cc1.GetRodas());
        Console.WriteLine("velocidade máxima: {0}", cc1.velMax);
        Console.WriteLine("ligado: {0}", cc1.GetLigado());
        Console.WriteLine("Munição: {0}", cc1.municao);

    }
}