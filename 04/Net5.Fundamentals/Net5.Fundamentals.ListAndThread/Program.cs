using System;

namespace Net5.Fundamentals.ListAndThread
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            bool exit = false;
            ListAndThread listAndThread = new ListAndThread();

            do
            {
                Console.Clear();
                Console.WriteLine("List And Thread");
                Console.WriteLine("===============");
                Console.WriteLine(" 1 - Array");
                Console.WriteLine(" 2 - List");
                Console.WriteLine("99 - Exit");
                Console.WriteLine("Seleccione una opción : ");
                opt = Console.ReadLine();
                Console.Clear();

                switch (opt)
                {
                    case "1":
                        listAndThread.ArraySample();
                        break;
                    case "2":
                        listAndThread.ListSample();
                        break;
                    case "99":
                        exit = true;
                        break;
                    default:
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            } while (!exit);
        }
    }
}
