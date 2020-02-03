using System;

namespace University
{
    public abstract class Department
    {
        public Adress Adress { get; set; }
        public string Name { get; set; }        

        public Department() { }

        public Department(string name, Adress adress)
        {
            this.Name = name;
            this.Adress = adress;
        }

        public override bool Equals(object obj)
        {
            Department department = obj as Department;
            return (Name == department.Name && Adress.Equals(department.Adress)) ;
        }

        public override string ToString() => Name + " " + Adress.ToString();

    }
}