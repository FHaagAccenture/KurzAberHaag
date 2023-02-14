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
        private static FileInfo classJson;
        private static DirectoryInfo classDirectory;
        private static string schoolClassName;

        public static void UpdateOrCreateClassJson(string className)
        {
            // TODO: Error Handling for selecting Directory

            schoolClassName = className;
            classDirectory = new DirectoryInfo(Application.StartupPath + "//db//" + schoolClassName);
            classJson = classDirectory.GetFiles("progress.json").FirstOrDefault();

            if (classJson != null)
            {
                UpdateJson();
            }
            else
            {
                CreateNewJson(className);
            }
        }

        private static void UpdateJson()
        {
            SchoolClass classFromFiles = CreateSchoolClassFromFiles();
            SchoolClass classFromJson = LoadClassJson();

            // TODO:
            // - Compare the two Student-Lists
            // - Create a new List based on that and save it as JSON String
            // - CreateJsonFileFromSchoolClass(schoolClassCompared);
        }

        private static void CreateNewJson(string className)
        {
            SchoolClass schoolClass = CreateSchoolClassFromFiles();
            CreateJsonFileFromSchoolClass(schoolClass);
        }

        private static SchoolClass CreateSchoolClassFromFiles()
        {
            SchoolClass schoolClass = new SchoolClass(schoolClassName);
            FileInfo[] allFilesInFolder = classDirectory.GetFiles();
            foreach (FileInfo file in allFilesInFolder)
            {
                // TODO: 
                // - Split Name and remove file extension
                // - Filter for only images
                // "jpg", "jpeg", "png", "bmp", "svg"
                Student student = new Student(file.Name, file.FullName);
                schoolClass.Students.Add(student);
            }
            return schoolClass;
        }

        private static void CreateJsonFileFromSchoolClass(SchoolClass schoolClass)
        {
            // TODO 
            // Add indentation option for nicer looking file
            // Error Handling for Serialize & Writing
            string jsonString = JsonSerializer.Serialize(schoolClass);
            File.WriteAllText(classDirectory.FullName + "//progress.json", jsonString);

            // Update classJson
            classJson = classDirectory.GetFiles("progress.json").FirstOrDefault(); 
        }

        public static SchoolClass LoadClassJson()
        {
            // TODO: Error Handling
            return System.Text.Json.JsonSerializer.Deserialize<SchoolClass>(classJson.OpenRead());
        }
    }
}
