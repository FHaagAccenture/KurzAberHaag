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
            this.lvSchoolClass = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStartSpellchecker = new System.Windows.Forms.Button();
            this.btnStartGame2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSchoolClass
            // 
            this.lvSchoolClass.HideSelection = false;
            this.lvSchoolClass.Location = new System.Drawing.Point(12, 59);
            this.lvSchoolClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvSchoolClass.Name = "lvSchoolClass";
            this.lvSchoolClass.Size = new System.Drawing.Size(850, 292);
            this.lvSchoolClass.TabIndex = 0;
            this.lvSchoolClass.UseCompatibleStateImageBehavior = false;
            this.lvSchoolClass.Click += new System.EventHandler(this.lvSchoolClass_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 31);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStartSpellchecker
            // 
            this.btnStartSpellchecker.BackColor = System.Drawing.Color.LightSalmon;
            this.btnStartSpellchecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSpellchecker.Location = new System.Drawing.Point(504, 11);
            this.btnStartSpellchecker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartSpellchecker.Name = "btnStartSpellchecker";
            this.btnStartSpellchecker.Size = new System.Drawing.Size(155, 31);
            this.btnStartSpellchecker.TabIndex = 2;
            this.btnStartSpellchecker.Text = "Spellchecker starten";
            this.btnStartSpellchecker.UseVisualStyleBackColor = false;
            this.btnStartSpellchecker.Click += new System.EventHandler(this.btnStartGame1_Click);
            // 
            // btnStartGame2
            // 
            this.btnStartGame2.BackColor = System.Drawing.Color.LightSalmon;
            this.btnStartGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame2.Location = new System.Drawing.Point(665, 11);
            this.btnStartGame2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame2.Name = "btnStartGame2";
            this.btnStartGame2.Size = new System.Drawing.Size(197, 31);
            this.btnStartGame2.TabIndex = 3;
            this.btnStartGame2.Text = "Gesichtserkennung starten";
            this.btnStartGame2.UseVisualStyleBackColor = false;
            this.btnStartGame2.Click += new System.EventHandler(this.btnStartGame2_Click);
            // 
            // ClassOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(875, 364);
            this.Controls.Add(this.btnStartGame2);
            this.Controls.Add(this.btnStartSpellchecker);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvSchoolClass);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClassOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassOverview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassOverview_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSchoolClass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStartSpellchecker;
        private System.Windows.Forms.Button btnStartGame2;
    }
}