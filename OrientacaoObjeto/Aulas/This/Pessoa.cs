using System;

class Pessoa {

    private string nome = "joao";

    public Pessoa(string nome){

        //O THIS serve para se referir a um atributo, como podemos ver no exemplo a baixo quando chamamos apenas nome
        //se refere o valor do parametro dentro do metodo, agora se colocar this.nome, vamos estar fazendo referencia ao atributo
        //portanto this serve para referenciar atributos private.  

        Console.WriteLine(this.nome);

        Console.WriteLine(nome);
    }
}