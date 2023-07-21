using System;
class Pessoa{
    //atributo

    //o modificador de acesso protected permite que so a class de 
    //origin ou classes que herdar a classe de origin 
    //(nesse caso a classe de orign é a class Pessoa)
    protected string nome;
    protected int idade;
    //metodo
    protected void mensagemPessoa(){
        Console.WriteLine("Nome: " +nome);
        Console.WriteLine("Idade: " +idade);
    }
}