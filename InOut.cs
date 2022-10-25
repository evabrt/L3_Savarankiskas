using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas_3
{
    internal class InOut
    {
        public static StudentsContainer ReadStudents(string fileName)
        {
            StudentsContainer students = new StudentsContainer();
            string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
            students.Faculty = lines[0];
            for(int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(';');
                string surname = values[0];
                string name = values[1];
                string group = values[2];
                int quantity = int.Parse(values[3]);
                int[] grades = new int[quantity];
                for(int j = 0; j < quantity; j++)
                {
                    grades[j] = int.Parse(values[j+4]);
                }
                Student student = new Student(surname, name, group, quantity, grades);
                students.Add(student);
            }
            return students;
        }

        public static void PrintStudents(string header, StudentsContainer students)
        {
            string[] lines = new string[students.Count + 8];
            Console.WriteLine(header);
            Console.WriteLine(students.Faculty);
            Console.WriteLine(new string('-', 92));
            Console.WriteLine(String.Format("| {0, -15} | {1, -15} | {2, -10} | {3, -8} | {4, -15} | {5, -10} |", "Pavardė", "Vardas", "Grupė", "Kiekis", "Pažymiai", "Vidurkis"));
            Console.WriteLine(new string('-', 92));
            for(int i = 0; i < students.Count; i++)
            {
                Student s = students.Get(i);
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine(new string('-', 92));
            
        }
    }
}
