using System;
using System.Globalization;
using Internal;

class Estoque{
    static void Main(){

        string[] produto = new string[100];
        string respostaUser = "";

        int[] quantidade = new int[100];
        float[] preço = new float[100];

        Console.WriteLine("_______________Software de controle de estoque_______________");

        Console.WriteLine("\n\nOque você deseja:\n\n__________[add] - para adicionar produto:\n\n__________[rm] - para remover produto:\n\n__________[list] - para listar os preços, quantidade de estoque e preço:\n");

        Console.Write("Opção: ");
        respostaUser = Console.ReadLine();

        

        switch(respostaUser){

            case "add":
                add:
                Console.Write("Nome do produto: ");
                
                int N = 0;
                if (produto[N] == null)
                {
                    produto[N] = Console.ReadLine();
                } else {
                    while (!(produto[N] == null)) 
                    {
                        N++;
                    }
                    produto[N] = Console.ReadLine();
                }

                Console.Write("Quantidade de produto: ");
                
                int Q = 0;
                if (quantidade[Q] == 0)
                {
                    quantidade[Q] = int.Parse(Console.ReadLine());
                } else {
                    while (!(quantidade[Q] == 0))
                    {
                        Q++;
                    }
                    quantidade[Q] = int.Parse(Console.ReadLine());
                }

                Console.Write("Preço do produto: ");

                int P = 0;
                if (preço[P] == 0)
                {
                    preço[P] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                } else {
                    while(!(preço[P] == 0))
                    {
                        P++;
                    }
                    preço[P] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                }

                Console.WriteLine("Quer adicionar mais algum produto: [S/N]");
                respostaUser = Console.ReadLine();

                if (respostaUser == "S" || respostaUser == "s")
                {
                    Console.Clear();
                    goto add;
                } else {
                    Console.WriteLine(produto[0]);
                    Console.WriteLine(quantidade[0]);
                    Console.WriteLine(preço[0]);

                    Console.WriteLine(produto[1]);
                    Console.WriteLine(quantidade[1]);
                    Console.WriteLine(preço[1]);
                }
                break;

            case "rm":
                break;

            case "list":
                break;

            default:
                break;

        }
    }
}