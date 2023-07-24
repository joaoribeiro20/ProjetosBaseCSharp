using System;

class Cadastro : Pessoa{

    //private string nome;
    private string nomeOriginal; //CERTO SERIA nome em vez de nomeOriginal, foi colocado so para fins didatico
    // so permite ter acesso a esse parametro a classe origin (A proria class) 'cadastro' ou atraves do get e set
    // assim acessando o Nome em vez de nome
    //devido a boas praticas geralmente o atributo tem a letra inicial meniscula e o nome do metodo tem a letra maiuscula


        //função
        public string Nome{

            //get { return nome; } 
            //set { nome = value; }

            get { return nomeOriginal; } //CERTO SERIA nome em vez de nomeOriginal, foi colocado so para fins didatico
            set { nomeOriginal = value; }//CERTO SERIA nome em vez de nomeOriginal, foi colocado so para fins didatico

        }

        public void dados(int Senha, int CPF){
             Console.WriteLine(nomeOriginal);

            this.senha = Senha;
            this.cpf = CPF;
            Console.WriteLine($"teste realizado com sucesso \ndados são: {senha} + {cpf}");
            mensagemPessoa();

        }

}