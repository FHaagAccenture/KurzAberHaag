using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowYourStudents
{
    internal class SchoolClass
    {
        public List<Student> Students { get; set; }
        public string ClassName { get; set; }
        public int ProgressTotal { get; set; }

        public SchoolClass(string className)
        {
            ClassName = className;
            Students = new List<Student>();
            ProgressTotal = 0;
        }
    }
}
