using System;
using System.Reflection;
using Internal;

class Aula23{
    static void Main(){
        int[] vetor = {12, 11, 25, 16, 12, 15};
        int[] vetor2 = {20, 30, 40, 50, 60};
        int[] vetor3 = new int [5];

        // Método LastIndexOf(array, valor)
        Console.WriteLine("LastIndexOf");
        int indice = Array.LastIndexOf(vetor, 12);
        Console.WriteLine("O ultimo elemento: 12 do vetor: vetor tem a posição de {0}", indice);
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método Reverse(array)
        Console.WriteLine("Reverse");
        Array.Reverse(vetor2);
        foreach(int n in vetor2){
            Console.WriteLine(n  );
        }
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método SetValue(valor, posição)
        Console.WriteLine("SetValue");
        vetor3.SetValue(5, 0);
        Console.WriteLine("O valor da posição 0 no vetor: vetor3 é {0}", vetor3[0]);
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método Sort(array)
        Console.WriteLine("Sort");
        Array.Sort(vetor);
        foreach(int n in vetor){
            Console.WriteLine(n);
        }
        Console.WriteLine("------------------------------------------------------\n\n");
    }
}