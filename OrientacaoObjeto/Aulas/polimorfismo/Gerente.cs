using System;

class Gerente : Imposto
{
    //Método
    public override void valeAlimentacao(double salario)
    {
       Console.WriteLine("Desconto Padrão Gerente do vale Alimentação R$" +(salario * 0.1));

    }
}