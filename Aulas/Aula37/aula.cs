using System;
using Internal;

class Base{
    public Base () {
        Console.WriteLine("Construtor da classe base");
    }
}

class Derivada:Base{
    public Derivada () {
        Console.WriteLine("Construtor da classe Derivada");
    }
}

class Derivada2:Derivada{
    public Derivada2 () {
        Console.WriteLine("Construtor da classe Derivada2");
    }
}

class Aula37{
    static void Main () {
        Derivada2 derivada2 = new Derivada2();
    }
}