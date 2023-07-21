using System;

namespace Polimorfismo {
    class Program {
        static void Main(string[] args){
            //Todos funcionarios possui descontos, portanto é temos uma classe generica que possui os descontos ja definidos, porem os descontos mudam de acordo com o cargo 
            //assim dependendo do cargo o desconto é maior, porem ainda continua o mesmo calculo e etc, portanto podemos pegar esse metodo de desconto ja existente e alteraar ele sem precisar 
            //medir na forma original, mudando de acordo com a ocasião separada, no exemplo o estagiario, atendente e gerente sofre um desconto padrão, porem o desconto se forma maior devido a diferença de salario
            //assim para nao ficar repetirndo varias função, criamos outra com mesmo nome e parametros porem com a função de sobreescrever 
            //

            Imposto obj1 = new Gerente();
            Console.WriteLine(" -----------------Gerente---------------");
            obj1.valeAlimentacao(5000);
            obj1.valeTranporte(5000);
            
            Console.WriteLine("-----------------------");

            Imposto obj2 = new Estagiario();
            Console.WriteLine(" -----------------estagiario---------------");
            obj2.valeAlimentacao(1000);
            obj2.valeTranporte(1000);
            
            Console.WriteLine("-----------------------");
            
            Imposto obj3 = new Atendente();
            Console.WriteLine(" -----------------Atendente---------------");
            obj3.valeAlimentacao(2000);
            obj3.valeTranporte(2000);
            
            Console.WriteLine("-----------------------");

           
        }
    }
}
