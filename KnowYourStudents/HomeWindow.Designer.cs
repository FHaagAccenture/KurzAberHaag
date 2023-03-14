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
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClasses
            // 
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.ItemHeight = 16;
            this.lbClasses.Location = new System.Drawing.Point(12, 12);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.Size = new System.Drawing.Size(188, 212);
            this.lbClasses.TabIndex = 0;
            // 
            // btnSelectClass
            // 
            this.btnSelectClass.Location = new System.Drawing.Point(22, 230);
            this.btnSelectClass.Name = "btnSelectClass";
            this.btnSelectClass.Size = new System.Drawing.Size(163, 23);
            this.btnSelectClass.TabIndex = 1;
            this.btnSelectClass.Text = "Klassenübersicht öffnen";
            this.btnSelectClass.UseVisualStyleBackColor = true;
            this.btnSelectClass.Click += new System.EventHandler(this.btnSelectClass_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(62, 259);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Hilfe";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 289);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSelectClass);
            this.Controls.Add(this.lbClasses);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Know Your Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.Button btnSelectClass;
        private System.Windows.Forms.Button btnHelp;
    }
}