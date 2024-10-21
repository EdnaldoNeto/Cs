using System;
using Internal;

class Aula27{

    static void Main() {
        soma(1, 12, 10);
    }

    //Argumento Params
    static void soma(params int[]n)
    {
        int som = 0;
        if (n.Length == 0)
        {
            Console.WriteLine("Não existem valores a serem somados");
        } else if (n.Length < 2 ) {
            Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
        } else {
            for (int i = 0; i < n.Length; i++)
            {
                som+=n[i];
            }
            Console.WriteLine("A soma do valores é {0}", som);
        }
    }
}