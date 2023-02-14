using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace KnowYourStudents
{
    internal class JsonHandler
    {
        private static FileInfo classJson = null;
        private static DirectoryInfo classDirectory = null;
        public static bool UpdateOrCreateClassJson(string className)
        {
            // Check if .json File exists in class directory
            
            // TODO: Error Handling for all the file selection Stuff and return true or false
            string currentDirectory = Application.StartupPath;
            classDirectory = new DirectoryInfo(currentDirectory + "//db//" + className);
            FileInfo[] classJsonList = classDirectory.GetFiles(".json");
            
            if (classJsonList.Length == 1)
            {
                classJson = classJsonList[0];
                UpdateJson();
            }
            else if (classJsonList.Length == 0)
            {
                CreateNewJson(className);
            }
            else
            {
                // SOMETHING WENT HORRIBLY WRONG; KILL IT WITH FIRE
            }

            return true;
        }

        public static SchoolClass LoadClassJson()
        {
            return System.Text.Json.JsonSerializer.Deserialize<SchoolClass>(classJson.OpenRead());
        }

        private static void CreateNewJson(string className)
        {
            SchoolClass classFromImages = new SchoolClass();
            FileInfo[] allImagesInFolder = classDirectory.GetFiles();
            
            // TODO add filter for images
            // "jpg", "jpeg", "png", "bmp", "svg"
            foreach (FileInfo file in allImagesInFolder)
            {
                Student student = new Student(file.Name, file.FullName);
                classFromImages.Students.Add(student);
            }

            // TODO Add indentation option for nicer looking file
            string jsonString = JsonSerializer.Serialize(classFromImages);
            File.WriteAllText(classDirectory.FullName + "//progress.json", jsonString);

            // Check if .json File exists in class directory

            // TODO: Error Handling for all the file selection Stuff and return true or false
            string currentDirectory = Application.StartupPath;
            classDirectory = new DirectoryInfo(currentDirectory + "//db//" + className);
            FileInfo[] classJsonList = classDirectory.GetFiles("progress.json");

            Console.WriteLine(classJsonList.Length);
            if (classJsonList.Length == 1)
            {
                classJson = classJsonList[0];
            }

            SchoolClass classFromJSON = LoadClassJson();
            Console.WriteLine(classFromJSON.Students.Count);
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
    }
}
