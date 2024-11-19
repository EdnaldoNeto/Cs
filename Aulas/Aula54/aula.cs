using System;
using Internal;

namespace Calc1{ //Organização e agrupamento 
    class Area{
        public static double Quad(double b, double a) {
            if(a==0 || b==0) {
                throw new Exception("Base ou altura não podem ser igual a zero"); //Criando nova Excecao
            }
            return b*a;
        }
    }
}

namespace Calc2{
        class Area{
        public static double Quad(double b, double a) {
            if(a==0 || b==0) {
                throw new Exception("Base ou altura não podem ser igual a zero"); //Criando nova Excecao
            }
            return b*a;
        }
    }
}

class Aula52{
    static void Main() {

        double area = 0;

        try {
            area = Calc1.Area.Quad(0, 10);
            Console.WriteLine(area);
        } catch(Exception excecao) { //Caso houver exceção será executado
            Console.WriteLine("ERRO: {0}", excecao.Message);
        } finally { //O finally é executado independente de excecao ou não
            Console.WriteLine("Fim do processo");
        }
    }
}