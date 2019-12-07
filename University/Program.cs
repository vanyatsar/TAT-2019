using System;
using System.Collections.Generic;

namespace University
{ 
    class Program
    {
        static void Main(string[] args)
        {    
            UniversityCreator manager = new UniversityCreator();
            List<University> universities = new List<University>();

            universities = manager.GetUniversities();

            University university = new University();
            University university1 = new University();

            university = manager.CreateUniversity("BSU");
            Console.WriteLine(university.ToString());
            university.ShowDepartments();

            Console.WriteLine("---------------------------------------");
            university1 = manager.CreateUniversity("Polesskiy");
            Console.WriteLine(university1.ToString());

            university1.ShowDepartments();
           
           // manager.SaveUniversity(university);
        }
    }
}
