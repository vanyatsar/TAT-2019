using System;
using System.Collections.Generic;

namespace University
{
    public class University
    {
        public List<Department> Departments { get; set; } = new List<Department>();
        public string Name { get; set; }
        public Adress Adress { get; set; }

        public University() { }

        public University(Adress adress, string name)
        {
            this.Adress = adress;
            this.Name = name;
        }

        public void PrintMessage(string mes)
        { 
            Console.WriteLine("Student was added!"); 
        }

        public bool AddDepartment(Department department)
        {
            if (Departments.Count == 0)
            {
                if (department is Faculty)
                {
                    (department as Faculty).myEvent += this.PrintMessage;
                }
                Departments.Add(department);
                return true;
            }
            else if (Departments.Count <= 10)
            {
                for (int i = 0; i < Departments.Count; i++)
                {
                    if (!department.Equals(Departments[i]))
                    {
                        if (department is Faculty)
                        {
                            (department as Faculty).myEvent += this.PrintMessage;
                        }
                        Departments.Add(department);
                        return true;
                    }
                }
            }
            return false;
        }

        public void ShowDepartments()
        {
            for (int i = 0; i < Departments.Count; i++)
            {
                Console.WriteLine(Departments[i].ToString());
            }
        }

        public override string ToString() => Name + " " + Adress.ToString();
    }
}

