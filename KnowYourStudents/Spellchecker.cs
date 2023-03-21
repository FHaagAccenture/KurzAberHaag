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
        private bool backButtonUsed = false;

        public Spellchecker(SchoolClass schoolClass, ClassOverview parentWindow)
        {
            InitializeComponent();

            this.parentWindow = parentWindow;
            this.schoolClass = schoolClass;
            random = new Random();
            timeDelayBetweenStudents.Interval = timeBetweenStudents;
            loadNewStudent();
        }

        // Do not touch
        // Cumulative weighted randomizer algorithm
        private void determineNextStudent()
        {
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
            activeStudent = schoolClass.Students[index];
        }

        private void loadNewStudent()
        {
            // Get next active Student
            determineNextStudent();

            // Clear Form, Info & Backcolor
            tbStudentName.Text = "";
            lbWinLooseInfo.Text = "";
            pnlControls.BackColor = Color.MistyRose;   

            // Load and scale new Image
            Image studentImage = Image.FromFile(activeStudent.ImgPath);

            double scalingFactor = studentImage.Width / fixedImageWidth;
            double imageHeight = studentImage.Height / scalingFactor;

            pbStudent.Width = (int)fixedImageWidth;
            pbStudent.Height = (int)imageHeight;
            pbStudent.Image = studentImage;

            // Scale window to image lenght & move panel
            pnlControls.Location = new Point(18, pbStudent.Height + 50);
            this.Height = pbStudent.Height + 175;
        }

        private void btnSubmitStudentName_Click(object sender, EventArgs e)
        {
            if (tbStudentName.Text == activeStudent.Name)
            {
                // Got Name correct
                lbWinLooseInfo.Text = "Richtig! Weiter so!";
                LearnProgressHandler.IncreaseStudentProgress(activeStudent, progressPerWin);
                pnlControls.BackColor = Color.Green;
                timeDelayBetweenStudents.Enabled = true;
            } 
            else
            {
                // Got Name wrong
                lbWinLooseInfo.Text = "Leider falsch! Richtig wäre: " + activeStudent.Name;
                pnlControls.BackColor = Color.Red;
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
            backButtonUsed = true;
            this.Close();

            parentWindow.Show();
        }

        private void Spellchecker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backButtonUsed)
            {
                parentWindow.Show();
            }
            else
            {
                parentWindow.Close();
            }
        }
    }
}
