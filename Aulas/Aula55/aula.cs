using System;
using System.Collections.Generic;
using Internal;

class Aula55{
    static void Main() {
        Dictionary <int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(12, "Moto");
        veiculos.Add(15, "Navio");
        veiculos.Add(18, "Avião");

        veiculos.Remove(10); //Removendo chave da coleção

        //veiculos.Clear(); Vai limpar o dictionary 
        Console.WriteLine("Tamanho do Dictionary {0}", veiculos.Count); //Vai retornar o tamanho do dictionary
        
        if(veiculos.ContainsKey(10)){ //Vai verificar se existe a chave na coleção ou não 
            Console.WriteLine("A chave está na coleção");
        } else {
            Console.WriteLine("A chave não foi encontrada");
        }

        veiculos[15] = "Bicicleta"; //trocando a valor por bicileta

        if(veiculos.ContainsValue("Bicicleta")) { //Vai verificar se existe o valor na coleção ou não
            Console.WriteLine("O valor está na coleção");
        } else {
            Console.WriteLine("O valor não está na colção");
        }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values; //Vai receber os valores do dictionary veiculos
        Dictionary<int, string>.ValueCollection chaves = veiculos.Keys; //vai recebr as chaves do dictionary veiculos

        foreach(KeyValuePair<int, string> svalue in veiculos) { //lendo os valores e chaves do dictionary
            Console.WriteLine(svalue.Key + " " + svalue.Value);
        }
    }
}