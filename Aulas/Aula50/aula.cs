using System;
using Internal;

delegate int Op(int n1, int n2);

class Mat{
    public static int soma(int x, int y) {
        return x+y;
    }

    public static int multi(int x, int y) {
        return x*y;
    }
}

class Aula50{
    static void Main() {

        Op vsoma = new Op(Mat.soma);
        Op Vmulti = new Op(Mat.multi);

        Console.WriteLine(vsoma(2,2));
        Console.WriteLine(Vmulti(5,2));
    }
}