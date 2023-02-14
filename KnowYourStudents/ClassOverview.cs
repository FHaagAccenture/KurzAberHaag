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
        public ClassOverview()
        {
            InitializeComponent();

            // Load selected item from HomeWindow to determine current class
            this.Text = HomeWindow.selectedComponent;

            // Create or update the JSON for this class
            jsonHandler.UpdateOrCreateClassJson(HomeWindow.selectedComponent);

            // Load the Class Object from the JSON
            // SomeType myClass = jsonHandler.LoadClassFromClassJson()


            // Display Students from Class
            // Load shit from myClass into some Forms Element

            // Select Game Mode
        }

        // TODO:
        // - Handle going back to HomeWindow
        // - Add Zoom to Students
    }
}
