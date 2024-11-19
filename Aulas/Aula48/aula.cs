using System;
using Internal;

class Calc{ //Recursividade
    public int fat(int x){
        int res;
        if(x==1) {
            res=1;
        } else {
            res = x*fat(x-1);
        }
        return res;
    }
}

class Aula48{
    static void Main(){
        Calc fatorial = new Calc();

        Console.WriteLine(fatorial.fat(10));
    }
}