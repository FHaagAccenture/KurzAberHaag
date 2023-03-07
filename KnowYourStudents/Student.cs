using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowYourStudents
{
    public class Student
    {
        // TODO Split Name at some delimiter
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public int Appeared { get; set; }
        public int GotCorrect { get; set; }
        public int Score { get; set; }

        public Student(string name, string imgPath)
        {
            Name = name;
            ImgPath = imgPath;
            Appeared = 0;
            GotCorrect = 0;
            Score = 0;
        }
    }
}
