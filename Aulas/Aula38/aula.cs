using System;
using Internal;

class Base{
    public Base () {
        Console.WriteLine("Construtor da classe base");
    }

    virtual public void info () { //Método virtual
        Console.WriteLine("Base");
    }
}

class Derivada:Base{
    public Derivada () {
        Console.WriteLine("Construtor da classe Derivada");
    }

     override public void info () {
        Console.WriteLine("Derivada");
    }
}

class Derivada2:Derivada{
    public Derivada2 () {
        Console.WriteLine("Construtor da classe Derivada2");
    }

    public override void info () {
        Console.WriteLine("Derivada2");
    }
}

class Aula37{
    static void Main () {
        Base Ref;
        Derivada derivada = new Derivada();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada;
        Ref.info();
    }
} 