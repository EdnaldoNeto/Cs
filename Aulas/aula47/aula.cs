using System;
using Internal;

class Calc{
    /*public int Soma(int x, int y) {
        return x + y;
    }*/

    /*public int Soma(int x, int y, int w) { //Sobrecarga de método
        return x + y + w;
    }*/

    public double Soma(params double[]n) {
        double s = 0;
        for(int i = 0; i < n.Length; i++) {
            s+=n[i];
        }
        return s;
    }
}

class Aula47{
    static void Main(){

        Calc add = new Calc();

        var res = add.Soma(10, 4);

        Console.WriteLine(res);
        Console.WriteLine(add.Soma(20, 20));
        Console.WriteLine(add.Soma(5, 10, 5));
        Console.WriteLine(add.Soma(15.5, 12.2));
    }
}