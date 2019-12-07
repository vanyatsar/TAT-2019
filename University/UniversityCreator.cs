using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace University
{
    public class UniversityCreator
    {
        IDBProvider provider = new XmlDBProvider();
        
        public void SaveUniversity(University university)
        {
            List<DBOObject> dboObjects = new List<DBOObject>();

            dboObjects = provider.GetDBOObjects(university);

            XmlSerializer formatter = new XmlSerializer(typeof(List<DBOObject>));

            using (FileStream fs = new FileStream("F:\\TAT-2019.2\\University\\XmlFiles\\save.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dboObjects);
            }

            using (FileStream fs = new FileStream("F:\\TAT-2019.2\\University\\XmlFiles\\save.xml", FileMode.OpenOrCreate))
            {
                List<DBOObject> newObjects = (List<DBOObject>)formatter.Deserialize(fs);
            }
        }

        public List<University> GetUniversities()
        {
            return provider.GetUniversities();
        }

        public University CreateUniversity(string name)
        {
            University university = new University {Adress =  provider.GetUniversityAdress(name), Name = name};
            foreach (Faculty faculty in provider.GetFaculties(name))
            {
                university.AddDepartment(faculty);
            }
            return university;
        }
    }
}
