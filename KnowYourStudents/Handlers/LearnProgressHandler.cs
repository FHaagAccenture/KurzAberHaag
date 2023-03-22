using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowYourStudents
{
    static class LearnProgressHandler
    {
        static int MaxProgress = 100;
        
        // Ensure Learning Progress will always be capped at Max Progress
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
