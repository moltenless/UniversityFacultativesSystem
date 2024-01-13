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
            this.teacherExecute = new System.Windows.Forms.Button();
            this.teacherdepartament = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teachermiddle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherfirst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teachersecond = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.teacherid = new System.Windows.Forms.TextBox();
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
            this.coursePage.Text = "Курси";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Тип занять:";
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
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Кількість годин:";
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
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "id предмета:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseTable
            // 
            this.courseTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.semestersPage.Text = "Семестри";
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
            this.subjectsPage.Text = "Предмети";
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
            this.studentsPage.Text = "Студенти";
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
            this.teachersPage.Text = "Викладачі";
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
            this.Tab.Location = new System.Drawing.Point(0, 223);
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
            this.tabPage1.Text = "Записи";
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
            this.gradesPage.Text = "Оцінки";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.teacherExecute);
            this.panel1.Controls.Add(this.teacherdepartament);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.teachermiddle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.teacherfirst);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.teachersecond);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.teacherid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 749);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1912, 73);
            this.panel1.TabIndex = 4;
            // 
            // teacherExecute
            // 
            this.teacherExecute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teacherExecute.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.teacherExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherExecute.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherExecute.ForeColor = System.Drawing.Color.AliceBlue;
            this.teacherExecute.Location = new System.Drawing.Point(1800, 1);
            this.teacherExecute.Name = "teacherExecute";
            this.teacherExecute.Size = new System.Drawing.Size(96, 66);
            this.teacherExecute.TabIndex = 13;
            this.teacherExecute.Text = "✔";
            this.teacherExecute.UseVisualStyleBackColor = true;
            // 
            // teacherdepartament
            // 
            this.teacherdepartament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teacherdepartament.BackColor = System.Drawing.Color.AliceBlue;
            this.teacherdepartament.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherdepartament.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.teacherdepartament.Location = new System.Drawing.Point(1477, 24);
            this.teacherdepartament.Name = "teacherdepartament";
            this.teacherdepartament.Size = new System.Drawing.Size(302, 25);
            this.teacherdepartament.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(1392, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Кафедра:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teachermiddle
            // 
            this.teachermiddle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teachermiddle.BackColor = System.Drawing.Color.AliceBlue;
            this.teachermiddle.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachermiddle.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.teachermiddle.Location = new System.Drawing.Point(1120, 23);
            this.teachermiddle.Name = "teachermiddle";
            this.teachermiddle.Size = new System.Drawing.Size(235, 25);
            this.teachermiddle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(1011, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "По батькові:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teacherfirst
            // 
            this.teacherfirst.BackColor = System.Drawing.Color.AliceBlue;
            this.teacherfirst.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherfirst.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.teacherfirst.Location = new System.Drawing.Point(760, 26);
            this.teacherfirst.Name = "teacherfirst";
            this.teacherfirst.Size = new System.Drawing.Size(193, 25);
            this.teacherfirst.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(705, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ім\'я:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teachersecond
            // 
            this.teachersecond.BackColor = System.Drawing.Color.AliceBlue;
            this.teachersecond.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersecond.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.teachersecond.Location = new System.Drawing.Point(434, 25);
            this.teachersecond.Name = "teachersecond";
            this.teachersecond.Size = new System.Drawing.Size(207, 25);
            this.teachersecond.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(343, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Прізвище:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teacherid
            // 
            this.teacherid.BackColor = System.Drawing.Color.AliceBlue;
            this.teacherid.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherid.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.teacherid.Location = new System.Drawing.Point(240, 26);
            this.teacherid.Name = "teacherid";
            this.teacherid.Size = new System.Drawing.Size(50, 25);
            this.teacherid.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(208, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "id:";
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
            this.label2.Text = "Кафедра:";
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
            this.label3.Text = "кафедра";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
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
        private System.Windows.Forms.Button teacherExecute;
        private System.Windows.Forms.TextBox teacherdepartament;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teachermiddle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teacherfirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teachersecond;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teacherid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newCourse;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hoursTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox subjectidTextbox;
        private System.Windows.Forms.Label label12;
    }
}