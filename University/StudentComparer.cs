using System;
using System.Collections.Generic;

namespace University
{
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1.FirstName != null && student2.LastName != null)
            {
                return student1.LastName.CompareTo(student2.LastName);
            }
            else
                throw new NotImplementedException();
        }
    }
}