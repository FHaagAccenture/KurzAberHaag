﻿namespace KnowYourStudents
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
            this.btnStartGame1 = new System.Windows.Forms.Button();
            this.btnStartGame2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSchoolClass
            // 
            this.lvSchoolClass.HideSelection = false;
            this.lvSchoolClass.Location = new System.Drawing.Point(12, 59);
            this.lvSchoolClass.Name = "lvSchoolClass";
            this.lvSchoolClass.Size = new System.Drawing.Size(852, 331);
            this.lvSchoolClass.TabIndex = 0;
            this.lvSchoolClass.UseCompatibleStateImageBehavior = false;
            this.lvSchoolClass.Click += new System.EventHandler(this.lvSchoolClass_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStartGame1
            // 
            this.btnStartGame1.Location = new System.Drawing.Point(653, 12);
            this.btnStartGame1.Name = "btnStartGame1";
            this.btnStartGame1.Size = new System.Drawing.Size(102, 23);
            this.btnStartGame1.TabIndex = 2;
            this.btnStartGame1.Text = "Spiel 1 starten";
            this.btnStartGame1.UseVisualStyleBackColor = true;
            // 
            // btnStartGame2
            // 
            this.btnStartGame2.Location = new System.Drawing.Point(761, 12);
            this.btnStartGame2.Name = "btnStartGame2";
            this.btnStartGame2.Size = new System.Drawing.Size(102, 23);
            this.btnStartGame2.TabIndex = 3;
            this.btnStartGame2.Text = "Spiel 2 starten";
            this.btnStartGame2.UseVisualStyleBackColor = true;
            // 
            // ClassOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 402);
            this.Controls.Add(this.btnStartGame2);
            this.Controls.Add(this.btnStartGame1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvSchoolClass);
            this.Name = "ClassOverview";
            this.Text = "ClassOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSchoolClass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStartGame1;
        private System.Windows.Forms.Button btnStartGame2;
    }
}