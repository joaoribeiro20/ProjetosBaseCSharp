using System;

class Pessoa{

    //construtor
     //Todo construtor tem o mesmo nome da class, porque assim que instanciamos ele, ele é execultado juntamente ao 
     //comando de instancia a class
     // portanto se a classe chamar peixe temos q criar um construtor chamado peixe
    public Pessoa(){
        Console.WriteLine("construtor execultado");
    }
   
    //o construtor sempre vai ser execultado na class main quando instanciado, portanto quando tivermos algo origatorio 
    //a ser execultado logo de inicio devemos criar um construtor com os patametros e funçoes desejadas


     public Pessoa(string nome, int idade){
        Console.WriteLine("construtor com parametros execultado");
    }
}