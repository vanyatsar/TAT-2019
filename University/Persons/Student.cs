using System.Collections.Generic;

namespace University
{
    /// <summary>
    /// Class which create students objects. 
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Students list of marks.
        /// </summary>
        public List<int> Marks { get; set; }
        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public Student() 
        { 
        }
        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="firstname">Firstname.</param>
        /// <param name="secondname">Secondname.</param>
        /// <param name="year">Year of birth.</param>
        /// <param name="marks">Student marks.</param>
        public Student(string firstname, string secondname, int year, List<int> marks) : base(firstname, secondname, year)
        {
            this.Marks = marks;
        }
        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>String with information about student.</returns>
        public override string ToString() => base.ToString() + " " + Marks.ToString();        
    } 
}

