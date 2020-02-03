using System;
using System.Collections.Generic;

namespace University
{
    public class Faculty : Department
    {
        public delegate void Message(string message);
        public event Message myEvent;

        public List<Student> students = new List<Student>();
        public Dean Dean { get; set; }

        public Faculty() {}

        public Faculty(string name, Adress adress, Dean dean) : base(name, adress)
        {
            this.Dean = dean;
        }

        public bool AddStudent(Student student)
        {
            if (students.Count == 0)
            {
                myEvent?.Invoke("Student was added");
                students.Add(student);
                return true;
            }
            else if (students.Count <= 10)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (student.Equals(students[i]))
                    {
                        myEvent?.Invoke("Student was added");
                        students.Add(student);
                        return true;
                    }
                }
            }            
            return false;
        }

        public void ShowStudents ()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }

        public override string ToString() => base.ToString() + " " + Dean.ToString();
    }
}
