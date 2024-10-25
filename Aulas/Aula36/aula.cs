using System;
using Internal;

class Veiculo{ //Base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo (int velMax) {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool GetLigado () {
        return ligado;
    }

    public int GetVelMax () {
        return velMax;
    }
}

class Carro:Veiculo{ //derivada de veiculo
    public string nome;

    public Carro (string nome, int vm):base (vm) {
        this.nome = nome;
        ligado = true;
    } 
}


class Aula36{
    static void Main () {

        Carro car1 = new Carro("mustang", 140);

        Console.WriteLine("Nome do carro:.... {0}", car1.nome);
        Console.WriteLine("Velocidade máxima: {0}",car1.GetVelMax());
        Console.WriteLine("Ligado:........... {0}", car1.GetLigado());

    }
}