using System;

public interface Veiculo{ //Interfaces
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo, Combate{
    protected bool ligado;
    protected int municao = 100;

    public Carro() {

    }

    public void ligar() {
        this.ligado = true;
    }

    public void desligar() {
        this.ligado = false;
    }

    public void info() {

    }

    public void disparar() {

    }
}

class Aula43{
    static void Main() {

    }
}