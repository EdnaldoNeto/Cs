using System;
using System.Globalization;
using Internal;

class Operacoes{
    static void Main(){

        float num1 = 0;
        float num2 = 0;
        float resultado = 0;

        char operador = '0';

        inicio:

        Console.WriteLine("_______________Software de operações matemáticas_______________");

        Console.Write("Digite o primeiro número da operação: ");
        num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

        Console.Write("Digite o segundo número da operação: ");
        num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

        Console.Write("Digite qual operador para sua operação. (+) - para adição (-) - para sutração (*) - para multiplicação (/) - para divisão: ");
        operador = char.Parse(Console.ReadLine());

        switch(operador){
            
            case '+':
                resultado = num1 + num2;
                Console.WriteLine("O resultado da operação é: {0}", resultado);
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine("O resultado da operação é: {0}", resultado);
                break;
            
            case '*':
                resultado = num1 * num2;
                Console.WriteLine("O resultado da operação é: {0}", resultado);
                break;

            case '/':
                resultado = num1 / num2;
                Console.WriteLine("O resultado da operação é: {0}", resultado);
                break;

            default:
                Console.WriteLine("Operador está incorreto");
                break;
                
        }

        char SN = 'N';

        Console.WriteLine("Quer fazer nova opeção matemática: [S/N]");
        SN = char.Parse(Console.ReadLine());

        if(SN == 'S' || SN == 's')
        {
            Console.Clear();
            goto inicio;
        } else {
            Console.Clear();
            Console.WriteLine("____________________Obrigado por testar nosso software____________________");
            
        }
    }
}