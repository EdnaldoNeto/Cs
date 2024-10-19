using System;
using Internal;

class Aula24{

    static void Main(){
        Console.Write("Digite o primeiro número: ");
        int v1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int v2 = int.Parse(Console.ReadLine());

        int resultado = soma(v1, v2);

        Console.WriteLine("A soma entre {0} e {1} é {2}", v1, v2, resultado);
    }

    //Método sem retorno
    static void Soma(int n1, int n2){
        
        int resultado = n1 + n2;

        Console.WriteLine("A soma entre {0} e {1} é {2}", n1, n2, resultado);
    }

    //Método com retorno
    static int soma(int n1, int n2){
        return n1 + n2;
    }
}