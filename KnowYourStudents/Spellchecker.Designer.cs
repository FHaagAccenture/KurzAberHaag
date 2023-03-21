namespace KnowYourStudents
{
    partial class Spellchecker
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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitStudentName = new System.Windows.Forms.Button();
            this.lbWinLooseInfo = new System.Windows.Forms.Label();
            this.timeDelayBetweenStudents = new System.Windows.Forms.Timer(this.components);
            this.pnlControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(24, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(267, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Fortschritt Speichern und Zurück";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbStudent
            // 
            this.pbStudent.Location = new System.Drawing.Point(24, 54);
            this.pbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(400, 10);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 5;
            this.pbStudent.TabStop = false;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(17, 62);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(287, 22);
            this.tbStudentName.TabIndex = 6;
            this.tbStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbStudentName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name des Schülers eingeben:";
            // 
            // btnSubmitStudentName
            // 
            this.btnSubmitStudentName.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSubmitStudentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitStudentName.Location = new System.Drawing.Point(325, 58);
            this.btnSubmitStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitStudentName.Name = "btnSubmitStudentName";
            this.btnSubmitStudentName.Size = new System.Drawing.Size(75, 31);
            this.btnSubmitStudentName.TabIndex = 8;
            this.btnSubmitStudentName.Text = "Fertig!";
            this.btnSubmitStudentName.UseVisualStyleBackColor = false;
            this.btnSubmitStudentName.Click += new System.EventHandler(this.btnSubmitStudentName_Click);
            // 
            // lbWinLooseInfo
            // 
            this.lbWinLooseInfo.AutoSize = true;
            this.lbWinLooseInfo.Location = new System.Drawing.Point(13, 14);
            this.lbWinLooseInfo.Name = "lbWinLooseInfo";
            this.lbWinLooseInfo.Size = new System.Drawing.Size(10, 16);
            this.lbWinLooseInfo.TabIndex = 9;
            this.lbWinLooseInfo.Text = " ";
            // 
            // timeDelayBetweenStudents
            // 
            this.timeDelayBetweenStudents.Tick += new System.EventHandler(this.timeDelayBetweenStudents_Tick);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tbStudentName);
            this.pnlControls.Controls.Add(this.lbWinLooseInfo);
            this.pnlControls.Controls.Add(this.btnSubmitStudentName);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Location = new System.Drawing.Point(24, 553);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(400, 96);
            this.pnlControls.TabIndex = 10;
            // 
            // Spellchecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(447, 657);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Spellchecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spellchecker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Spellchecker_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitStudentName;
        private System.Windows.Forms.Label lbWinLooseInfo;
        private System.Windows.Forms.Timer timeDelayBetweenStudents;
        private System.Windows.Forms.Panel pnlControls;
    }
}