﻿using System;

namespace exe1
{
        class Program
    {
        Boolean ap = true;
        static void Main(String[] args)
        {
            Aluno obj1 = new Aluno();
            Console.WriteLine(" bem vindo!! \n Voce é Aluno ou Professor ?");
            string leituraI = Console.ReadLine();

            //caso for aluno 
            if(leituraI == "aluno"){
                Console.WriteLine("Voce ja possui cadastro ou email Educacional?!! \n Sim ou Não");
                string alunoQ = Console.ReadLine();
                //caso for aluno ja cadastrado
                if(alunoQ == "sim"){
                    Console.WriteLine("OLÁ Aluno \n Digite seu email educacional e sua senha (Lembrando que a senha é seu RA) ");
                    Console.Write("email:");
                    string emaila = Console.ReadLine();
                    Console.Write("senha:");
                    string senhaa = Console.ReadLine();
                    

                }
                else{
                    Console.WriteLine("Digite seu email pessoal");
                    string cadastroA1 = Console.ReadLine();
                    Console.WriteLine("Digite seu numero de telefone");
                    int cadastroA2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite seu nome");
                    string cadastroA3 = Console.ReadLine();
                    obj1.cadastro(cadastroA3, cadastroA1, cadastroA2);
                }
            }

            //caso for professor

        if(leituraI == "professor"){

        }

        }
    }
}
