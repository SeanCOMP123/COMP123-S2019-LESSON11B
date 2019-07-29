namespace COMP123_S2019_LESSON11B
{
    partial class StudentInfoForm
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDDataLabel = new System.Windows.Forms.Label();
            this.StudnetIDLabel = new System.Windows.Forms.Label();
            this.StudentIDDataLabel = new System.Windows.Forms.Label();
            this.FirtNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.Location = new System.Drawing.Point(18, 104);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(150, 38);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDDataLabel
            // 
            this.IDDataLabel.BackColor = System.Drawing.Color.White;
            this.IDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDDataLabel.Location = new System.Drawing.Point(192, 104);
            this.IDDataLabel.Name = "IDDataLabel";
            this.IDDataLabel.Size = new System.Drawing.Size(254, 38);
            this.IDDataLabel.TabIndex = 0;
            this.IDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudnetIDLabel
            // 
            this.StudnetIDLabel.Location = new System.Drawing.Point(18, 158);
            this.StudnetIDLabel.Name = "StudnetIDLabel";
            this.StudnetIDLabel.Size = new System.Drawing.Size(150, 38);
            this.StudnetIDLabel.TabIndex = 0;
            this.StudnetIDLabel.Text = "Student ID";
            this.StudnetIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentIDDataLabel
            // 
            this.StudentIDDataLabel.BackColor = System.Drawing.Color.White;
            this.StudentIDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentIDDataLabel.Location = new System.Drawing.Point(192, 158);
            this.StudentIDDataLabel.Name = "StudentIDDataLabel";
            this.StudentIDDataLabel.Size = new System.Drawing.Size(254, 38);
            this.StudentIDDataLabel.TabIndex = 0;
            this.StudentIDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirtNameLabel
            // 
            this.FirtNameLabel.Location = new System.Drawing.Point(18, 212);
            this.FirtNameLabel.Name = "FirtNameLabel";
            this.FirtNameLabel.Size = new System.Drawing.Size(150, 38);
            this.FirtNameLabel.TabIndex = 0;
            this.FirtNameLabel.Text = "First Name";
            this.FirtNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.White;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(192, 212);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(578, 38);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(18, 266);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(150, 38);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.White;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(192, 266);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(578, 38);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 490);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 59);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LastNameDataLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.StudentIDDataLabel);
            this.Controls.Add(this.FirstNameDataLabel);
            this.Controls.Add(this.StudnetIDLabel);
            this.Controls.Add(this.FirtNameLabel);
            this.Controls.Add(this.IDDataLabel);
            this.Controls.Add(this.IDLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info Form";
            this.Activated += new System.EventHandler(this.StudentInfoForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label IDDataLabel;
        private System.Windows.Forms.Label StudnetIDLabel;
        private System.Windows.Forms.Label StudentIDDataLabel;
        private System.Windows.Forms.Label FirtNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button BackButton;
    }
}