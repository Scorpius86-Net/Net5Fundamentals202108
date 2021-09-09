using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.FunctionalProgramming.Samples
{
    public class Lambda
    {
        delegate int operationDelegate(int x, int y);
        public void DoWork()
        {
            List<Student> students = new List<Student> { new Student { Name = "Erick", Age = 39 }, new Student { Name = "Oscar", Age = 17 }, new Student { Name = "Cosme", Age = 25 } };

            bool isCosme = false;
            foreach (var student in students)
            {
                if (student.Name == "Cosme")
                {
                    isCosme = true;
                    break;
                }
            }

            Console.WriteLine($"[ForEach] - Esta Cosme? : {isCosme}");

            isCosme = false;
            isCosme = students.Any(FindCosme);
            Console.WriteLine($"[Fucntion] - Esta Cosme? : {isCosme}");

            isCosme = false;
            isCosme = students.Any((s) =>
            {
                return s.Name == "Cosme";
            });
            Console.WriteLine($"[Lambda with body] - Esta Cosme? : {isCosme}");

            isCosme = false;
            isCosme = students.Any((s) => s.Name == "Cosme");
            Console.WriteLine($"[Lambda] - Esta Cosme? : {isCosme}");

            Print(5, 5, Sum);
            Print(5, 5, Subtract);
            Print(5, 5, (a, b) => {
                return a + b;
            });
            Print(5, 5, (a, b) => a + b);
            Print(4, 2, (x, y) => x * y);
            Print(6, 6, (a, b) => a + b);
            Print(144, 66, (x, y) => x * y);

            FunctionDelegate();
            ActionDelegate();
        }

        private void FunctionDelegate()
        {
            //Func<string, string> selector = ToUpper;
            Func<string, string> selector = (s) => s.ToUpper();
            List<string> words = new List<string> { "Naranja", "Manzana", "Articulo", "Elefante" };
            List<string> aWords = words.Select(selector).ToList();
            aWords.ForEach(w =>
            {
                Console.WriteLine(w);
            });


            Func<int, bool> isEven = IsEven;
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"El total de numeros pares entre el 1 y 9 es : {TotalEvens(numbers, isEven)}");
        }

        private int TotalEvens(List<int> numbers, Func<int, bool> validEven)
        {
            int total = 0;
            numbers.ForEach(number =>
            {
                if (validEven(number))
                {
                    total++;
                }
            });
            return total;
        }

        private bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        private void ActionDelegate()
        {
            Action<string> messageTarget;
            string param = "";

            if (param.Length > 0)
            {
                messageTarget = ShowWindowsMessage;
            }
            else
            {
                messageTarget = Console.WriteLine;
            }            

            messageTarget("Hola mundo");
        }

        private void ShowWindowsMessage(string message)
        {
            Console.WriteLine(message);
        }

        private string ToUpper(string s)
        {
            return s.ToUpper();
        }

        private void Print(int a, int b,operationDelegate operation)
        {
            int result = operation(a, b);
            Console.WriteLine($"Imprimiendo : {result}");
        }

        private int Sum(int a, int b)
        {
            return a + b;
        }
        private int Subtract(int a, int b)
        {
            return a - b;
        }

        private bool FindCosme(Student s)
        {
            return s.Name == "Cosme";
        }
        private bool FindErick(Student s)
        {
            return s.Name == "Erick";
        }

        private bool FindErickString(string s)
        {
            return s == "Erick";
        }
    }
}
