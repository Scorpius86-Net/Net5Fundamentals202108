using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    public class ProcessPerson
    {
        public void ProcessNameByReference(IPerson person)
        {
            person.Name = person.Name + " - Process";
        }

        public void ProcessNameWhitoutReference(IPerson person)
        {
            Person p = new Person(person.Name);
            p.Name = p.Name + " - Process";
        }

        public void MyMethodOne(int i)
        {
            Console.WriteLine($"One - El valor de i : {i}");
        }

        public void MyMethodTwo(int i)
        {
            Console.WriteLine($"Two - El valor de i : {i}");
        }
    }
}
