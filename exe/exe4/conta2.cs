using Internal;
using System;

class Conta{
    protected string nomeBanco;
    protected double saldo;
    protected double deposito;
    protected double sacar;

    public Conta (string nomeBanco, double saldo) {
        this.nomeBanco = nomeBanco;
        this.saldo = saldo;
    }

    public void saque (double sacar) {
        this.sacar = sacar;
        saldo -= sacar;
    }

    public void depositar (double deposito) {
        this.deposito = deposito;
        saldo += deposito;
    }

    public void info () {
        Console.WriteLine("Saldo atual da conta: {0:c}", saldo);
    }
}

class Teste{
    static void Main () {
        Conta c1 = new Conta("Itaú", 1000);

        c1.depositar(500);
        c1.saque(1800);
        c1.depositar(700);

        c1.info();
    }
}

