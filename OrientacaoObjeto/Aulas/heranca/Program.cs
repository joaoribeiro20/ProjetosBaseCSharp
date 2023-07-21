using System;

namespace heranca{
    class Program{
        static void Main(string[] args)
        {

            //aqui instanciamos um objeto da clase Colaborador, porem na classe Colaborador Não
            //tem nenhum função ou variavel que esteja relacionada com nome e idade, portanto 
            //quem possui essas informaçoes e funçoes é a classe pessoa, assim podemos fazer que 
            //a classe Colaborador herde todos atributods e funçoes da classe pessoa e usei como
            //se fosse da proria classse colaborador

            //muito importante tambem lembrar que devido a boas praticas devemos usar o restrição de acesso (protecte)
            //principlamente nas classe que vao ser usada para ser herdada.

            //importante lembrar que nao existe herança multiplas, portanto a class colaborador pode herda apenas pessoa
            //ou outra class, porem nunca pode herda masi de 1 classe ao mesmo tempo
            //Class colaborador : pessoa ----- correto 
            //Class Colaborador : pessoa : carga ----- errado (não é permitindo herda 2 class)
            Colaborador obj = new Colaborador("joao", 21, 3014);

        }
    }
}
