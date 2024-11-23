using System;
using System.Collections.Generic;
using Internal;


class Aula56{
    static void Main() {
         LinkedList<string> transp = new LinkedList<string>();

        //Método addfirst - adiciona um elemento para o inicio da lista
         transp.AddFirst("Carro");
         transp.AddFirst("Moto");
         transp.AddFirst("Navio");
         transp.AddFirst("Avião");

         transp.AddLast("Bicicleta"); //addlast - adiciona um elemento no fim da lista


        LinkedListNode<string>no;
        no = transp.FindLast("Moto"); //FindLast - Vai encontrar o ultimo elemento com esse nome na lista
         transp.AddAfter(no, "Patinete"); //addafter - vai adicionar um elemento apos o no

        no = transp.FindLast("Navio");
        transp.AddBefore(no, "Caminhão"); // addbefore - vai adicioanar um elemento antes do no

        //transp.Clear(); // clear - para remover todos os elementos da lista

        transp.Remove("Avião"); //remove - remover um elemento da lista
        transp.RemoveFirst(); //removefirst - remove o primeiro elemento da lista
        transp.RemoveLast(); //removelast - remove o ultimo elemento da lista

         foreach(string tp in transp) {
            Console.WriteLine("transporte - {0}", tp);
         }

        if(transp.Find("Carro") == null) { //Find - vai procurar o item da lista e vai retornar null caso ache o elemento
            Console.WriteLine("\nElemento não encontrado");
        } else {
            Console.WriteLine("Elemento encontrado");
        }
    }
}