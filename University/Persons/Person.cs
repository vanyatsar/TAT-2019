using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace University
{
    [Serializable]
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public Person() {}

        public Person(string firstname, string secondname, int year)
        {
            this.FirstName = firstname;
            this.LastName = secondname;
            this.Year = year;
        }

        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            if (this.FirstName == person.FirstName &&
                this.LastName == person.LastName && 
                this.Year == person.Year)
            {
                return false;
            }
            return true;
        }

        public override string ToString() => this.FirstName + " " + this.LastName + " " + this.Year.ToString();
    }
}
