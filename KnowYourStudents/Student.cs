using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowYourStudents
{
    public class Student
    {
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public int LearningProgress { get; set; }

        public Student(string name, string imgPath)
        {
            Name = name;
            ImgPath = imgPath;
            LearningProgress = 0;
        }
    }
}
