using System;
using Internal;

class Aula51{
    static void Main(string[] args) {
        
        if(args.Length > 0) {
            int res = 0;
            Console.WriteLine("Quantidade de arugumentos {0}", args.Length);
            for(int i = 0; i < args.Length; i++) {
                //Console.WriteLine("arugumento: {0} - {1}", i, args[i]);
                res += Int32.Parse(args[i]);
            }
            Console.WriteLine(res);
        } else {
            Console.WriteLine("Nenhum arugumento foi passado");
        }
    }
}