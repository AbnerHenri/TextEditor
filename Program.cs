using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("----------TextEditor----------");
            Console.WriteLine();
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Novo arquivo");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();
            Console.Write("Digite sua opção: ");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Abrir();
                    break;

                case 2:
                    Editar();
                    break;

                case 3:
                    RepeatMessage(5, "Saindo ");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Não conseguimos identificar sua opção");
                    break;
            }
        }

        static void Abrir(){

        }

        static void Editar(){

        }

        static void RepeatMessage(int num, string message){

            int limiter = 0;
            string point = "";

            while(num != limiter){

                point += ".";
                num -= 1;

                Console.Clear();
                Console.Write(message + point);
                Thread.Sleep(1000);
            }

            Console.Clear();
        }
    }
}