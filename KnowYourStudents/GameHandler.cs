using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowYourStudents
{
    internal class GameHandler
    {
        private static Random random;
        // Cumulative weighted randomizer algorithm
        public static Student determineNextStudent(SchoolClass schoolClass)
        {
            random = new Random();
            int weightSum = 0;
            List<int> weights = new List<int>();
            foreach (Student student in schoolClass.Students)
            {
                weightSum = weightSum + (101 - student.LearningProgress);
                weights.Add(weightSum);
            }
            int randomNummer = random.Next(weightSum);
            int index = 0;
            while (weights[index] < randomNummer)
            {
                index++;
            }
            return schoolClass.Students[index];
        }
    }
}
