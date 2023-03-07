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
                string selectedClass = lbClasses.SelectedItems[0].ToString();

                // Open Class Overview and hide this form
                ClassOverview classOverview = new ClassOverview(selectedClass, this);
                classOverview.Show();   
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wählen sie eine Klasse aus. Werden keine Klassen angezeigt überprüfen Sie, dass die Klassen im korrekten Ornder liegen!", "Warnung",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
