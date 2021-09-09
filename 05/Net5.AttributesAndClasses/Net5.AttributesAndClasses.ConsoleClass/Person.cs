using Net5.AttributesAndClasses.LibraryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    [MyEspecial]
    public class Person : IPerson,IProfesional
    {
        public string Name { get; set; }
        public Address Address { get ; set ; }

        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public void Run()
        {
            Console.WriteLine("Running");
        }

        public void Run(int i)
        {
            Console.WriteLine($"Running - i : {i}");
        }

        public void Run(string s)
        {
            Console.WriteLine($"Running - s : {s}");
        }

        public void Eat(string entrada, string fondo, string postre)
        {
            Console.WriteLine($"Entrad : {entrada}, Fondo : {fondo}, Postre : {postre}");
        }

        public void Eat(string entrada, string fondo)
        {
            Eat(entrada, fondo, "Torta Tres leche");
        }

        public void Eat(string entrada)
        {
            Eat(entrada, "Filete Mignon");
        }

        public void Eat()
        {
            Eat("Tequeños");
        }
        public void Walk(string p1="test",int p2=0)
        {

        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Travel()
        {
            throw new NotImplementedException();
        }
    }
}
