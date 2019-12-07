using System;

namespace University
{
    [Serializable]
    public class DBOFaculty
    {
        public string Name { get; set; }
        public int AdressId { get; set; }
        public int Id { get; set; }
        public int UniversityId { get; set; }
    }
}
