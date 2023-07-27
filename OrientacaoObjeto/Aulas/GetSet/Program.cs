using System;

namespace GetSet
{
    class program{
        static void Main(string[] args)
        {
        
        Pessoa p = new Pessoa();
        p.Nome = "Joao"; //chamando o metodo Nome para atribuit o valor para o atributo nome atraves do SET
        Console.WriteLine(p.Nome);//Chamando o metodo Nome para ler o valor do atributo nome atraves do GET
        //portanto atraves do get e set conseguimos acessar atributos com modificador de acesso private mesmo
        //estando em outra class
        }

    }
}
