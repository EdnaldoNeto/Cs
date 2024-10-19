using System;
using System.Globalization;
using Internal;

class Estoque{
    static void Main(){

        string[] produto = new string[100];
        string respostaUser = "";

        int[] codigo = new int[100];
        int[] quantidade = new int[100];
        float[] preço = new float[100];

        Console.WriteLine(produto.Length);
        

        Console.WriteLine("_______________Software de controle de estoque_______________");

        inicio:

        Console.WriteLine("\n\nOque você deseja:\n\n__________[add] - para adicionar produto:\n\n__________[rm] - para remover produto:\n\n__________[list] - para listar os preços, quantidade de estoque e preço:\n\n__________[quit] - para fechar o Software");

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
                    codigo[N] = N;
                } else {
                    while (!(produto[N] == null)) 
                    {
                        N++;
                    }
                    produto[N] = Console.ReadLine();
                    codigo[N] = N;
                }

                Console.Write("Quantidade de produto: ");
                
                int Q = 0;
                if (quantidade[Q] == 0)
                {
                    quantidade[Q] = int.Parse(Console.ReadLine());
                    codigo[Q] = Q;
                } else {
                    while (!(quantidade[Q] == 0))
                    {
                        Q++;
                    }
                    quantidade[Q] = int.Parse(Console.ReadLine());
                    codigo[Q] = Q;
                }

                Console.Write("Preço do produto: ");

                int P = 0;
                if (preço[P] == 0)
                {
                    preço[P] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                    codigo[P] = P;
                } else {
                    while(!(preço[P] == 0))
                    {
                        P++;
                    }
                    preço[P] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                    codigo[P] = P;
                }

                Console.WriteLine("Quer adicionar mais algum produto: [S/N]");
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
                Console.Write("Qual o código do Produto que você deseja remover: ");

                int rm = int.Parse(Console.ReadLine());
                
                if (codigo[rm] != 0)
                {
                    produto[rm] = null;
                    quantidade[rm] = 0;
                    preço[rm] = 0;
                } else {
                    Console.WriteLine("Código inexistente. Quer tentar novamente: [S/N]");
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
                break;

            case "list":
                Console.WriteLine("Todos os produtos, preços e estoque:");
                if (produto[0] == null) 
                {
                    Console.WriteLine("Sua lista de produtos está vazia");

                } else {
                    for (int n = 0; produto[n] != null; n++)
                    {
                        Console.WriteLine("Produto: {0}", produto[n]);
                        Console.WriteLine("Preço: {0}", preço[n]);
                        Console.WriteLine("estoque: {0}", quantidade[n]);
                    }
                }
                break;


            case "quit":
                break;

        }
    }
}