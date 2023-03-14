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
    internal static class JsonHandler
    {
        // Change to allow different file extension for images
        // Careful: They need to be compatible with Windows Forms
        private static List<string> supportedFileTypes = new List<string> { "jpg", "jpeg", "png", "bmp" };


        private static DirectoryInfo classDirectory;
        private static FileInfo classJson;
        private static string schoolClassName;
        
        // Exposed function to load school class by name as well as generate/update the JSON for it
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

        // Exposed function to save generic school class
        public static void SaveSchoolClass(SchoolClass schoolClass)
        {
            try
            {
                // Open Folder
                classDirectory = new DirectoryInfo(Application.StartupPath + "//db//" + schoolClass.SchoolClassName);

                // Save to file in opened folder
                CreateJsonFileFromSchoolClass(schoolClass);
            }
            catch(Exception ex)
            {
               // Console.WriteLine(ex);
               // Add more sophisticated Error Handling
               // For now just making sure application doesn't crash
            }

        }
        
        // Main Entry Point for loading and updating JSON
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
                        studentFromFiles.LearningProgress = studentFromJson.LearningProgress;
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
