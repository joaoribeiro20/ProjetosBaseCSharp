using System;

class Atendente : Imposto
{
    //Método
    //override é uma palavra reservada apenas para o c#
    //override = indica que esse metodo esta sobreescrevendo um outro metodo ja existente (Nesse caso ele ta sobreescrevendo o metodo da class Imposto)
    public override void valeAlimentacao(double salario){
        Console.WriteLine("Desconto Padrão Atendente do vale Alimentação R$" +(salario * 0.12));
        
    }
}