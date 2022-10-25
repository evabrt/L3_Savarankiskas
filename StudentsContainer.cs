using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas_3
{
    internal class StudentsContainer
    {
        private Student[] students;
        public string Faculty { get; set; }
        public int Count { get; private set; }
        private int Capacity;

        public StudentsContainer(int capacity = 16)
        {
            this.Capacity = capacity;
            this.students = new Student[capacity];
        }

        public StudentsContainer()
        {
            this.students = new Student[16]; //default capacity
        }
        public StudentsContainer(StudentsContainer container) : this()
        {
            for (int i = 0; i < container.Count; i++)
            {
                this.Add(container.Get(i));
            }

        }
        public void Add(Student student)
        {
            if (this.Count == this.Capacity) // container is full
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.students[this.Count++] = student;
        }
        public Student Get(int index)
        {
            return this.students[index];
        }

        private void EnsureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Student[] temp = new Student[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.students[i];
                }
                this.Capacity = minimumCapacity;
                this.students = temp;
            }
        }

        public void Sort()
        {
            bool flag = false;
            while(flag)
            {
                flag = false;
                for (int i = 0; i < this.Count - 1; i++)
                {
                    Student a = this.students[i];
                    Student b = this.students[i + 1];
                    if(a.CompareTo(b) > 0)
                    {
                        this.students[i] = b;
                        this.students[i + 1] = a;
                        flag = true;
                    }
                }
            }
        }
    }
}
