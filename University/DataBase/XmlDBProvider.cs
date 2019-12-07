using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace University
{
    [Serializable]
    public class XmlDBProvider : IDBProvider
    {
        XDocument xdoc;
        
        public XmlDBProvider()
        {
            this.xdoc = XDocument.Load("XmlFiles\\University.xml");
        }

        public List<DBOObject> GetDBOObjects(University university)
        {
            List<DBOObject> dboObjects = new List<DBOObject>();

            dboObjects.Add(new DBOObject { DBOAdresses = GetDBOAdresses(university)});
            dboObjects.Add(new DBOObject { DBOStudents = GetDBOStudents() });
            return dboObjects;
        }

        private List<DBOAdress> GetDBOAdresses(University university) => (from n in xdoc.Root.Element("adresses").Elements("adress")
                                                     select new DBOAdress
                                                     {
                                                         City = n.Element("city").Value,
                                                         Street = n.Element("street").Value,
                                                         House = Int32.Parse(n.Element("house").Value),
                                                         Id = Int32.Parse(n.Element("ID").Value)
                                                     }).ToList();

        public List<DBODean> GetDBODeans() => (from n in xdoc.Root.Element("adresses").Elements("adress")
                                                     select new DBODean
                                                     {
                                                         FirstName = n.Element("firstname").Value,
                                                         SecondName = n.Element("secondname").Value,
                                                         Year = Int32.Parse(n.Element("year").Value),
                                                         Degree = n.Element("degree").Value,
                                                         FacultyId = Int32.Parse(n.Element("facultyID").Value)
                                                     }).ToList();

        private List<DBOStudent> GetDBOStudents() => (from xe in xdoc.Root.Element("persons").Element("students").Elements("student")
                                                      select new DBOStudent
                                                      {
                                                          FirstName = xe.Element("firstname").Value,
                                                          SecondName = xe.Element("secondname").Value,
                                                          Year = Int32.Parse(xe.Element("year").Value),
                                                          Marks = ((xe.Element("marks").Value).Split(' ').ToList()
                                                          .Select(x => Int32.Parse(x)).ToList())
                                                      }).ToList();

        public List<University> GetUniversities() => (
            from n in xdoc.Root.Element("universities").Elements("university")                                                     
            select new University {
                Adress = GetAdressById(Int32.Parse(n.Element("adressID").Value)),
                Name = n.Element("name").Value
            }).ToList();
        
        public Adress GetUniversityAdress(string name) => (
            from n in xdoc.Root.Element("adresses").Elements("adress")
            where Int32.Parse(n.Element("ID").Value) == GetDBOUniversityId(name).AdressId
            select new Adress {
                City = n.Element("city").Value,
                Street = n.Element("street").Value,
                House = Int32.Parse(n.Element("house").Value)
                }).First();

        public Adress GetAdressById(int id) => (
            from n in xdoc.Root.Element("adresses").Elements("adress")                                
            where Int32.Parse(n.Element("ID").Value) == id
            select new Adress {
                City = n.Element("city").Value,
                Street = n.Element("street").Value,
                House = Int32.Parse(n.Element("house").Value)
            }).First();

        public List<Student> GetStudents(int id) => (
            from xe in xdoc.Root.Element("persons").Element("students").Elements("student")
            where Int32.Parse(xe.Element("facultyID").Value) == id
            select new Student {
                FirstName = xe.Element("firstname").Value,
                LastName = xe.Element("secondname").Value,
                Year = Int32.Parse(xe.Element("year").Value),
                Marks = (xe.Element("marks").Value).Split(' ').ToList()
                .Select(x => Int32.Parse(x)).ToList()
                }).ToList();

        public Dean GetDean(int id) => (from n in xdoc.Root.Element("persons").Element("deans").Elements("dean")
                                        where Int32.Parse(n.Element("facultyID").Value) == id
                                        select new Dean
                                        {
                                            FirstName = n.Element("firstname").Value,
                                            LastName = n.Element("secondname").Value,
                                            Year = Int32.Parse(n.Element("year").Value),
                                            Degree = n.Element("degree").Value
                                            }).First();

        public DBOUniversity GetDBOUniversityId(string name) => (
            from n in xdoc.Root.Element("universities").Elements("university")                                                 
            where n.Element("name").Value == name                                                            
            select new DBOUniversity                                                   
            {                                                             
                Id = Int32.Parse(n.Element("ID").Value),                                                                
                AdressId = Int32.Parse(n.Element("adressID").Value)                                                            
            }).First();

        public List<Faculty> GetFaculties(string name)
        {
            List<Faculty> faculties = new List<Faculty>();
            List<Student> students = new List<Student>();
            Faculty faculty = new Faculty();
            Dean dean = new Dean();
            Adress adress = new Adress();

            IEnumerable<DBOFaculty> items = from n in xdoc.Root.Element("departments").Element("faculties").Elements("faculty")
                                            where Int32.Parse(n.Element("universityID").Value) == GetDBOUniversityId(name).Id
                                            select new DBOFaculty
                                            {
                                                AdressId = Int32.Parse(n.Element("adressID").Value),
                                                Id = Int32.Parse(n.Element("ID").Value),
                                                Name = n.Element("name").Value
                                            };
            foreach (DBOFaculty item in items)
            {
                dean = GetDean(item.Id);
                students = GetStudents(item.Id);
                adress = GetAdressById(item.AdressId);

                faculty = new Faculty {Adress =  adress, Name = item.Name, Dean = dean};

                foreach (Student student in students)
                {
                    faculty.AddStudent(student);
                }
                faculties.Add(faculty);
            }            
            return faculties;
        }

    }       
}

