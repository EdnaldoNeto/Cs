using System;
using Internal;

class Conta{

    protected string nomeConta;
    protected double saldo;

    public Conta (string nomeConta, double saldo) {
        this.nomeConta = nomeConta;
        this.saldo = saldo;
    }
    
    virtual public void info () {
        Console.WriteLine("Nome da conta {0}", nomeConta);
        Console.WriteLine("Saldo da conta {0:c}", saldo);
    }
}

class Saque:Conta{
    
    protected double valorSaque;

    public Saque (double valorSaque, string nomeConta, double saldo):base(nomeConta, saldo) {
        this.valorSaque = valorSaque;
        this.saldo -= valorSaque;
    }

    override public void info ()
    {
        Console.WriteLine("valor do Saque: {0:c}", valorSaque);
        Console.WriteLine("Nome da conta: {0}", nomeConta);
        Console.WriteLine("Saldo atual da conta: {0:c}", saldo);
    }
}

class Depositar:Conta{
    protected double valor;

    public Depositar (double valor, string nomeConta, double saldo):base(nomeConta, saldo) {
        this.valor = valor;
        this.saldo += valor;
    }

    public override void info()
    {
        Console.WriteLine("Nome do banco: {0}", nomeConta);
        Console.WriteLine("Valor do depósito: {0:c}", valor);
        Console.WriteLine("Saldo da conta Atual: {0:c}", saldo);
    }

}

class Teste{
    static void Main () {
        Depositar c1 = new Depositar(500, "Itaú", 1200);

        c1.info();
    }
}