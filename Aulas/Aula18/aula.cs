using System;
using Internal;

class Aula18{

    static void Main(){
        int [,] m = new int [3,5]; //Declarando uma matriz do tipo int com 3 linhas e 5 colunas
        int [,] m2 = new int []; //Matriz bidimensinal sem valor
        /*
        x x x x x
        x x x x x
        x x x x x
        */

        //Atribuindo valores na matriz
        m[0,0] = 10;
        m[0,1] = 20;
        m[0,2] = 30;
        m[0,3] = 40;
        m[0,4] = 50;

        m[1,0] = 60;
        m[1,1] = 70;
        m[1,2] = 80;
        m[1,3] = 90;
        m[1,4] = 100;

        m[2,0] = 110;
        m[2,1] = 120;
        m[2,2] = 130;
        m[2,3] = 140;
        m[2,4] = 150;

        /*
        Resultado da matriz após as atribuições:

        10 20 30 40 50
        60 70 80 90 100
        110 120 130 140 150
        */

        Console.Write(m[2,4]);
    }
}