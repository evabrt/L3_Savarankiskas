using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas_3
{
    internal class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int Quantity { get; set; }
        public int[] Grades { get; set; }

        public Student(string surname, string name, string group, int quantity, int[] grades)
        {
            this.Surname = surname;
            this.Name = name;
            this.Group = group;
            this.Quantity = quantity;
            this.Grades = grades;
        }

        public decimal Average
        {
            get
            {
                decimal sum = 0;
                foreach(int g in Grades)
                {
                    sum += g;
                }
                return Math.Round(sum/Quantity, 2);
            }
        }

        public int CompareTo(Student other)
        {
            if (this.Average.CompareTo(other.Average) == 0)
                return this.Surname.CompareTo(other.Surname);
            return this.Average.CompareTo(other.Average);
        }

        public override string ToString()
        {
            return String.Format("| {0, -15} | {1, -15} | {2, -10} | {3, -8} | {4, -15} | {5, -10} |", Surname, Name, Group, Quantity, GradesToString, Average);
        }

        public string GradesToString
        {
            get
            {
                string line = "";
                foreach (int g in Grades)
                {
                    line += g + " ";
                }
                return line;
            }
        }
    }
}
