namespace KnowYourStudents
{
    partial class HomeWindow
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
            this.lbClasses = new System.Windows.Forms.ListBox();
            this.btnSelectClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClasses
            // 
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.ItemHeight = 16;
            this.lbClasses.Location = new System.Drawing.Point(94, 103);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.Size = new System.Drawing.Size(120, 84);
            this.lbClasses.TabIndex = 0;
            // 
            // btnSelectClass
            // 
            this.btnSelectClass.Location = new System.Drawing.Point(94, 204);
            this.btnSelectClass.Name = "btnSelectClass";
            this.btnSelectClass.Size = new System.Drawing.Size(163, 23);
            this.btnSelectClass.TabIndex = 1;
            this.btnSelectClass.Text = "Klassenübersicht öffnen";
            this.btnSelectClass.UseVisualStyleBackColor = true;
            this.btnSelectClass.Click += new System.EventHandler(this.btnSelectClass_Click);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.btnSelectClass);
            this.Controls.Add(this.lbClasses);
            this.Name = "HomeWindow";
            this.Text = "Know Your Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.Button btnSelectClass;
    }
}