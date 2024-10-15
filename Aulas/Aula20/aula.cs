using System;
using Internal;

class Aula20{

    static void Main(){

        int[] Arrn = new int [10];

        int i = 0;
        int ten = 10;
        
        while (i < Arrn.Length)
        {
            Arrn[i] = ten;
            Console.WriteLine("a posição {0} do Array: Arrn está recebendo {1}", i , Arrn[i]);
            ten = ten + 10;
            i++;
        }

    }
}