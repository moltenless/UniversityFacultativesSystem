namespace UniversityFacultativesSystem
{
    partial class DeaneryForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.teachersPage = new System.Windows.Forms.TabPage();
            this.studentsPage = new System.Windows.Forms.TabPage();
            this.subjectsPage = new System.Windows.Forms.TabPage();
            this.semestersPage = new System.Windows.Forms.TabPage();
            this.coursePage = new System.Windows.Forms.TabPage();
            this.enrollmentsPage = new System.Windows.Forms.TabPage();
            this.gradesPage = new System.Windows.Forms.TabPage();
            this.tLoginsPage = new System.Windows.Forms.TabPage();
            this.sLoginsPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::UniversityFacultativesSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1460, 981);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.closeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.Location = new System.Drawing.Point(1436, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 40);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Close);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.minimizeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.Location = new System.Drawing.Point(1386, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(44, 40);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.Minimize);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(398, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вітаємо, робітнику деканату!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonQuit.Location = new System.Drawing.Point(1299, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(81, 40);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "(<-)";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.Quit);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.teachersPage);
            this.Tab.Controls.Add(this.studentsPage);
            this.Tab.Controls.Add(this.subjectsPage);
            this.Tab.Controls.Add(this.semestersPage);
            this.Tab.Controls.Add(this.coursePage);
            this.Tab.Controls.Add(this.enrollmentsPage);
            this.Tab.Controls.Add(this.gradesPage);
            this.Tab.Controls.Add(this.tLoginsPage);
            this.Tab.Controls.Add(this.sLoginsPage);
            this.Tab.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab.Location = new System.Drawing.Point(260, 89);
            this.Tab.Multiline = true;
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1026, 473);
            this.Tab.TabIndex = 29;
            this.Tab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Tab_Selecting);
            // 
            // teachersPage
            // 
            this.teachersPage.AutoScroll = true;
            this.teachersPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.teachersPage.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersPage.Location = new System.Drawing.Point(4, 72);
            this.teachersPage.Name = "teachersPage";
            this.teachersPage.Padding = new System.Windows.Forms.Padding(3);
            this.teachersPage.Size = new System.Drawing.Size(1018, 397);
            this.teachersPage.TabIndex = 0;
            this.teachersPage.Text = "Викладачі";
            // 
            // studentsPage
            // 
            this.studentsPage.AutoScroll = true;
            this.studentsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.studentsPage.Location = new System.Drawing.Point(4, 72);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsPage.Size = new System.Drawing.Size(1018, 397);
            this.studentsPage.TabIndex = 1;
            this.studentsPage.Text = "Студенти";
            // 
            // subjectsPage
            // 
            this.subjectsPage.AutoScroll = true;
            this.subjectsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subjectsPage.Location = new System.Drawing.Point(4, 72);
            this.subjectsPage.Name = "subjectsPage";
            this.subjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsPage.Size = new System.Drawing.Size(1018, 397);
            this.subjectsPage.TabIndex = 2;
            this.subjectsPage.Text = "Предмети";
            // 
            // semestersPage
            // 
            this.semestersPage.AutoScroll = true;
            this.semestersPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.semestersPage.Location = new System.Drawing.Point(4, 72);
            this.semestersPage.Name = "semestersPage";
            this.semestersPage.Padding = new System.Windows.Forms.Padding(3);
            this.semestersPage.Size = new System.Drawing.Size(1018, 397);
            this.semestersPage.TabIndex = 3;
            this.semestersPage.Text = "Семестри";
            // 
            // coursePage
            // 
            this.coursePage.AutoScroll = true;
            this.coursePage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.coursePage.Location = new System.Drawing.Point(4, 72);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(3);
            this.coursePage.Size = new System.Drawing.Size(1018, 397);
            this.coursePage.TabIndex = 4;
            this.coursePage.Text = "Курси факультативів";
            // 
            // enrollmentsPage
            // 
            this.enrollmentsPage.AutoScroll = true;
            this.enrollmentsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.enrollmentsPage.Location = new System.Drawing.Point(4, 72);
            this.enrollmentsPage.Name = "enrollmentsPage";
            this.enrollmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.enrollmentsPage.Size = new System.Drawing.Size(1018, 397);
            this.enrollmentsPage.TabIndex = 5;
            this.enrollmentsPage.Text = "Записи на курси";
            // 
            // gradesPage
            // 
            this.gradesPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gradesPage.Location = new System.Drawing.Point(4, 72);
            this.gradesPage.Name = "gradesPage";
            this.gradesPage.Padding = new System.Windows.Forms.Padding(3);
            this.gradesPage.Size = new System.Drawing.Size(1018, 397);
            this.gradesPage.TabIndex = 6;
            this.gradesPage.Text = "Оцінки";
            // 
            // tLoginsPage
            // 
            this.tLoginsPage.AutoScroll = true;
            this.tLoginsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tLoginsPage.Location = new System.Drawing.Point(4, 72);
            this.tLoginsPage.Name = "tLoginsPage";
            this.tLoginsPage.Padding = new System.Windows.Forms.Padding(3);
            this.tLoginsPage.Size = new System.Drawing.Size(1018, 397);
            this.tLoginsPage.TabIndex = 7;
            this.tLoginsPage.Text = "Логіни викладачів";
            // 
            // sLoginsPage
            // 
            this.sLoginsPage.AutoScroll = true;
            this.sLoginsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sLoginsPage.Location = new System.Drawing.Point(4, 72);
            this.sLoginsPage.Name = "sLoginsPage";
            this.sLoginsPage.Padding = new System.Windows.Forms.Padding(3);
            this.sLoginsPage.Size = new System.Drawing.Size(1018, 397);
            this.sLoginsPage.TabIndex = 8;
            this.sLoginsPage.Text = "Логіни студентів";
            // 
            // DeaneryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1492, 845);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeaneryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage teachersPage;
        private System.Windows.Forms.TabPage studentsPage;
        private System.Windows.Forms.TabPage subjectsPage;
        private System.Windows.Forms.TabPage semestersPage;
        private System.Windows.Forms.TabPage coursePage;
        private System.Windows.Forms.TabPage enrollmentsPage;
        private System.Windows.Forms.TabPage gradesPage;
        private System.Windows.Forms.TabPage tLoginsPage;
        private System.Windows.Forms.TabPage sLoginsPage;
    }
}