using System;
using Internal;

class Aula12{
    static void Main(){

        int nota1,nota2,nota3,nota4;
        string resultado = "VOCÊ FOI REPROVADO, ESTUDE MAIS!";
        
        Console.WriteLine("Digite a sua primeira nota: ");
        nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua segunda nota: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua terceira nota: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua quarta nota: ");
        nota4 = int.Parse(Console.ReadLine());

        int media = (nota1+nota2+nota3+nota4) / 4;

        if(media > 6){
            resultado = "PARABÉNS VOCÊ FOI APROVADO";
        }

        Console.WriteLine("Resultado: {0}, sua média: {1}", resultado,media);
    }
}