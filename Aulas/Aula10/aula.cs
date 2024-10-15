using System;

class Aula10{

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

    static void Main(){

        DiasSemana fut = DiasSemana.Domingo;//Atribuindo valor a variavel tipo DiasSemana

        DiasSemana folga = (DiasSemana)6;//Outra forma de atribuir valor

        int trabalhar = (int)DiasSemana.Segunda;//Convertendo o indice de segunda para um inteiro

        Console.WriteLine("{0} é dia de futebol", fut);    
        Console.WriteLine("{0} é o dia da minha folga", folga);
        Console.WriteLine("{0} é o começo da semana, temos que trabalhar", trabalhar);

    }
}