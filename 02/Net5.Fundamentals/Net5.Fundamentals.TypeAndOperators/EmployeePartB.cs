using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypeAndOperators
{
    public partial class Employee
    {
        public string EyesColor { get; set; }
        public int Size { get; set; }
        partial void OnNameChanged()
        {

        }

        public void Eat()
        {

        }
    }
}
