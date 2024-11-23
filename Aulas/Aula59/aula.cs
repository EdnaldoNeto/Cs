using System;
using System.Collections.Generic;
using Internal;
using Microsoft.Win32.SafeHandles;

class Aula59{
    static void Main() {

        Queue<string> Veiculos = new Queue<string>();

        Veiculos.Enqueue("Carro");  // enqueue - adiciona o elemento no final da fila
        Veiculos.Enqueue("Moto");
        Veiculos.Enqueue("Avião");
        Veiculos.Enqueue("Navio");

        //Veiculos.Clear(); // clear - vai limpar a fila

        if(Veiculos.Contains("Navio")) {  // contains - vai retornar true caso o elemento for encontrado na fila, caso contrario retorna false
            Console.WriteLine("Veiculo encontrado");
        } else {
            Console.WriteLine("Não encontrado");
        }

        //Console.WriteLine("Primeiro da fila: {0}", Veiculos.Dequeue()); // dequeue - vai retornar e remover o primeiro elemento da fila
        //Console.WriteLine("Primeiro elemento da fila: {0}", Veiculos.Peek()); //peek - apenas retorna o primeiro elemento da fila
        
        foreach(string v in Veiculos) {
            Console.WriteLine("Veiculo: {0}", v);
        }

        Console.WriteLine("Tamanho: {0}", Veiculos.Count); // count - vai retornar o tamanho da fila 
    }
}