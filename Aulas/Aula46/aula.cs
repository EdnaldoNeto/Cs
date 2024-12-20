using System;
using Internal;

class Galinha{
    private string nomeGalinha;
    private int numOvo;

    public Galinha(string nome) {
        this.nomeGalinha = nome;
        numOvo = 0;
    }

    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}

class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}

class Aula46{
    static void Main() {

        Galinha g1 = new Galinha("Benta");
        Galinha g2 = new Galinha("Chica");
        Galinha g3 = new Galinha("Zéza");

        g1.botar();
        g1.botar();
        g1.botar();

    }
}