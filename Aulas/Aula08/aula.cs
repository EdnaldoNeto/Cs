using System;

class AUla08{
    static void Main(){

        int v1,v2,soma;
        string nome;


        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine(); //essa variavel vai receber o valor digitado no teclado
        Console.WriteLine("Seu nome é: {0}", nome);

        Console.WriteLine("Digite o primeiro número");
        v1 = int.Parse(Console.ReadLine()); //ReadLine vai armazenar os dados passados pleo teclado, para a variavel v1
        Console.WriteLine("Digite o segundo número");
        v2 = Convert.ToInt32(Console.ReadLine());

        soma = v1 + v2;
        Console.Write("A soma entre {0} e {1} é igual a {2}", v1, v2, soma);
    }
}