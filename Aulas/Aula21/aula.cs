using System;
using Internal;

class Aula21{

    static void Main(){
        string senha = "12345";
        string senhaUser;

        int tentativas = 0;

        do {
            Console.Clear();
            Console.Write("Digite sua senha: ");
            senhaUser = Console.ReadLine();
            tentativas++;
        } while (senha != senhaUser);

        Console.WriteLine("Senha confirmada. Foram precisos {0} tentativas", tentativas);
    }

}