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
                MessageBox.Show("Wählen Sie eine Klasse aus. Werden keine Klassen angezeigt überprüfen Sie, dass die Klassen im korrekten Verzeichnis liegen!", "Warnung",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hilfe: \n" +
                "Legen sie ihre Schulklassen in einem Verzeichnis \"db\" (= datenbank) ab, dieses muss im selben Verzeichnis wie die ausführbare Anwendung liegen, damit ihre Klassen gefunden werden können. Verschachtelungen innerhalb von \"db\" sind nicht zulässig, jede Klasse ist ein eigenes Verzeichnis. \n\n" +
                "Benennung der Klassenverzeichnisse folgt Windows Regeln, für Schülernamen können \" \" oder \"_\" für Leerzeichen verwendet werden, beides wird zur Laufzeit als Leerzeichen angezeigt.\n\n" +
                "Das Programm speichert ihren Lernfortschritt über mehrere Sitzungen, dieser Fortschritt wird in einem JSON-Dokument namens \"progress\" im Verzeichnis der entsprechenden Klasse abgelegt. Wünschen Sie ihrern Fortschritt zurück zu setzten genügt es das JSON-Dokument in der entsprechenden Klasse zu löschen, ein neues wird automatisch generiert.",
                "Hilfe",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
