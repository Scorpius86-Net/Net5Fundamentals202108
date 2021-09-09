using Net5.AttributesAndClasses.LibraryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    public class Human : IPerson
    {
        public Address Address { get ; set; }
        public string Name { get ; set ; }

        public void Eat(string entrada, string fondo, string postre)
        {
            throw new NotImplementedException();
        }

        public void Eat(string entrada, string fondo)
        {
            throw new NotImplementedException();
        }

        public void Eat(string entrada)
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        //private string ADN { get; set; }

        public void Run()
        {
            //this.ADN; se peude utilizar solo en el padre
            Console.WriteLine("Running Humman");
        }

        public void Run(int i)
        {
            Console.WriteLine("Running Humman i : {i}");
        }

        public void Run(string s)
        {
            Console.WriteLine("Running Humman s : {s}");
        }

        public void Walk(string p1 = "test", int p2 = 0)
        {
            throw new NotImplementedException();
        }
    }
}
