using System;


    class Aluno
    {
    
    //Atributo

    //sobre escrita ou "sobreescrevendo" de metodo/função, metodo/função com mesmo nome porem parametros diferentes
    //so vai ser chamada/execultada aquela função com os requisitos, caso eu chame a função e nao atribuo parametros para ela
    //vai ser chamada a outra função sem parametros, no mesmo caso ao contratrio. portanto é como se houvesse duas função diferentes 
    //porem com mesmo nome, assim podendo escolher qual chamar de acordo com a informaçãoi que for adicionada a função
    // sobreescrita/ over
    public void cadastro(){
        Console.WriteLine("essa é a outra função cadastro, porem sem parametros");
    }
    public void cadastro(string nome, string email, int tel){
        Console.WriteLine("cadastro realizado com sucesso");
        
    } 

    

    public void login(){
        
    }
 }
