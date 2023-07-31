using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma();//Subtracao();//Divisao();//Multiplicação();
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("Funçoes matematicas disponiveis dentro do sistema!!");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");
            Console.WriteLine("Selecione a opção que deseja que seja excultada!!");
            short res = short.Parse(Console.ReadLine());
            //short é um tipo de variavel que armazerna uma quantidade pequena de numeros, comos temos apenas do 1 ao 5 não a necessidae de um int 


            switch(res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicação(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break; //O Zero representa um parametro de sucesso, portanto caso se sai do sistema vai ser enciado 0 
                default: Menu(); break;
            }

        }
/////////////////////////////////////////////////////////////////
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao(){
           Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da Subtração é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicação(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da Multiplicação é : {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da Divisão é : {resultado}");
            Console.ReadKey();
            Menu();
            }

        static void Media(){
        }
        static void RetanguloArea(){}
        static void CilindroArea(){}
    }
}