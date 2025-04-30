namespace UniversityFacultativesSystem
{
    partial class TeacherForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.newCourse = new System.Windows.Forms.Button();
            this.typeTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hoursTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.subjectidTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.enrollmentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.gradesPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.modify = new System.Windows.Forms.Button();
            this.modifygrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modifysemester = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.putGrade = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enrollmentid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.semesterid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gradesTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.coursePage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.semestersPage.SuspendLayout();
            this.subjectsPage.SuspendLayout();
            this.studentsPage.SuspendLayout();
            this.teachersPage.SuspendLayout();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gradesPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityFacultativesSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.closeButton.Location = new System.Drawing.Point(1864, 12);
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
            this.minimizeButton.Location = new System.Drawing.Point(1814, 12);
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
            this.label1.Location = new System.Drawing.Point(247, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1427, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcomе, dear teacher,";
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
            this.buttonQuit.Location = new System.Drawing.Point(1727, 12);
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
            this.coursePage.Controls.Add(this.panel2);
            this.coursePage.Controls.Add(this.courseTable);
            this.coursePage.Location = new System.Drawing.Point(4, 31);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(3);
            this.coursePage.Size = new System.Drawing.Size(1912, 822);
            this.coursePage.TabIndex = 4;
            this.coursePage.Text = "Courses";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.newCourse);
            this.panel2.Controls.Add(this.typeTextbox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.hoursTextbox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.subjectidTextbox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(3, 749);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1912, 73);
            this.panel2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(72, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "Form and conduct a course ->";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newCourse
            // 
            this.newCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newCourse.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.newCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCourse.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCourse.ForeColor = System.Drawing.Color.AliceBlue;
            this.newCourse.Location = new System.Drawing.Point(1807, 13);
            this.newCourse.Name = "newCourse";
            this.newCourse.Size = new System.Drawing.Size(78, 43);
            this.newCourse.TabIndex = 13;
            this.newCourse.Text = "✔";
            this.newCourse.UseVisualStyleBackColor = true;
            this.newCourse.Click += new System.EventHandler(this.newCourse_Click);
            // 
            // typeTextbox
            // 
            this.typeTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.typeTextbox.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextbox.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.typeTextbox.Location = new System.Drawing.Point(1439, 25);
            this.typeTextbox.Name = "typeTextbox";
            this.typeTextbox.Size = new System.Drawing.Size(340, 25);
            this.typeTextbox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(1334, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Lesson type:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hoursTextbox
            // 
            this.hoursTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hoursTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.hoursTextbox.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextbox.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.hoursTextbox.Location = new System.Drawing.Point(1049, 23);
            this.hoursTextbox.Name = "hoursTextbox";
            this.hoursTextbox.Size = new System.Drawing.Size(235, 25);
            this.hoursTextbox.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(914, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hours amount:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subjectidTextbox
            // 
            this.subjectidTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.subjectidTextbox.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectidTextbox.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.subjectidTextbox.Location = new System.Drawing.Point(649, 23);
            this.subjectidTextbox.Name = "subjectidTextbox";
            this.subjectidTextbox.Size = new System.Drawing.Size(207, 25);
            this.subjectidTextbox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(541, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "subject id:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseTable
            // 
            this.courseTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.courseTable.ColumnCount = 2;
            this.courseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.Location = new System.Drawing.Point(3, 3);
            this.courseTable.Name = "courseTable";
            this.courseTable.RowCount = 2;
            this.courseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.Size = new System.Drawing.Size(1909, 747);
            this.courseTable.TabIndex = 2;
            // 
            // semestersPage
            // 
            this.semestersPage.AutoScroll = true;
            this.semestersPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.semestersPage.Controls.Add(this.semestersTable);
            this.semestersPage.Location = new System.Drawing.Point(4, 31);
            this.semestersPage.Name = "semestersPage";
            this.semestersPage.Padding = new System.Windows.Forms.Padding(3);
            this.semestersPage.Size = new System.Drawing.Size(1912, 822);
            this.semestersPage.TabIndex = 3;
            this.semestersPage.Text = "Semesters";
            // 
            // semestersTable
            // 
            this.semestersTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.semestersTable.ColumnCount = 2;
            this.semestersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semestersTable.Location = new System.Drawing.Point(3, 3);
            this.semestersTable.Name = "semestersTable";
            this.semestersTable.RowCount = 2;
            this.semestersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.semestersTable.Size = new System.Drawing.Size(1906, 816);
            this.semestersTable.TabIndex = 6;
            // 
            // subjectsPage
            // 
            this.subjectsPage.AutoScroll = true;
            this.subjectsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subjectsPage.Controls.Add(this.subjectsTable);
            this.subjectsPage.Location = new System.Drawing.Point(4, 31);
            this.subjectsPage.Name = "subjectsPage";
            this.subjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsPage.Size = new System.Drawing.Size(1912, 822);
            this.subjectsPage.TabIndex = 2;
            this.subjectsPage.Text = "Subjects";
            // 
            // subjectsTable
            // 
            this.subjectsTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subjectsTable.ColumnCount = 2;
            this.subjectsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectsTable.Location = new System.Drawing.Point(3, 3);
            this.subjectsTable.Name = "subjectsTable";
            this.subjectsTable.RowCount = 2;
            this.subjectsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.subjectsTable.Size = new System.Drawing.Size(1906, 816);
            this.subjectsTable.TabIndex = 4;
            // 
            // studentsPage
            // 
            this.studentsPage.AutoScroll = true;
            this.studentsPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.studentsPage.Controls.Add(this.studentsTable);
            this.studentsPage.Location = new System.Drawing.Point(4, 31);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsPage.Size = new System.Drawing.Size(1912, 822);
            this.studentsPage.TabIndex = 1;
            this.studentsPage.Text = "Students";
            // 
            // studentsTable
            // 
            this.studentsTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.studentsTable.ColumnCount = 2;
            this.studentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsTable.Location = new System.Drawing.Point(3, 3);
            this.studentsTable.Name = "studentsTable";
            this.studentsTable.RowCount = 2;
            this.studentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsTable.Size = new System.Drawing.Size(1906, 816);
            this.studentsTable.TabIndex = 2;
            // 
            // teachersPage
            // 
            this.teachersPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.teachersPage.Controls.Add(this.teacherTable);
            this.teachersPage.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersPage.Location = new System.Drawing.Point(4, 31);
            this.teachersPage.Name = "teachersPage";
            this.teachersPage.Padding = new System.Windows.Forms.Padding(3);
            this.teachersPage.Size = new System.Drawing.Size(1912, 822);
            this.teachersPage.TabIndex = 0;
            this.teachersPage.Text = "Teachers";
            // 
            // teacherTable
            // 
            this.teacherTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.teacherTable.ColumnCount = 2;
            this.teacherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherTable.Location = new System.Drawing.Point(3, 3);
            this.teacherTable.Name = "teacherTable";
            this.teacherTable.RowCount = 2;
            this.teacherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.teacherTable.Size = new System.Drawing.Size(1906, 816);
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
            this.Tab.Controls.Add(this.gradesPage);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tab.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab.Location = new System.Drawing.Point(0, 204);
            this.Tab.Multiline = true;
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1920, 857);
            this.Tab.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.enrollmentsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1912, 822);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Enrollments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // enrollmentsTable
            // 
            this.enrollmentsTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.enrollmentsTable.ColumnCount = 2;
            this.enrollmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enrollmentsTable.Location = new System.Drawing.Point(3, 3);
            this.enrollmentsTable.Name = "enrollmentsTable";
            this.enrollmentsTable.RowCount = 2;
            this.enrollmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.Size = new System.Drawing.Size(1906, 816);
            this.enrollmentsTable.TabIndex = 3;
            // 
            // gradesPage
            // 
            this.gradesPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gradesPage.Controls.Add(this.panel1);
            this.gradesPage.Controls.Add(this.gradesTable);
            this.gradesPage.Location = new System.Drawing.Point(4, 31);
            this.gradesPage.Name = "gradesPage";
            this.gradesPage.Padding = new System.Windows.Forms.Padding(3);
            this.gradesPage.Size = new System.Drawing.Size(1912, 822);
            this.gradesPage.TabIndex = 6;
            this.gradesPage.Text = "Grades";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.modify);
            this.panel1.Controls.Add(this.modifygrade);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.modifysemester);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.putGrade);
            this.panel1.Controls.Add(this.grade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.enrollmentid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.semesterid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 749);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1912, 73);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(921, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 52);
            this.label5.TabIndex = 23;
            this.label5.Text = "Change all students\' grades \r\non your facultatives";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modify
            // 
            this.modify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modify.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.ForeColor = System.Drawing.Color.AliceBlue;
            this.modify.Location = new System.Drawing.Point(1810, 14);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(65, 45);
            this.modify.TabIndex = 22;
            this.modify.Text = "✔";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // modifygrade
            // 
            this.modifygrade.BackColor = System.Drawing.Color.AliceBlue;
            this.modifygrade.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifygrade.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.modifygrade.Location = new System.Drawing.Point(1723, 24);
            this.modifygrade.Name = "modifygrade";
            this.modifygrade.Size = new System.Drawing.Size(67, 25);
            this.modifygrade.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(1469, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 40);
            this.label6.TabIndex = 20;
            this.label6.Text = "What value (>0 or <0)\r\nwill alter grades:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifysemester
            // 
            this.modifysemester.BackColor = System.Drawing.Color.AliceBlue;
            this.modifysemester.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifysemester.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.modifysemester.Location = new System.Drawing.Point(1366, 24);
            this.modifysemester.Name = "modifysemester";
            this.modifysemester.Size = new System.Drawing.Size(50, 25);
            this.modifysemester.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.AliceBlue;
            this.label15.Location = new System.Drawing.Point(1261, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "semster id:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(61, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Give a grade ->";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // putGrade
            // 
            this.putGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.putGrade.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.putGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.putGrade.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putGrade.ForeColor = System.Drawing.Color.AliceBlue;
            this.putGrade.Location = new System.Drawing.Point(779, 14);
            this.putGrade.Name = "putGrade";
            this.putGrade.Size = new System.Drawing.Size(65, 45);
            this.putGrade.TabIndex = 13;
            this.putGrade.Text = "✔";
            this.putGrade.UseVisualStyleBackColor = true;
            this.putGrade.Click += new System.EventHandler(this.putGrade_Click);
            // 
            // grade
            // 
            this.grade.BackColor = System.Drawing.Color.AliceBlue;
            this.grade.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.grade.Location = new System.Drawing.Point(706, 25);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(67, 25);
            this.grade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(634, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grade:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enrollmentid
            // 
            this.enrollmentid.BackColor = System.Drawing.Color.AliceBlue;
            this.enrollmentid.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentid.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.enrollmentid.Location = new System.Drawing.Point(559, 22);
            this.enrollmentid.Name = "enrollmentid";
            this.enrollmentid.Size = new System.Drawing.Size(58, 25);
            this.enrollmentid.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(455, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Enrollment id:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // semesterid
            // 
            this.semesterid.BackColor = System.Drawing.Color.AliceBlue;
            this.semesterid.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterid.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.semesterid.Location = new System.Drawing.Point(408, 24);
            this.semesterid.Name = "semesterid";
            this.semesterid.Size = new System.Drawing.Size(50, 25);
            this.semesterid.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(298, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Semester id:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradesTable
            // 
            this.gradesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradesTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gradesTable.ColumnCount = 2;
            this.gradesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.Location = new System.Drawing.Point(3, 3);
            this.gradesTable.Name = "gradesTable";
            this.gradesTable.RowCount = 2;
            this.gradesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.Size = new System.Drawing.Size(1909, 744);
            this.gradesTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(898, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 30;
            this.label2.Text = "Department:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(520, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(880, 62);
            this.label3.TabIndex = 31;
            this.label3.Text = "department";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.coursePage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.semestersPage.ResumeLayout(false);
            this.subjectsPage.ResumeLayout(false);
            this.studentsPage.ResumeLayout(false);
            this.teachersPage.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gradesPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage gradesPage;
        private System.Windows.Forms.TableLayoutPanel enrollmentsTable;
        private System.Windows.Forms.TableLayoutPanel gradesTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button putGrade;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enrollmentid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox semesterid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.TextBox modifygrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modifysemester;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button newCourse;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hoursTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox subjectidTextbox;
        private System.Windows.Forms.Label label12;
    }
}