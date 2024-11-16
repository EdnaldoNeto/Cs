using System;
using Internal;

sealed class Veiculo { //classe sealed não pode ser herdada
    protected int Qroda;
    protected string nome;
    protected string cor;
    protected int Qpessoas;

    public Veiculo(int rodas, string nome, string cor, int pessoas) {
        this.Qroda = rodas;
        this.nome = nome;
        this.cor = cor;
        this.Qpessoas = pessoas;
    }

    public void Inf() {
        Console.WriteLine("Nome do Veiculo: {0}", nome);
        Console.WriteLine("Quantidade de rodas do Veiculo: {0}", Qroda);
        Console.WriteLine("Cor do Veiculo: {0}", cor);
        Console.WriteLine("Quantidade de bancos do Veiculo: {0}", Qpessoas);
    }

}

class Aula40{
    static void Main() {
        Veiculo v1 = new Veiculo(4, "Mustag", "Preto", 5);

        v1.Inf();
    }
}