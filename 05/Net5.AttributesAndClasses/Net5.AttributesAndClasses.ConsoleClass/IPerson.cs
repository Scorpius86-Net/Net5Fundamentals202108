using Net5.AttributesAndClasses.LibraryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    public interface IPerson
    {
        public Address Address { get; set; }
        public string Name { get; set; }

        void Run();
        void Run(int i);
        void Run(string s);

        void Eat(string entrada, string fondo, string postre);
        void Eat(string entrada, string fondo);
        void Eat(string entrada);
        void Eat();
        void Walk(string p1 = "test", int p2 = 0);
    }
}
