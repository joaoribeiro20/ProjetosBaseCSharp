using System;

class Calculo : IPadrao //criamos uma interface para que todos metodos dentro dela sejam origatorio nas classes que for implementar essa interface 
// portanto devemos copiar o metodo igual da interface e atriduir função nele, caso a gente não usar o metodos disponiveis 
//na interface vai da erro
{
     public void somar(int n1, int n2){
        Console.WriteLine("A soma é: "+(n1+n2));
     }

    public void subtrair(int n1, int n2){
        Console.WriteLine("A subitração é: "+(n1-n2));
    }
}