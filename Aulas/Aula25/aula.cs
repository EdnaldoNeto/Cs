using System;
using Internal;

class Aula25{

    static void Main(){

        int num = 50;
        dobrar(ref num);
        Console.WriteLine(num);

    }

    //Por referência
    static void dobrar(ref int valor){
        valor*=2;
    }
}