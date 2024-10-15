using System;
using Internal;

class Aula19{
    static void Main(){

        /*for(int i = 1; i <= 10; i++){
            Console.WriteLine("{0} Contando", i);
        }*/

        int[] ArrN = new int[10];

        for(int ind = 0; ind < ArrN.Length; ind++){
            ArrN[ind] = ind;
            Console.WriteLine("O array: ArrN recebeu na posição {0} o valor de {1}", ind, ArrN[ind]);
        }
    }
}