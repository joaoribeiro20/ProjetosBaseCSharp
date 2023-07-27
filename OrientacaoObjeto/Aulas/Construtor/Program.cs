using System;

namespace Construtor
{
    class program{
        static void Main(string[] args)
        {
            //podemos observar que nao realizamos nenhum comando e nada, so instanciamos a class pessoa 
            //portanto como essa class possui um costrutor altomaticamente vai ser execultado qualquer coisa que esta
            //dentro daquele construtor, assim apenas instanciado ele ja é o bastante
        Pessoa p = new Pessoa();

        Pessoa p2 = new Pessoa("joao", 21);
        }

    }
}
