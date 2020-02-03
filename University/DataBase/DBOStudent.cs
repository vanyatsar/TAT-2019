using System;
using System.Collections.Generic;

namespace University
{
    public class DBOStudent
    {
        public int FacultyId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Year { get; set; }
        public List<int> Marks { get; set; }
    }
}
