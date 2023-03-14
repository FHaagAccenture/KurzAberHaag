using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowYourStudents
{
    internal class LearnProgressHandler
    {
        static int MaxProgress = 100;
        
        public static void IncreaseStudentProgress(Student student, int progress)
        {
            if (student.LearningProgress <= MaxProgress - progress)
            {
                student.LearningProgress += progress;
            }
            else
            {
                student.LearningProgress = MaxProgress;
            }
        }

    }
}
