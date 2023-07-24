using System;

    class Pessoa
    {
        //atributo 
        protected int cpf; // o protected permite que voce tenha acesso apenas dentro da proria class (Pessoa) ou atravez de herança
        //portanto caos alguem herde a class pessoa, vai poder acessar esses atributos e metodos
        protected int senha;

       protected void mensagemPessoa(){
        Console.WriteLine("cpf: " +cpf);
        Console.WriteLine("senha: " +senha);
    }
        
    }