using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittabe
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This is my quit method");
        }
    }
}
