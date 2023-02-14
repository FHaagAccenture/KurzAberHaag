using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KnowYourStudents
{
    internal class jsonHandler
    {
        private static FileInfo classJson = null;
        public static bool UpdateOrCreateClassJson(string className)
        {
            // Check if .json File exists in class directory
            
            // TODO: Error Handling for all the file selection Stuff and return true or false
            string currentDirectory = Application.StartupPath;
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + "//db//" + className);
            FileInfo[] classJsonList = directoryInfo.GetFiles(".json");
            
            if (classJsonList.Length == 1)
            {
                classJson = classJsonList[0];
                UpdateJson();
            }
            else if (classJsonList.Length == 0)
            {
                CreateNewJson();
            }
            else
            {
                // SOMETHING WENT HORRIBLY WRONG; KILL IT WITH FIRE
            }

            return true;
        }

        private static void CreateNewJson()
        {
            // Flow:
            // Load Data from Image-Files
            // Create Data Structure with them
            // Load Data Structure into JSON and save it
        }

        private static void UpdateJson()
        {
            // Flow:
            // Load Data From Image-Files
            // Create Data Structure with them
            // Load Existing Json (can use loadClassJson())
            // Compare the 2 existing datastructures and merge them (probably needlessly complex algorithm)
            // Load merge Data structure into Json and replace/update old one
        }

        public static void loadClassJson()
        {
            // Load the data from Json file and turn it into object in memory
            // Return that object or whatever it actually is
        }
    }
}
