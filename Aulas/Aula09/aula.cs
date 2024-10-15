using System;

class Aula09{

    static void Main(){

        int num1 = 10;
        Console.WriteLine("O valor de num1: {0}", num1);

        num1 = num1 <<1;
        Console.WriteLine("O valor de num1 após a operação bitwise: {0}",num1);

        int num2 = 20;
        Console.WriteLine("\nO valor de num2: {0}", num2);

        num2 = num2 >>2;
        Console.WriteLine("O valor de num2 apos a operação bitwise: {0}", num2);

    }

}