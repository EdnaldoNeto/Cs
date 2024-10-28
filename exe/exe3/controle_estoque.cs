using System;
using System.Globalization;
using Internal;

class Estoque{
    static void Main(){

        string[] produto = new string[100];
        string respostaUser = "";

        int[] codigo = new int[100];
        int[] quantidade = new int[100];
        double[] preço = new double[100];        

        Console.WriteLine("_______________Software de controle de estoque_______________");

        inicio:

        Console.WriteLine("\n\nOque você deseja:\n\n__________[add] - para adicionar produto:\n\n__________[rm] - para remover produto:\n\n__________[list] - para listar os preços, quantidade de estoque e preço:\n\n__________[quit] - para fechar o Software\n");

        Console.Write("Opção: ");
        respostaUser = Console.ReadLine();



        switch(respostaUser){

            case "add":
                add:
                Console.Write("\nNome do produto: ");
                
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
                    preço[P] = double.Parse(Console.ReadLine());
                } else {
                    while(!(preço[P] == 0))
                    {
                        P++;
                    }
                    preço[P] = double.Parse(Console.ReadLine());
                }
                
                Console.WriteLine("\bQuer adicionar mais algum produto: [S/N]");
                respostaUser = Console.ReadLine();

                if (respostaUser == "S" || respostaUser == "s")
                {
                    Console.Clear();
                    goto add;
                } else {
                    Console.Clear();
                    goto inicio;
                }

            case "rm":
                rm:
                Console.Write("\nQual o código do Produto que você deseja remover: ");

                int r = int.Parse(Console.ReadLine());
                
                if (produto[r] != null)
                {
                    produto[r] = null;
                    quantidade[r] = 0;
                    preço[r] = 0;

                    Console.WriteLine("\nDeseja remover outro produto: [S/N]");

                    if (respostaUser == "S" || respostaUser == "s")
                    {
                        Console.Clear();
                        goto rm;
                    } else {
                        Console.Clear();
                        goto inicio;
                    }
                } else {
                    Console.WriteLine("\nCódigo inexistente. Quer tentar novamente: [S/N]");
                    respostaUser = Console.ReadLine();

                    if (respostaUser == "S" || respostaUser == "s")
                    {
                        Console.Clear();
                        goto rm;
                    } else {
                        Console.Clear();
                        goto inicio;
                    }
                }

            case "list":
                Console.WriteLine("\n_______________Todos os produtos, preços e estoque_______________\n");
                if (produto[0] == null) 
                {
                    Console.WriteLine("Sua lista de produtos está vazia");

                } else {
                    int i = 0;
                    for (int n = 0; produto[n] != null; n++)
                    {
                        Console.WriteLine("Produto: {0}", produto[n]);
                        Console.WriteLine("estoque: {0}", quantidade[n]);
                        Console.WriteLine("Preço: {0:c}", preço[n]);
                        Console.WriteLine("código de remoção: {0}\n\n", i);
                        i++;
                    }
                }
                goto inicio;


            case "quit":
                Console.WriteLine("\n_______________Obrigado por testar nosso Software_______________");
                break;

            default:
                Console.Clear();
                Console.WriteLine("Essa Opção é inválida.");
                goto inicio;

        }
    }
}