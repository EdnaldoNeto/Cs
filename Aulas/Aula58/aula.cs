using System;
using System.Collections.Generic;
using Internal;

class Aula57{
    static void Main() {
        List<string> carros = new List<string>(); //list
        List<string> carros2 = new List<string>();

        string[] cars = new string[10];

        // add - para adicionar elementos na lista
        carros.Add("BMW");
        carros.Add("Mustag");
        carros.Add("Golf");
        carros.Add("Camaro");

        carros2.AddRange(carros); // a lista carros2 vai receber os elementos de carros

        //carros.Clear(); // remover todos os itens da lista

        //carros.CopyTo(cars, 2); copiar os elementos aparir de um index e passar para um array

        carros.Insert(1, "Corsa"); //adiciona um elmento na lista, na posição indicada

        //carros.Remove("Golf"); // remove remover elemento da lista

        carros.Reverse(); // reverse inversão da lista

        carros.Sort(); // sort - vai organizar a lista de forma alfabetica

        carros.Capacity = 15;  //capacity - definindo a capacidade da lista

        int tamanho = carros.Count; // count - retorna o tamanho da lista
        int capacidade = carros.Capacity; // capacity - vai retornar a capacidade da lista
        int pos2 = carros.LastIndexOf("Camaro"); //lastindexof vai retornar a posição do ultimo elemento com esse nome

        if(carros.Contains("BMW")) {  // contains - vai verificar se o elemento está na lista 
            Console.WriteLine("Elemento encontrado");
        } else {
            Console.WriteLine("Elemento não encontrado");
        }
 
        foreach(string car in carros) {
            Console.WriteLine("Carro: {0}", car);
        }

        int pos = carros.IndexOf("Mustag"); //indexof - vai retornar a posição do elemento
        Console.WriteLine(pos);
        Console.WriteLine(pos2);
        Console.WriteLine("tamanho da lista: {0}" ,tamanho);
        Console.WriteLine("capacidade da lista: {0}" ,capacidade);

    }
}