using System;
using Internal;

class Aual26 {
    static void Main()
    {
        int n1, n2, div, res;

        n1 = 10;
        n2 = 5;

        div = divide(n1, n2, out res);
        Console.WriteLine("a divisão de {0} e {1} é {2} e o resto {3}", n1, n2, div, res);
    }

    static int divide (int dividendo, int divisor, out int resto)
    {
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }   
}