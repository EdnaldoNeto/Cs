using System;
using Internal;

class Aula11{
    static void Main(){

        //Conversão implicita
        int n1 = 15;
        float n2 = n1;
        
        Console.WriteLine(n2);

        //Convesão explicista 
        float num1 = 12.4f;
        int num2 = (int)num1;//type cast

        int vInt = 17;
        short vshort = (short)vInt;//type cast

        Console.WriteLine(num2);
        Console.WriteLine(vshort);
    }
}