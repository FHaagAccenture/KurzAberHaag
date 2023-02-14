namespace KnowYourStudents
{
    partial class ClassOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.ItemHeight = 16;
            this.lbTest.Location = new System.Drawing.Point(68, 56);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(127, 228);
            this.lbTest.TabIndex = 0;
            this.lbTest.SelectedIndexChanged += new System.EventHandler(this.lbTest_SelectedIndexChanged);
            // 
            // ClassOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.lbTest);
            this.Name = "ClassOverview";
            this.Text = "ClassOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTest;
    }
}