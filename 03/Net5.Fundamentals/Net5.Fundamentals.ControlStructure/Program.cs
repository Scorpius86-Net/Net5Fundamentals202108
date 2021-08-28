using System;

namespace Net5.Fundamentals.ControlStructure
{
    class Program
    {        
        static void Main(string[] args)
        {
            ControlStructureImplement controlStructureImplement = new ControlStructureImplement();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Control Structure");
                Console.WriteLine("=================");
                Console.WriteLine(" 1 - If Structure");
                Console.WriteLine(" 2 - If Else If Structure");
                Console.WriteLine(" 3 - If Nested Structure");
                Console.WriteLine(" 4 - For Structure");
                Console.WriteLine(" 5 - While Structure");
                Console.WriteLine(" 6 - Do While Structure");
                Console.WriteLine(" 7 - Switch Structure");
                Console.WriteLine(" 8 - Break Command");
                Console.WriteLine(" 9 - Continue Command In For");
                Console.WriteLine("10 - Continue Command In While");
                Console.WriteLine("11 - GoTo Command in Switch");
                Console.WriteLine("12 - ForEach Structure");
                Console.WriteLine("13 - Try Catch Structure");
                Console.WriteLine("14 - Try Catch Finally Structure");
                Console.WriteLine("99 - Exit");
                Console.WriteLine("");
                Console.WriteLine("Elija una opción : ");
                string opt = Console.ReadLine();

                Console.Clear();

                switch (opt)
                {
                    case "1":
                        controlStructureImplement.IfStructure();
                        break;
                    case "2":
                        controlStructureImplement.IfElseIfStructure();
                        break;
                    case "3":
                        controlStructureImplement.IfNested();
                        break;
                    case "4":
                        controlStructureImplement.ForStructure();
                        break;
                    case "5":
                        controlStructureImplement.WhileStructure();
                        break;
                    case "6":
                        controlStructureImplement.DoWhileStructure();
                        break;
                    case "7":
                        controlStructureImplement.SwitchStructure();
                        break;
                    case "8":
                        controlStructureImplement.BreakCommand();
                        break;
                    case "9":
                        controlStructureImplement.ContinueCommandInFor();
                        break;
                    case "10":
                        controlStructureImplement.ContinueCommandInWhile();
                        break;
                    case "11":
                        controlStructureImplement.GoToCommandInSwitch();
                        break;
                    case "12":
                        controlStructureImplement.ForEachStructure();
                        break;
                    case "13":
                        controlStructureImplement.TryCatchStructure();
                        break;
                    case "14":
                        controlStructureImplement.TryCatchFinallyStructure();
                        break;
                    case "99":
                        exit = true;
                        break;
                    default:
                        break;
                }

              
                if (opt != "99")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
    }
}

