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
    public partial class Spellchecker : Form
    {
        private int progressPerWin = 5;
        private double fixedImageWidth = 300;
        private int timeBetweenStudents = 3000;

        private SchoolClass schoolClass;
        private Student activeStudent;

        private Random random;
        private ClassOverview parentWindow;

        public Spellchecker(SchoolClass schoolClass, ClassOverview parentWindow)
        {
            InitializeComponent();

            this.parentWindow = parentWindow;
            this.schoolClass = schoolClass;
            random = new Random();
            pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            timeDelayBetweenStudents.Interval = timeBetweenStudents;
            loadNewStudent();
        }

        private void determineNextStudent()
        {
            int weightSum = 0;
            List<int> weights = new List<int>();
            foreach(Student student in schoolClass.Students)
            {
                weightSum = weightSum + (100 - student.LearningProgress);
                weights.Add(100 - student.LearningProgress);
            }
            int randomNummer = random.Next(weightSum);
            int index = 0;
            int tempSum = 0;
            while (tempSum < randomNummer)
            {
                tempSum = tempSum + weights[index];
                index++;
            }
            activeStudent = schoolClass.Students[index];
        }

        private void loadNewStudent()
        {
            // Get next active Student
            determineNextStudent();

            // Clear Form and Info 
            tbStudentName.Text = "";
            lbWinLooseInfo.Text = "";

            // Load and scale new Image
            Image studentImage = Image.FromFile(activeStudent.ImgPath);

            double scalingFactor = studentImage.Width / fixedImageWidth;
            double imageHeight = studentImage.Height / scalingFactor;

            pbStudent.Width = (int)fixedImageWidth;
            pbStudent.Height = (int)imageHeight;
            pbStudent.Image = studentImage;
        }

        private void btnSubmitStudentName_Click(object sender, EventArgs e)
        {
            if (tbStudentName.Text == activeStudent.Name)
            {
                // Got Name correct
                lbWinLooseInfo.Text = "Richtig! Weiter so!";
                LearnProgressHandler.IncreaseStudentProgress(activeStudent, progressPerWin);
                timeDelayBetweenStudents.Enabled = true;
            } 
            else
            {
                // Got Name wrong
                lbWinLooseInfo.Text = "Leider falsch! Richtig wäre: " + activeStudent.Name;
                timeDelayBetweenStudents.Enabled = true;
            }
        }

        private void timeDelayBetweenStudents_Tick(object sender, EventArgs e)
        {
            loadNewStudent();
            timeDelayBetweenStudents.Dispose();
        }

        private void tbStudentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmitStudentName_Click(sender, e);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            JsonHandler.SaveSchoolClass(schoolClass);

            this.Close();
            parentWindow.Show();
        }
    }
}
