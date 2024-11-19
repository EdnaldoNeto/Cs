using System;
using Internal;

class Aula52{
    static void Main() {
        int n1 = 10;
        int n2 = 0;
        int res = 0;

        try {
            res = n1 / n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
        }catch(Exception excecao) { //Execeção criada por mim
            Console.WriteLine("ERRO: {0}", excecao.Message);
        }
    }
}