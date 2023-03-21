namespace KnowYourStudents
{
    partial class Gesichtserkennung
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
            this.pbStudent_1 = new System.Windows.Forms.PictureBox();
            this.pbStudent_2 = new System.Windows.Forms.PictureBox();
            this.pbStudent_3 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lbWinLooseInfo = new System.Windows.Forms.Label();
            this.timeDelayBetweenStudents = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent_3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(17, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(257, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Fortschritt Speichern und Zurück";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbStudent_1
            // 
            this.pbStudent_1.Location = new System.Drawing.Point(16, 86);
            this.pbStudent_1.Margin = new System.Windows.Forms.Padding(4);
            this.pbStudent_1.Name = "pbStudent_1";
            this.pbStudent_1.Size = new System.Drawing.Size(133, 62);
            this.pbStudent_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent_1.TabIndex = 1;
            this.pbStudent_1.TabStop = false;
            this.pbStudent_1.Click += new System.EventHandler(this.pbStudent_1_Click);
            // 
            // pbStudent_2
            // 
            this.pbStudent_2.Location = new System.Drawing.Point(249, 86);
            this.pbStudent_2.Margin = new System.Windows.Forms.Padding(4);
            this.pbStudent_2.Name = "pbStudent_2";
            this.pbStudent_2.Size = new System.Drawing.Size(133, 62);
            this.pbStudent_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent_2.TabIndex = 2;
            this.pbStudent_2.TabStop = false;
            this.pbStudent_2.Click += new System.EventHandler(this.pbStudent_2_Click);
            // 
            // pbStudent_3
            // 
            this.pbStudent_3.Location = new System.Drawing.Point(487, 86);
            this.pbStudent_3.Margin = new System.Windows.Forms.Padding(4);
            this.pbStudent_3.Name = "pbStudent_3";
            this.pbStudent_3.Size = new System.Drawing.Size(133, 62);
            this.pbStudent_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent_3.TabIndex = 3;
            this.pbStudent_3.TabStop = false;
            this.pbStudent_3.Click += new System.EventHandler(this.pbStudent_3_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(373, 23);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 4;
            // 
            // lbWinLooseInfo
            // 
            this.lbWinLooseInfo.AutoSize = true;
            this.lbWinLooseInfo.Location = new System.Drawing.Point(373, 39);
            this.lbWinLooseInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWinLooseInfo.Name = "lbWinLooseInfo";
            this.lbWinLooseInfo.Size = new System.Drawing.Size(0, 16);
            this.lbWinLooseInfo.TabIndex = 5;
            // 
            // timeDelayBetweenStudents
            // 
            this.timeDelayBetweenStudents.Tick += new System.EventHandler(this.timeDelayBetweenStudents_Tick);
            // 
            // Gesichtserkennung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(709, 357);
            this.Controls.Add(this.lbWinLooseInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbStudent_3);
            this.Controls.Add(this.pbStudent_2);
            this.Controls.Add(this.pbStudent_1);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gesichtserkennung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gesichtserkennung";
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbStudent_1;
        private System.Windows.Forms.PictureBox pbStudent_2;
        private System.Windows.Forms.PictureBox pbStudent_3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lbWinLooseInfo;
        private System.Windows.Forms.Timer timeDelayBetweenStudents;
    }
}