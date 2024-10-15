using System;
using Internal;

class Aula{
    static void Main(){
        int tempo = 0;
        char escolha;

        inicio: //label
        Console.Clear(); //ira limpar o console

        Console.WriteLine("Belo Horizonte/MG a Vitória/Es");
        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]ônibus");

        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break; 

            case 'o':
            case 'O':
                tempo = 480;
                break;

            default:
                Console.WriteLine("A sua escolha não é permitida");
                break;
        }
        
        if (tempo == 50)
        {
            Console.WriteLine("\nAvião: {0} minutos de viagem", tempo);
        } else if (tempo == 360) 
        {
            Console.WriteLine("\nCarro: [0] minutos de viagem", tempo);
        } else if (tempo == 480) 
        {
            Console.WriteLine("\nÕnibus: [0] minutos de viagem", tempo);
        }

        Console.Write("\nCalcular outro transporte?[s/n]");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's' || escolha == 'S')
        {
            goto inicio; //goto - aponta para o label
        } else {
            Console.Clear();
            Console.WriteLine("Fim do programa!");
        }
    }
}