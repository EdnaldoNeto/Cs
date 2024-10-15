using System;

class Aula05{
    
    static void Main(){

        int num1 = 20;
        int num2 = 20;

        bool igualdade = num1 == num2;

        Console.WriteLine("Teste de igualdade: ");
        if(igualdade == true){
            Console.Write(num1 + " e " + num2 + " São números iguais");
        } else {
            Console.Write(num1 + " e " + num2 + " Não são números iguais");
        }

        int num3 = 70;
        int num4 = 60;

        bool maior_menor = num3 > num4;
        Console.WriteLine("\n\nTeste de maior ou menor: ");
        if(maior_menor == true){
            Console.Write(num3 + " é maior que " + num4);
        } else {
            Console.Write(num3 + " é menor que " + num4);
        }
    }
}