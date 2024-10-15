using System;
using Internal;

class Aula13{
    static void Main(){
        string hojeDia;

        Console.WriteLine("Que dia é hoje: ");
        hojeDia = Console.ReadLine();

        if(hojeDia == "sabado"){
            Console.WriteLine("Hoje é {0}, dia de futebol", hojeDia);
        } else if(hojeDia == "domingo"){
            Console.WriteLine("Hoje é {0}, dia de feira", hojeDia);
        } else { Console.WriteLine("É dia de semana, vamos trabalhar"); }
    }
}