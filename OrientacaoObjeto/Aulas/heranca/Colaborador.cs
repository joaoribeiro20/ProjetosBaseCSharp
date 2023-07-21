using System;
                            //para herda uma classe é necessario 
class Colaborador : Pessoa //basta adicionar dois pontos : e o nome da classe a ser herdada,
{
    //atributos
    private double salario;

    //construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.salario = salario;
        this.idade = idade;
        
        mensagemPessoa();
        mensagemColaborador();
        
    }
    private void mensagemColaborador()
    {
        Console.WriteLine("salario: " +salario);

    }
}