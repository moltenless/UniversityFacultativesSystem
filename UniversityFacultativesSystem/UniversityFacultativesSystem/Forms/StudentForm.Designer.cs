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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.enroll = new System.Windows.Forms.Button();
            this.courseid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.enrollmentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.gradesPage = new System.Windows.Forms.TabPage();
            this.gradesTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.coursePage.SuspendLayout();
            this.semestersPage.SuspendLayout();
            this.subjectsPage.SuspendLayout();
            this.studentsPage.SuspendLayout();
            this.teachersPage.SuspendLayout();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gradesPage.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(246, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1427, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome, dear student,  ";
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
            this.coursePage.Controls.Add(this.courseTable);
            this.coursePage.Location = new System.Drawing.Point(4, 31);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(3);
            this.coursePage.Size = new System.Drawing.Size(1912, 822);
            this.coursePage.TabIndex = 4;
            this.coursePage.Text = "Courses";
            // 
            // courseTable
            // 
            this.courseTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.courseTable.ColumnCount = 2;
            this.courseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseTable.Location = new System.Drawing.Point(3, 3);
            this.courseTable.Name = "courseTable";
            this.courseTable.RowCount = 2;
            this.courseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.courseTable.Size = new System.Drawing.Size(1906, 816);
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
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.enrollmentsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1912, 822);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Enrollments";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.enroll);
            this.panel2.Controls.Add(this.courseid);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(3, 746);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1906, 73);
            this.panel2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(823, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "Enroll a course ->";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enroll
            // 
            this.enroll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enroll.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enroll.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enroll.ForeColor = System.Drawing.Color.AliceBlue;
            this.enroll.Location = new System.Drawing.Point(1801, 13);
            this.enroll.Name = "enroll";
            this.enroll.Size = new System.Drawing.Size(78, 43);
            this.enroll.TabIndex = 13;
            this.enroll.Text = "✔";
            this.enroll.UseVisualStyleBackColor = true;
            this.enroll.Click += new System.EventHandler(this.enroll_Click);
            // 
            // courseid
            // 
            this.courseid.BackColor = System.Drawing.Color.AliceBlue;
            this.courseid.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseid.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.courseid.Location = new System.Drawing.Point(1514, 24);
            this.courseid.Name = "courseid";
            this.courseid.Size = new System.Drawing.Size(207, 25);
            this.courseid.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(1319, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Facultative course id:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enrollmentsTable
            // 
            this.enrollmentsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enrollmentsTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.enrollmentsTable.ColumnCount = 2;
            this.enrollmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.Location = new System.Drawing.Point(3, 3);
            this.enrollmentsTable.Name = "enrollmentsTable";
            this.enrollmentsTable.RowCount = 2;
            this.enrollmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enrollmentsTable.Size = new System.Drawing.Size(1906, 750);
            this.enrollmentsTable.TabIndex = 3;
            // 
            // gradesPage
            // 
            this.gradesPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gradesPage.Controls.Add(this.gradesTable);
            this.gradesPage.Location = new System.Drawing.Point(4, 31);
            this.gradesPage.Name = "gradesPage";
            this.gradesPage.Padding = new System.Windows.Forms.Padding(3);
            this.gradesPage.Size = new System.Drawing.Size(1912, 822);
            this.gradesPage.TabIndex = 6;
            this.gradesPage.Text = "Grades";
            // 
            // gradesTable
            // 
            this.gradesTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gradesTable.ColumnCount = 2;
            this.gradesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradesTable.Location = new System.Drawing.Point(3, 3);
            this.gradesTable.Name = "gradesTable";
            this.gradesTable.RowCount = 2;
            this.gradesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gradesTable.Size = new System.Drawing.Size(1906, 816);
            this.gradesTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(603, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 30;
            this.label2.Text = "Group:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(603, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 62);
            this.label3.TabIndex = 31;
            this.label3.Text = "group";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label14.Location = new System.Drawing.Point(794, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 46);
            this.label14.TabIndex = 32;
            this.label14.Text = "Address:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label16.Location = new System.Drawing.Point(735, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 62);
            this.label16.TabIndex = 33;
            this.label16.Text = "address";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label17.Location = new System.Drawing.Point(1017, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 46);
            this.label17.TabIndex = 34;
            this.label17.Text = "Phone:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label18.Location = new System.Drawing.Point(988, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 62);
            this.label18.TabIndex = 35;
            this.label18.Text = "phone";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label19.Location = new System.Drawing.Point(1198, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 46);
            this.label19.TabIndex = 36;
            this.label19.Text = "Enrollment count:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label20.Location = new System.Drawing.Point(1231, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 62);
            this.label20.TabIndex = 37;
            this.label20.Text = "enrollments";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
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
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.coursePage.ResumeLayout(false);
            this.semestersPage.ResumeLayout(false);
            this.subjectsPage.ResumeLayout(false);
            this.studentsPage.ResumeLayout(false);
            this.teachersPage.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gradesPage.ResumeLayout(false);
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button enroll;
        private System.Windows.Forms.TextBox courseid;
        private System.Windows.Forms.Label label12;
    }
}