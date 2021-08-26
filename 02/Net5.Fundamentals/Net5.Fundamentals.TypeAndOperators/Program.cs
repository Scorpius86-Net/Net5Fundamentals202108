using System;
using Net5.Fundamentals.TypeAndOperators.Tests;

namespace Net5.Fundamentals.TypeAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 5;
            int b = a + 2;

            bool test = true;

            //int c = a + test;

            MyClass myClass = new MyClass();
            myClass.MyProperty = 5;            
            Console.WriteLine(myClass.MyProperty);

            ChangeValue(a);
            Console.WriteLine(a);

            ChangeMyClass(myClass);
            Console.WriteLine(myClass.MyProperty);

            int aa = 123;
            System.Int32 bb = 123;

            int c = aa + bb;
            int hexLiteral = 0x2A;
            Console.WriteLine(hexLiteral);
            int binary = 0b_0010_1010;

            var chars = new[]
            {
                'j',
                '\u006A',
                '\x006A',
                (char)106
            };

            Console.WriteLine(string.Join(" ", chars));

            Console.WriteLine((int)Season.Autum);
            Console.WriteLine(Season.Autum);
            Console.WriteLine((int)ErrorCode.OutLierReading);

            var error = ErrorCode.ConnectionLost;

            if (ErrorCode.OutLierReading == error)
            {
                //ToDo
            }
            if (ErrorCode.ConnectionLost == error)
            {
                //Other ToDo
            }




            static void ChangeMyClass(MyClass param)
            {
                param.MyProperty = 20;
            }
            static void ChangeValue(int param)
            {
                param = 20;
            }
        }
    }
}
