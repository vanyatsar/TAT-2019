using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace University
{
    [Serializable]
    public class Student : Person
    {
        public List<int> Marks { get; set; }

        public Student() { }

        public Student(string firstname, string secondname, int year, List<int> marks) : base(firstname, secondname, year)
        {
            this.Marks = marks;
        }
    }
}
