using System;
using Internal;

class Jogador {

    //Propriedades privates
    private string nome;
    private int energia;

    public Jogador (string nome) {
        this.nome = nome;
        energia = 100;
    }

    //Para acessar as propriedades privates devemos usar esse método
    public int GetEnergia () {
        return energia;
    }

    public string GetNome () {
        return nome;
    }

    public void SetEnergia(int e) {
        if (e < 0) {
            if (energia+e < 0) {
                energia = 0;
            } else { 
                energia += e;
            }
        } else if (e > 0) {
            if (energia+e > 100) {
                energia = 100;
            } else {
                energia += e;
            }
        }
    }
}

class Aula33{
    static void Main () {
        Jogador j1 = new Jogador("Neto");

        j1.SetEnergia(-10);

        Console.WriteLine("Nome do jogador1: {0}", j1.GetNome());
        Console.WriteLine("Energia do jogador1: {0}", j1.GetEnergia());
    }
}