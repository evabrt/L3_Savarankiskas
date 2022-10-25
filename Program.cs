using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StudentsContainer allStudents = InOut.ReadStudents(@"Duomenys.csv");

            InOut.PrintStudents("Pradiniai duomenys:", allStudents);
            allStudents.Sort();
            InOut.PrintStudents("\nSurikiuoti duomenys:", allStudents);

            Console.ReadKey();
        }
    }
}
