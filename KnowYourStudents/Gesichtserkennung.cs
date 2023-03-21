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
    public partial class Gesichtserkennung : Form
    {
        private int progressPerWin = 3;
        private double fixedImageWidth = 150;
        private int timeBetweenStudents = 3000;

        private SchoolClass schoolClass;
        private Student activeStudent;
        private List<Student> selectedStudents;

        private Random random;
        private ClassOverview parentWindow;
        private bool backButtonUsed = false;

        public Gesichtserkennung(SchoolClass schoolClass, ClassOverview parentWindow)
        {
            InitializeComponent();
            this.parentWindow = parentWindow;
            this.schoolClass = schoolClass;
            selectedStudents = new List<Student>();
            random = new Random();
            timeDelayBetweenStudents.Interval = timeBetweenStudents;
            loadNewStudent();
        }

        private void loadNewStudent()
        {
            // Get next active Student
            activeStudent = GameHandler.determineNextStudent(schoolClass);

            // Clear Data
            lblInfo.Text = "Klicke auf " + activeStudent.Name;
            lbWinLooseInfo.Text = "";
            BackColor = Color.MistyRose;
            selectedStudents = new List<Student>();

            // Populate List
            selectedStudents.Add(activeStudent);

            // Determine first random student
            Student randomStudent_1 = null;
            while (randomStudent_1 == null)
            {
                int pick = random.Next(schoolClass.Students.Count);
                if (schoolClass.Students[pick].Name != activeStudent.Name)
                {
                    randomStudent_1 = schoolClass.Students[pick];
                    selectedStudents.Add(randomStudent_1);
                }
            }

            // Determine second random stundent
            Student randomStudent_2 = null;
            while (randomStudent_2 == null)
            {
                int pick = random.Next(schoolClass.Students.Count);
                if (schoolClass.Students[pick].Name != activeStudent.Name && schoolClass.Students[pick].Name != randomStudent_1.Name)
                {
                    randomStudent_2 = schoolClass.Students[pick];
                    selectedStudents.Add(randomStudent_2);
                }
            }

            // Shuffle selected Students in place
            // Fisher-Yates Shuffle
            for (int i = selectedStudents.Count - 1; i > 0; i--)
            {
                int rand = random.Next(i + 1);
                Student temp = selectedStudents[rand];
                selectedStudents[rand] = selectedStudents[i];
                selectedStudents[i] = temp;
            }

            // Load Students into picture boxes
            LoadStudentIntoPictureBox(pbStudent_1, selectedStudents[0]);
            LoadStudentIntoPictureBox(pbStudent_2, selectedStudents[1]);
            LoadStudentIntoPictureBox(pbStudent_3, selectedStudents[2]);
        }

        private void LoadStudentIntoPictureBox(PictureBox pb, Student student)
        {
            // Load and scale new Image
            Image studentImage = Image.FromFile(student.ImgPath);

            double scalingFactor = studentImage.Width / fixedImageWidth;
            double imageHeight = studentImage.Height / scalingFactor;

            pb.Width = (int)fixedImageWidth;
            pb.Height = (int)imageHeight;
            pb.Image = studentImage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            JsonHandler.SaveSchoolClass(schoolClass);
            backButtonUsed = true;
            this.Close();

            parentWindow.Show();
        }

        private void Gesichtserkennung_FormClosing(object sender, FormClosingEventArgs e)
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
        private void timeDelayBetweenStudents_Tick(object sender, EventArgs e)
        {
            loadNewStudent();
            timeDelayBetweenStudents.Dispose();
        }

        private void pbStudent_1_Click(object sender, EventArgs e)
        {
            evaluatePick(0);
        }


        private void pbStudent_2_Click(object sender, EventArgs e)
        {
            evaluatePick(1);
        }

        private void pbStudent_3_Click(object sender, EventArgs e)
        {
            evaluatePick(2);
        }

        private void evaluatePick(int selection)
        {
            // Check if timer is currently running
            if (timeDelayBetweenStudents.Enabled == false)
            {
                if (selectedStudents[selection] == activeStudent)
                {
                    LearnProgressHandler.IncreaseStudentProgress(activeStudent, progressPerWin);
                    lbWinLooseInfo.Text = "Richtig! Weiter so!";
                    BackColor = Color.Green;
                    timeDelayBetweenStudents.Enabled = true;
                }
                else
                {
                    lbWinLooseInfo.Text = "Leider falsch! Du hast auf " + selectedStudents[selection].Name + " geklickt.";
                    BackColor = Color.Red;
                    timeDelayBetweenStudents.Enabled = true;
                }
            }
        }
    }
}

