using System;

namespace University
{
    [Serializable]
    public class DBOAdress
    {
        public int Id { get; set; }
        public int House { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
