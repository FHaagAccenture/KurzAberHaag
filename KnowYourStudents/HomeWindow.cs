using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KnowYourStudents
{
    public partial class HomeWindow : Form
    {
        public static string selectedComponent = null;

        public HomeWindow()
        {
            InitializeComponent();

            // On Start of Application load list of classes in db
            string currentDirectory = Application.StartupPath;
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + "//db");
            DirectoryInfo[] classesFolders = directoryInfo.GetDirectories();

            foreach (DirectoryInfo classFolder in classesFolders)
            {
                this.lbClasses.Items.Add(classFolder.Name);
            }
        }

        private void btnSelectClass_Click(object sender, EventArgs e)
        {
            // Check that a class is selected
            if (lbClasses.SelectedItems.Count == 1)
            {
                // Make the selected class accessible for other forms
                selectedComponent = lbClasses.SelectedItems[0].ToString();

                // Open Class Overview and close this window
                ClassOverview ow = new ClassOverview();
                this.Hide();
                ow.ShowDialog();
                this.Close();
            }
            else
            {
                // TODO
                // Display a warning like "Select a class!"
            }
        }
    }
}
