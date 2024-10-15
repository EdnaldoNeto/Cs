using System;
using Internal;

class Aula17{
    static void Main(){
        int[] Arrn = new int[5]; //Declarando um array com 5 posições
        int[] num = new int[3] {15, 22, 56}; //Declarando e atribuindo valores
        int[] n = {13, 16, 98}; //Declarando e atribundo valores

        //Atribundo valores as posições do array
        Arrn[0] = 5;
        Arrn[1] = 10;
        Arrn[2] = 20;
        Arrn[3] = 33;
        Arrn[4] = 12;

        Console.WriteLine(Arrn[2]);
    }
}