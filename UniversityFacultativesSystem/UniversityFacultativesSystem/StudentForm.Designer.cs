namespace UniversityFacultativesSystem
{
    partial class StudentForm
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
            this.coursePage = new System.Windows.Forms.TabPage();
            this.courseTable = new System.Windows.Forms.TableLayoutPanel();
            this.semestersPage = new System.Windows.Forms.TabPage();
            this.semestersTable = new System.Windows.Forms.TableLayoutPanel();
            this.subjectsPage = new System.Windows.Forms.TabPage();
            this.subjectsTable = new System.Windows.Forms.TableLayoutPanel();
            this.studentsPage = new System.Windows.Forms.TabPage();
            this.studentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.teachersPage = new System.Windows.Forms.TabPage();
            this.teacherTable = new System.Windows.Forms.TableLayoutPanel();
            this.Tab = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.enrollmentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.gradesTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.coursePage.SuspendLayout();
            this.semestersPage.SuspendLayout();
            this.subjectsPage.SuspendLayout();
            this.studentsPage.SuspendLayout();
            this.teachersPage.SuspendLayout();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.closeButton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.minimizeButton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(390, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вітаємо, викладаче, ";
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
            this.buttonQuit.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonQuit.Location = new System.Drawing.Point(1299, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(81, 40);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "(<-)";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.Quit);
            // 
            // coursePage
            // 
            this.coursePage.AutoScroll = true;
            this.coursePage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.coursePage.Controls.Add(this.courseTable);
            this.coursePage.Location = new System.Drawing.Point(4, 38);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(3);
            this.coursePage.Size = new System.Drawing.Size(1018, 522);
            this.coursePage.TabIndex = 4;
            this.coursePage.Text = "Курси";
            // 
            // courseTable
            // 
            this.courseTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.courseTable.ColumnCount = 2;
            this.courseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseTable.Location = new System.Drawing.Point(3, 3);
            this.courseTable.Name = "courseTable";
            this.courseTable.RowCount = 2;
            this.courseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.Size = new System.Drawing.Size(1012, 516);
            this.courseTable.TabIndex = 2;
            // 
            // semestersPage
            // 
            this.semestersPage.AutoScroll = true;
            this.semestersPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.semestersPage.Controls.Add(this.semestersTable);
            this.semestersPage.Location = new System.Drawing.Point(4, 38);
            this.semestersPage.Name = "semestersPage";
            this.semestersPage.Padding = new System.Windows.Forms.Padding(3);
            this.semestersPage.Size = new System.Drawing.Size(1018, 522);
            this.semestersPage.TabIndex = 3;
            this.semestersPage.Text = "Семестри";
            // 
            // semestersTable
            // 
            this.semestersTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.semestersTable.ColumnCount = 2;
            this.semestersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.semestersTable.Location = new System.Drawing.Point(3, 3);
            this.semestersTable.Name = "semestersTable";
            this.semestersTable.RowCount = 2;
            this.semestersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.Size = new System.Drawing.Size(1012, 516);
            this.semestersTable.TabIndex = 6;
            // 
            // subjectsPage
            // 
            this.subjectsPage.AutoScroll = true;
            this.subjectsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subjectsPage.Controls.Add(this.subjectsTable);
            this.subjectsPage.Location = new System.Drawing.Point(4, 38);
            this.subjectsPage.Name = "subjectsPage";
            this.subjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsPage.Size = new System.Drawing.Size(1018, 522);
            this.subjectsPage.TabIndex = 2;
            this.subjectsPage.Text = "Предмети";
            // 
            // subjectsTable
            // 
            this.subjectsTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subjectsTable.ColumnCount = 2;
            this.subjectsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectsTable.Location = new System.Drawing.Point(3, 3);
            this.subjectsTable.Name = "subjectsTable";
            this.subjectsTable.RowCount = 2;
            this.subjectsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.Size = new System.Drawing.Size(1012, 519);
            this.subjectsTable.TabIndex = 4;
            // 
            // studentsPage
            // 
            this.studentsPage.AutoScroll = true;
            this.studentsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.studentsPage.Controls.Add(this.studentsTable);
            this.studentsPage.Location = new System.Drawing.Point(4, 38);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsPage.Size = new System.Drawing.Size(1018, 522);
            this.studentsPage.TabIndex = 1;
            this.studentsPage.Text = "Студенти";
            // 
            // studentsTable
            // 
            this.studentsTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.studentsTable.ColumnCount = 2;
            this.studentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentsTable.Location = new System.Drawing.Point(3, 3);
            this.studentsTable.Name = "studentsTable";
            this.studentsTable.RowCount = 2;
            this.studentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.Size = new System.Drawing.Size(1012, 516);
            this.studentsTable.TabIndex = 2;
            // 
            // teachersPage
            // 
            this.teachersPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.teachersPage.Controls.Add(this.teacherTable);
            this.teachersPage.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersPage.Location = new System.Drawing.Point(4, 38);
            this.teachersPage.Name = "teachersPage";
            this.teachersPage.Padding = new System.Windows.Forms.Padding(3);
            this.teachersPage.Size = new System.Drawing.Size(1018, 522);
            this.teachersPage.TabIndex = 0;
            this.teachersPage.Text = "Викладачі";
            // 
            // teacherTable
            // 
            this.teacherTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.teacherTable.ColumnCount = 2;
            this.teacherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherTable.Location = new System.Drawing.Point(3, 3);
            this.teacherTable.Name = "teacherTable";
            this.teacherTable.RowCount = 2;
            this.teacherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.Size = new System.Drawing.Size(1012, 516);
            this.teacherTable.TabIndex = 0;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.teachersPage);
            this.Tab.Controls.Add(this.studentsPage);
            this.Tab.Controls.Add(this.subjectsPage);
            this.Tab.Controls.Add(this.semestersPage);
            this.Tab.Controls.Add(this.coursePage);
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab.Location = new System.Drawing.Point(260, 89);
            this.Tab.Multiline = true;
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1026, 564);
            this.Tab.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 62);
            this.label2.TabIndex = 30;
            this.label2.Text = "Кафедра:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(36, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 62);
            this.label3.TabIndex = 31;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(36, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 42);
            this.label4.TabIndex = 32;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(36, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 39);
            this.label5.TabIndex = 33;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(36, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 41);
            this.label6.TabIndex = 34;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.enrollmentsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 522);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Записи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gradesTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 522);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Оцінки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // enrollmentsTable
            // 
            this.enrollmentsTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.enrollmentsTable.ColumnCount = 2;
            this.enrollmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.enrollmentsTable.Location = new System.Drawing.Point(3, 3);
            this.enrollmentsTable.Name = "enrollmentsTable";
            this.enrollmentsTable.RowCount = 2;
            this.enrollmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.Size = new System.Drawing.Size(1012, 516);
            this.enrollmentsTable.TabIndex = 3;
            // 
            // gradesTable
            // 
            this.gradesTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gradesTable.ColumnCount = 2;
            this.gradesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradesTable.Location = new System.Drawing.Point(3, 3);
            this.gradesTable.Name = "gradesTable";
            this.gradesTable.RowCount = 2;
            this.gradesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.Size = new System.Drawing.Size(1012, 516);
            this.gradesTable.TabIndex = 3;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1492, 845);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.DeaneryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.coursePage.ResumeLayout(false);
            this.semestersPage.ResumeLayout(false);
            this.subjectsPage.ResumeLayout(false);
            this.studentsPage.ResumeLayout(false);
            this.teachersPage.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TabPage coursePage;
        private System.Windows.Forms.TableLayoutPanel courseTable;
        private System.Windows.Forms.TabPage semestersPage;
        private System.Windows.Forms.TableLayoutPanel semestersTable;
        private System.Windows.Forms.TabPage subjectsPage;
        private System.Windows.Forms.TableLayoutPanel subjectsTable;
        private System.Windows.Forms.TabPage studentsPage;
        private System.Windows.Forms.TableLayoutPanel studentsTable;
        private System.Windows.Forms.TabPage teachersPage;
        private System.Windows.Forms.TableLayoutPanel teacherTable;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel enrollmentsTable;
        private System.Windows.Forms.TableLayoutPanel gradesTable;
    }
}