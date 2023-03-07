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
    public partial class StudentImageZoom : Form
    {
        public StudentImageZoom(Student student)
        {
            InitializeComponent();

            Image studentImage = Image.FromFile(student.ImgPath);
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


            double fixedImageWidth = 300;
            double scalingFactor = studentImage.Width / fixedImageWidth;
            double imageHeight = studentImage.Height / scalingFactor;


            pictureBox.Width = (int)fixedImageWidth;
            pictureBox.Height = (int)imageHeight;
            pictureBox.ImageLocation = student.ImgPath;


            this.Controls.Add(pictureBox);

            //Offset the size of the form, maybe find a better way?
            this.Width = pictureBox.Width + 15;
            this.Height = pictureBox.Height + 37;
            this.Text = student.Name;

        }
    }
}
