using System;
using Internal;

abstract class Veiculo { //classe abstrata
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;

    public Veiculo() {
        ligado = false;
        velMaxima = 0;
    }

    public void setLigado(bool ligado) {
        this.ligado = ligado;
    }

    public int getVelAtual() {
        return velAtual;
    }

    abstract public void aceleracao(int multi); //método abstrato
}

class Carro:Veiculo{
    public Carro() {
        velMaxima = 120;
    }

    public override void aceleracao(int multi)
    {
        velAtual+=10*multi;
    }
}

class Aula{

    static void Main() {

        Carro c1 = new Carro();

        c1.aceleracao(8);

        Console.WriteLine("Velocidade máxima {0}", c1.getVelAtual());
    }
}