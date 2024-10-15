using System;

class Aula04{
    
    static int num = 10; //Váriavel global

    static void Main(){

        int num2 = 15; //variável Local
        Console.Write("A variável num é global, por isso podemos acessar ela: " + num);
    }
}