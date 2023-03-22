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
        private bool backButtonUsed = false;

        public ClassOverview(string selectedClass, HomeWindow homeWindow)
        {
            InitializeComponent();

            this.homeWindow = homeWindow;
            this.Text = selectedClass; // Set window title

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
            studentImages.ImageSize = new Size(80, 80);
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

        private void btnStartGame1_Click(object sender, EventArgs e)
        {
            Spellchecker spellchecker = new Spellchecker(schoolClass, this);
            spellchecker.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backButtonUsed = true;
            this.Close();
        }

        private void btnStartGame2_Click(object sender, EventArgs e)
        {
            // Check that at least three students are in class, otherwise game would not run
            if (schoolClass.Students.Count < 3)
            {
                MessageBox.Show("Damit sie dieses Spiel spielen könenn müssen mindestens drei Schüler in ihrer Klasse sein!", "Warnung",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Gesichtserkennung gesichtserkennung = new Gesichtserkennung(schoolClass, this);
                gesichtserkennung.Show();
                this.Hide();
            }
        }

        // Determine if back button or X was used to close form
        private void ClassOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backButtonUsed)
            {
                homeWindow.Show();
            }
            else
            {
                homeWindow.Close();
            }
        }
    }
}

