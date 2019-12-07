using System.Collections.Generic;

namespace University
{
    interface IDBProvider
    {
        Adress GetAdressById(int i);
        Adress GetUniversityAdress(string name);
        DBOUniversity GetDBOUniversityId(string name);
        List<Faculty> GetFaculties(string name);
        List<University> GetUniversities();
        List<DBODean> GetDBODeans();
        List<DBOObject> GetDBOObjects(University university);
    }
}