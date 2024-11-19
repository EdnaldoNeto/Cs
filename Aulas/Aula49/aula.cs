using System;
using Internal;

class Mat{ //Métodos e variáveis estáticos
     public static double pi = 3.14;
     public static int dobro(int x) {
        return x*2;
     }
}

class Aula49{
    static void Main() {
        double vpi = Mat.pi;

        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(5));
    }
}