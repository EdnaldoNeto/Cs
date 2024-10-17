using System;
using Internal;

class Aula23{
    static void Main()
    {
        int[] vetor = new int [5];
        int[] vetor1 = new int [5];
        int[] vetor2 = {22, 44, 14, 10, 21};
        int[] vetor3 = new int [5];
        int[] vetor4 = new int [5];


        Console.WriteLine("Next");
        Random random = new Random(); //Criando objeto random do tipo Random
        for (int i = 0; i < vetor1.Length; i++){
            vetor1[i] = random.Next(50); //Usando o método Next do objeto random 
            Console.WriteLine("A posição {0} do vetor1 vai receber: {1}", i, vetor1[i]);
        }
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método BinarySeach(array,valor) vai retornar a  posição de valor no array, caso o valor não seja encontrado returna -1
        Console.WriteLine("BinarySeach");
        int procurado = 14;
        int posicao = Array.BinarySearch(vetor2, procurado);
        Console.WriteLine("A posição do elemento {0}, no array: vetor2 é {1}", procurado, posicao);
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método Array.Copy(Arr_ori, Arr_dest_ qtde_elementos)
        Console.WriteLine("Copy");
        Array.Copy(vetor2, vetor3, vetor2.Length);
        foreach (int n in vetor3){
             Console.WriteLine(n);
        }
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método CopyTo(Array_destino, a_partir_deste_indice)
        Console.WriteLine("CopyTo");
        vetor2.CopyTo(vetor4, 0);
        foreach (int n in vetor4) {
            Console.WriteLine(n);
        }
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método GetLongLength(dimensão) dimensão = array ou matriz
        Console.WriteLine("GetLongLength");
        long qtde_elementosVetor = vetor.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos no vetor2 {0}", qtde_elementosVetor);
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método GetLowerBound(dimensão) dimensão = array ou matriz
        Console.WriteLine("GetLowerBound");
        int menorIndiceVetor = vetor2.GetLowerBound(0);
        Console.WriteLine("O menor indice do vetor: vetor2 é {0}", menorIndiceVetor);
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método GetUpperBound(dimensão) dimensão matriz ou array
        Console.WriteLine("GetUpperBound");
        int maiorIndiceVetor = vetor2.GetUpperBound(0);
        Console.WriteLine("O maior indice do vetor: vetor2 é {0}", maiorIndiceVetor);
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método GetValue(indice) 
        Console.WriteLine("GetValue");
        int valorIndiceArr = Convert.ToInt32(vetor2.GetValue(1)); //O valor precisa ser convertido pois o vetor pode ser de qualquer tipo
        Console.WriteLine("O valor do indice 1 do vetor: vetor2 é {0}", valorIndiceArr);
        Console.WriteLine("------------------------------------------------------\n\n");

        //Método IndexOf(array, valor)
        Console.WriteLine("IndexOf");
        int indice = Array.IndexOf(vetor2, 14);
        Console.WriteLine("O primeiro elemento: 14 do vetor: vetor2 tem o posição {0}", indice);
        Console.WriteLine("------------------------------------------------------\n\n");

    }
}