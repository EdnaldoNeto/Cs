using System;
using Internal;

class Aula23{
    static void Main()
    {
        int[] vetor1 = new int [5];
        int[] vetor2 = {22, 44, 14, 10, 21};

        Random random = new Random(); //Criando objeto random do tipo Random
        for (int i = 0; i < vetor1.Length; i++){
            vetor1[i] = random.Next(50); //Usando o método Next do objeto random 
            Console.WriteLine("A posição {0} do vetor1 vai receber: {1}", i, vetor1[i]);
        }

        //Método BinarySeach(array,valor) vai retornar um int
        int procurado = 14;
        int posicao = Array.BinarySearch(vetor2, procurado);
        Console.WriteLine("\n\nA posição do elemento {0}, no array: vetor2 é {1}", procurado, posicao);
    }
}