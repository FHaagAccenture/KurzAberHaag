using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowYourStudents
{
    public partial class ClassOverview : Form
    {
        private SchoolClass schoolClass;
        private HomeWindow homeWindow;
        public ClassOverview(string selectedClass, HomeWindow homeWindow)
        {
            InitializeComponent();

            this.Text = selectedClass; // Set window title dynamically
            this.homeWindow = homeWindow;

            // Load school class from name
            schoolClass = JsonHandler.LoadSchoolClass(selectedClass);
            if (schoolClass != null)
            {
                loadStudentImages();
            }
            else
            {
                MessageBox.Show("Klasse konnte nicht geladen werden, prüfen sie den Ornder und Dateiformate!", "Warnung",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadStudentImages()
        {

            // Populate ImageList
            ImageList studentImages = new ImageList();
            studentImages.ImageSize = new Size(80, 100); // Make sizing dynamic?
            foreach (Student student in schoolClass.Students)
            {
                studentImages.Images.Add(student.Name, Image.FromFile(student.ImgPath));
            }

            // Add ImageList to Listview
            lvSchoolClass.LargeImageList = studentImages;

            // Create and Display ListViewItems
            foreach (Student student in schoolClass.Students)
            {
                ListViewItem studentItem = new ListViewItem();
                studentItem.Text = student.Name;
                studentItem.ImageKey = student.Name;
                lvSchoolClass.Items.Add(studentItem);
            }
        }

        // Handle Zoom
        private void lvSchoolClass_Click(object sender, EventArgs e)
        {
            ListViewItem selectedStudent = lvSchoolClass.SelectedItems[0];

            foreach(Student student in schoolClass.Students)
            {
                if (student.Name == selectedStudent.Text)
                {
                    
                    StudentImageZoom studentImageZoom = new StudentImageZoom(student);
                    studentImageZoom.Show();
                    break;
                }
                                
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homeWindow.Show();
        }
    }
}
