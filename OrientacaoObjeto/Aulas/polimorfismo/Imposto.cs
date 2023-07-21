using System;

class Imposto
{

    //virtual é uma palavra revervada apenas do c#
    //virtual = permite sobreescrever os o metodo (informa que esse medo pode sofre possiveis modificaçoes)
    public virtual void valeAlimentacao(double salario){
        Console.WriteLine("Desconto Padrão do vale Alimentação R$" +(salario * 0.1));
    }
    public void valeTranporte(double salario){
        Console.WriteLine("Desconto Padrão do vale Tranporte R$" +(salario * 0.06));
    }

}