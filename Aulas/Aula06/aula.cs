using System;

class Aula06 {
    static void Main(){

        double valorCompra = 12.15;
        double valorVenda;
        double lucro = 0.2;
        string produto = "Coca-cola";
        
        valorVenda = valorCompra + (valorCompra*lucro);

        Console.WriteLine("Produto: {0,15}", produto);
        Console.WriteLine("Valor de Compra:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro:{0,15:p}", lucro);
        Console.WriteLine("Valro de Venda:{0,15:c}", valorVenda);
    }
}