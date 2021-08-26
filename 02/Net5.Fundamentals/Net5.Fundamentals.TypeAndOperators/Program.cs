﻿using System;
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

            Coords coords01 = new Coords
            {
                X = 1,
                Y = 2,
                Z=3
            };
            Coords coords02 = new Coords(1, 2, 3);
            //coords01.X = 3;

            (MyClass,string name,int, int, int, int, int) t1 = (new MyClass(),"tr",5, 4, 4, 4, 4);
            Console.WriteLine(t1.name);

            bool? eval = null;
            int? num = null;
            int numNotNull = 0;
            string cad = null;
            MyClass myClass1 = null;
            
            if (num.HasValue)
            {
                int sum = numNotNull + num.Value;
            }

            //int numVar = 15; Explicitly
            var numVar = 15; //Implicitly
            //string stringVar = "45";
            var stringVar = "45";




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