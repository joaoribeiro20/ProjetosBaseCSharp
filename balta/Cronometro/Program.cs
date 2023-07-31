using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {

            //desaios : adicionar um time fixo, mudar para contar por segundo em vez de contar ate 60 e assim por diante
            //fazer cronometro regresiivo
            Menu();
        }
///////////////////////////////////////////////////////////////////////

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready....");
            Thread.Sleep(1000);
            Console.WriteLine("Set....");
            Thread.Sleep(1000);
            Console.WriteLine("Go....");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Menu(){

            Console.Clear();
            Console.WriteLine("M - Minutos  | => 10s = 10 Segundos");
            Console.WriteLine("S - Segundos | => 10m = 10 Minutos ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto Tempo deseja contar?");

            //1s
            //1160s
            //123456543s
            //00sss

            String data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0, data.Length-1));
            //Console.WriteLine(data);
            //Console.WriteLine(type);
            //Console.WriteLine(time);

            int multiplier = 1;

            if(type == 'm'){
                multiplier = 60;
            }
            if(time == 0 ){
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);
    
        }
        static void Start(int time)
        {
            int currentTime = 0; //current time = minuto atual (tradução livre)

           while (currentTime != time)
           {
            Console.Clear();
            currentTime ++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); //faz nosso programa "dormir" por 1 segundo 
           }

           Console.Clear();
           Console.WriteLine("Cronometro finalizado");
           Thread.Sleep(2500);
           Menu();
        }

    }
}