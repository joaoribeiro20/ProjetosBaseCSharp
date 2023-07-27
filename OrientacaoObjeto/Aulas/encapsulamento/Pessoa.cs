using System;

class Pessoa
{
    private int nota1, nota2;


    private int media(){
        return (nota1+nota2)/2;
    }


    public void mensagem(){
        Console.WriteLine("informe a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("informe a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("a media é:"+media());
       

    }
}