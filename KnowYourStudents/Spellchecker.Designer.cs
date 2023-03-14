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
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Speichern und Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbStudent
            // 
            this.pbStudent.Location = new System.Drawing.Point(24, 54);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(400, 10);
            this.pbStudent.TabIndex = 5;
            this.pbStudent.TabStop = false;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(15, 643);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(303, 22);
            this.tbStudentName.TabIndex = 6;
            this.tbStudentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbStudentName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name des Schülers eingeben:";
            // 
            // btnSubmitStudentName
            // 
            this.btnSubmitStudentName.Location = new System.Drawing.Point(349, 638);
            this.btnSubmitStudentName.Name = "btnSubmitStudentName";
            this.btnSubmitStudentName.Size = new System.Drawing.Size(75, 32);
            this.btnSubmitStudentName.TabIndex = 8;
            this.btnSubmitStudentName.Text = "Fertig!";
            this.btnSubmitStudentName.UseVisualStyleBackColor = true;
            this.btnSubmitStudentName.Click += new System.EventHandler(this.btnSubmitStudentName_Click);
            // 
            // lbWinLooseInfo
            // 
            this.lbWinLooseInfo.AutoSize = true;
            this.lbWinLooseInfo.Location = new System.Drawing.Point(12, 608);
            this.lbWinLooseInfo.Name = "lbWinLooseInfo";
            this.lbWinLooseInfo.Size = new System.Drawing.Size(10, 16);
            this.lbWinLooseInfo.TabIndex = 9;
            this.lbWinLooseInfo.Text = " ";
            // 
            // timeDelayBetweenStudents
            // 
            this.timeDelayBetweenStudents.Tick += new System.EventHandler(this.timeDelayBetweenStudents_Tick);
            // 
            // Spellchecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 687);
            this.Controls.Add(this.lbWinLooseInfo);
            this.Controls.Add(this.btnSubmitStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.btnBack);
            this.Name = "Spellchecker";
            this.Text = "Spellchecker";
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitStudentName;
        private System.Windows.Forms.Label lbWinLooseInfo;
        private System.Windows.Forms.Timer timeDelayBetweenStudents;
    }
}