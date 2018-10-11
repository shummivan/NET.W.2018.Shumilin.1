using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUniversityStrongName
{
    public class University
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Boss { get; set; }

        public University(string name, string boss)
        {
            Name = name;
            Boss = boss;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Boss);
        }
    }
}
