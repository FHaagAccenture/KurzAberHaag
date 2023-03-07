using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowYourStudents
{
    public class SchoolClass
    {
        public List<Student> Students { get; set; }
        public string SchoolClassName { get; set; }
        public int ProgressTotal { get; set; }

        public SchoolClass(string schoolClassName)
        {
            SchoolClassName = schoolClassName;
            Students = new List<Student>();
            ProgressTotal = 0;
        }
    }
}
