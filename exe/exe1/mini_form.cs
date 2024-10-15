using System;

class Form{
    static void Main(){
        string nome,cidade, estCiv;
        int idade, numCasa;

        Console.WriteLine("Qual é seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Em que cidade você mora?:");
        cidade = Console.ReadLine();

        Console.WriteLine("Qual é número da sua casa:");
        numCasa = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é seu estado cívil:");
        estCiv = Console.ReadLine();

        Console.WriteLine("Qual é a sua idade:");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Nome.............: {0,15}", nome);
        Console.WriteLine("Cidade onde mora.: {0,15}", cidade);
        Console.WriteLine("Número da casa...: {0,15}", numCasa);
        Console.WriteLine("Estado cívil.....: {0,15}", estCiv);
        Console.WriteLine("Idade............: {0,15}", idade);
    }
}