using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittabe quit = new Employee();
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();

            quit.Quit();


            Console.ReadLine();
        }
    }
}
