using System;
using System.IO;

namespace editorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma das opçoes a baixo!!");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            short op = short.Parse(Console.ReadLine());

            switch(op)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
            }

        }

        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }
        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            //Console.Write(text);
            Salvar(text);
           
        }
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("qual caminho para salvar o arquivo");
            var path = Console.ReadLine(); //caminho = path traducçao do ingles para portugues

            using(var file = new StreamWriter(path)) // usar o using permite vc abrir/criar o objeto e apos usado ele sempre fecha, portanto assim é uma garantia que sempre iremos abrir e fechar 
            {
                file.Write(text);
            }

            Console.WriteLine($"arquivo {path} salvo com sucesso");
            Console.ReadLine();
            Menu();
        }
    }

}
