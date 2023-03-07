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
        // Change to allow different file extension for images
        // Careful: They need to be compatible with Windows Forms
        private static List<string> supportedFileTypes = new List<string> { "jpg", "jpeg", "png", "bmp" };


        private static DirectoryInfo classDirectory;
        private static FileInfo classJson;
        private static string schoolClassName;
        
        // Only exposed function that will be called from outside of JSON-Handler
        public static SchoolClass LoadSchoolClass(string ClassName)
        {
            schoolClassName = ClassName;

            try
            {
                UpdateOrCreateSchoolClassJson();
                return CreateSchoolClassFromJson();
            } 
            catch
            {
                return null;
            }
        }
        
        // First Entry Point
        // This function will always run first
        private static void UpdateOrCreateSchoolClassJson()
        {
            // Open Folder
            classDirectory = new DirectoryInfo(Application.StartupPath + "//db//" + schoolClassName);
            // Load JSON-File from Folder
            classJson = classDirectory.GetFiles("progress.json").FirstOrDefault();

            if (classJson != null)
            {
                UpdateJson();
            }
            else
            {
                CreateNewJson();
            }
        }

        private static void UpdateJson()
        {
            SchoolClass classFromFiles = CreateSchoolClassFromImgFiles();
            SchoolClass classFromJson  = CreateSchoolClassFromJson();

            foreach (Student studentFromFiles in classFromFiles.Students)
            {
                foreach (Student studentFromJson in classFromJson.Students)
                {
                    if (studentFromFiles.Name == studentFromJson.Name)
                    {
                        // Maybe make copy better
                        studentFromFiles.Name = studentFromJson.Name;
                        studentFromFiles.ImgPath = studentFromJson.ImgPath;
                        studentFromFiles.Appeared = studentFromJson.Appeared;
                        studentFromFiles.GotCorrect = studentFromJson.GotCorrect;
                        studentFromFiles.Score = studentFromJson.Score;
                    }
                }
            }
            CreateJsonFileFromSchoolClass(classFromFiles);
        }

        private static void CreateNewJson()
        {
            SchoolClass schoolClass = CreateSchoolClassFromImgFiles();
            CreateJsonFileFromSchoolClass(schoolClass);
        }

        // File Handling Functions
        private static SchoolClass CreateSchoolClassFromImgFiles()
        {
            SchoolClass schoolClass = new SchoolClass(schoolClassName);
            FileInfo[] allFilesInFolder = classDirectory.GetFiles();
            foreach (FileInfo file in allFilesInFolder)
            {
                // Split the Filename into Name and Extension
                string[] splitString = file.Name.Split('.');
                string fileName = splitString[0];
                string extension = splitString[1];

                // Validate Filetype
                if (supportedFileTypes.Contains(extension))
                {
                    // Replace underscores with whitespace for use in application
                    string studentName = fileName.Replace('_', ' ');

                    // Create student and add to class
                    Student student = new Student(studentName, file.FullName);
                    schoolClass.Students.Add(student);
                }
            }
            return schoolClass;
        }

        private static SchoolClass CreateSchoolClassFromJson()
        {
            string schoolClassData = File.ReadAllText(classJson.FullName);
            return System.Text.Json.JsonSerializer.Deserialize<SchoolClass>(schoolClassData);
        }

        private static void CreateJsonFileFromSchoolClass(SchoolClass schoolClass)
        {
            // Write/Replace Json File
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(schoolClass, options);
            File.WriteAllText(classDirectory.FullName + "//progress.json", jsonString);

            // Update classJson
            classJson = classDirectory.GetFiles("progress.json").FirstOrDefault();
        }
    }
}
