using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UniversityFacultativesDAL.Entity;
using UniversityFacultativesDAL.Service;
using UniversityFacultativesSystem.Properties;

namespace UniversityFacultativesSystem
{
    internal partial class StudentForm : Form
    {
        DataService service;

        Student current;

        public StudentForm(string user, string password)
        {
            InitializeComponent();
            Icon = Resources.education_computer_school_graduate_cap_monitor_icon_149680;
            closeButton.Style(1.6f, Color.LightSkyBlue);
            minimizeButton.Style(1.6f, Color.LightSkyBlue);
            buttonQuit.Style(1.6f, Color.LightSkyBlue);


            DataService newService = new DataService("deanery", "deanery32188");
            var logins = newService.Logins.GetTeachersLogins();
            newService.Close();
            UserLogin login = logins.Find(t => t.Login == user && t.Password == password);

            service = new DataService(user, password);
            current = service.Teachers.Get(login.UserId);


            label1.Text += $"{current.LastName} {current.FirstName} {current.MiddleName}";
            label3.Text = current.Department;
            label4.Text = current.FirstName;
            label5.Text = current.LastName;
            label6.Text = current.MiddleName;
        }

        private void Close(object sender, EventArgs e) => this.Close();
        private void Minimize(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void ClosingForm(object sender, FormClosingEventArgs e) => service.Close();
        private void Quit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?", "Вихід з облікового запису", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
                Program.GoTo(new StartForm());
        }
        private Font GetFont(float size)
        {
            return new Font("Ink Free", size, FontStyle.Bold);
        }

        private void DeaneryForm_Load(object sender, EventArgs e)
        {
            teacherTable.Controls.Clear();
            teacherTable.ColumnStyles.Clear();
            teacherTable.RowStyles.Clear();
            teacherTable.ColumnCount = 0;
            teacherTable.RowCount = 0;

            teacherTable.AutoScroll = true;


            teacherTable.ColumnCount = 6;
            List<Teacher> teachers = service.Teachers.GetAll();
            int n = teachers.Count;
            teacherTable.RowCount = 1 + n;

            string[] titles = { "id", "Прізвище", "Ім'я", "По батькові", "Кафедра" };
            for (int i = 0; i < 5; i++)
            {
                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.Font = new Font(GetFont(13), FontStyle.Underline);
                label.Text = titles[i];
                teacherTable.Controls.Add(label, i, 0);
            }

            for (int row = 1; row < 1 + n; row++)
            {
                string[] fields = { teachers[row - 1].Id.ToString(), teachers[row - 1].LastName, teachers[row - 1].FirstName, teachers[row - 1].MiddleName, teachers[row - 1].Department };

                for (int col = 0; col < 5; col++)
                {
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.Font = GetFont(13);
                    label.Text = fields[col];

                    teacherTable.Controls.Add(label, col, row);
                    teacherTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
                    teacherTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                }
            }

            studentsTable.Controls.Clear();
            studentsTable.ColumnStyles.Clear();
            studentsTable.RowStyles.Clear();
            studentsTable.ColumnCount = 0;
            studentsTable.RowCount = 0;

            studentsTable.AutoScroll = true;

            studentsTable.ColumnCount = 8;
            List<Student> students = service.Students.GetAll();
            n = students.Count;
            studentsTable.RowCount = 1 + n;

            titles = new string[] { "id", "Прізвище", "Ім'я", "По батькові", "Група", "Адреса", "Номер", "Кількість вибраних курсів" };
            for (int i = 0; i < 8; i++)
            {
                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.Font = new Font(GetFont(13), FontStyle.Underline);
                label.Text = titles[i];
                studentsTable.Controls.Add(label, i, 0);
            }

            for (int row = 1; row < 1 + n; row++)
            {
                string[] fields = { students[row - 1].Id.ToString(), students[row - 1].LastName, students[row - 1].FirstName,
                        students[row - 1].MiddleName, students[row - 1].Group, students[row-1].Address, students[row-1].Phone,
                        students[row-1].CoursesTaken.ToString() };


                for (int col = 0; col < 8; col++)
                {
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.Font = GetFont(13);
                    label.Text = fields[col];

                    studentsTable.Controls.Add(label, col, row);
                    studentsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
                    studentsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                }
            }

            subjectsTable.Controls.Clear();
            subjectsTable.ColumnStyles.Clear();
            subjectsTable.RowStyles.Clear();
            subjectsTable.ColumnCount = 0;
            subjectsTable.RowCount = 0;

            subjectsTable.AutoScroll = true;

            subjectsTable.ColumnCount = 4;
            List<Subject> subjects = service.Subjects.GetAll();
            n = subjects.Count;
            subjectsTable.RowCount = 1 + n + 1;

            titles = new string[] { "id", "Назва", "Опис" };
            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.Font = new Font(GetFont(13), FontStyle.Underline);
                label.Text = titles[i];
                subjectsTable.Controls.Add(label, i, 0);
            }

            for (int row = 1; row < 1 + n; row++)
            {
                string[] fields = { subjects[row - 1].Id.ToString(), subjects[row - 1].Name, subjects[row - 1].Description };


                for (int col = 0; col < 3; col++)
                {
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.Font = GetFont(11);
                    label.Text = fields[col];

                    subjectsTable.Controls.Add(label, col, row);
                    subjectsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
                    subjectsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                }
            }


            semestersTable.Controls.Clear();
            semestersTable.ColumnStyles.Clear();
            semestersTable.RowStyles.Clear();
            semestersTable.ColumnCount = 0;
            semestersTable.RowCount = 0;

            semestersTable.AutoScroll = true;

            semestersTable.ColumnCount = 5;
            List<Semester> semesters = service.Semesters.GetAll();
            n = semesters.Count;
            semestersTable.RowCount = 1 + n + 1;

            titles = new string[] { "id", "Дата початку", "Дата кінця", "Мінімальне число курсів студентам" };
            for (int i = 0; i < 4; i++)
            {
                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.Font = new Font(GetFont(13), FontStyle.Underline);
                label.Text = titles[i];
                semestersTable.Controls.Add(label, i, 0);
            }

            for (int row = 1; row < 1 + n; row++)
            {
                string[] fields = { semesters[row - 1].Id.ToString(), semesters[row - 1].BeginningDate, semesters[row - 1].EndDate, semesters[row - 1].StudentsMinCoursesCount.ToString() };


                for (int col = 0; col < 4; col++)
                {
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.Font = GetFont(11);
                    label.Text = fields[col];

                    semestersTable.Controls.Add(label, col, row);
                    semestersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
                    semestersTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                }
            }


            {
                courseTable.Controls.Clear();
                courseTable.ColumnStyles.Clear();
                courseTable.RowStyles.Clear();
                courseTable.ColumnCount = 0;
                courseTable.RowCount = 0;

                courseTable.AutoScroll = true;

                courseTable.ColumnCount = 6;
                List<Course> courses = service.Courses.GetAll();
                n = courses.Count;
                courseTable.RowCount = 1 + n + 1;

                titles = new string[] { "id", "id предмета", "id викладача", "Кількість годин", "Тип" };
                for (int i = 0; i < 5; i++)
                {
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.Font = new Font(GetFont(13), FontStyle.Underline);
                    label.Text = titles[i];
                    courseTable.Controls.Add(label, i, 0);
                }

                for (int row = 1; row < 1 + n; row++)
                {
                    string[] fields = { courses[row - 1].Id.ToString(), courses[row - 1].SubjectId.ToString(), courses[row - 1].TeacherId.ToString(), courses[row - 1].Hours.ToString(), courses[row - 1].Type };

                    for (int col = 0; col < 5; col++)
                    {
                        Label label = new Label();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.AutoSize = false;
                        label.Dock = DockStyle.Fill;
                        label.Font = GetFont(13);
                        label.Text = fields[col];

                        courseTable.Controls.Add(label, col, row);
                        courseTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
                        courseTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    }
                }
            }

            {
                enrollmentsTable.Controls.Clear();
                enrollmentsTable.ColumnStyles.Clear();
                enrollmentsTable.RowStyles.Clear();
                enrollmentsTable.ColumnCount = 0;
                enrollmentsTable.RowCount = 0;

                enrollmentsTable.AutoScroll = true;

                enrollmentsTable.ColumnCount = 4;
                List<Enrollment> enrollments = service.Enrollments.GetAll();
                n = enrollments.Count;
                enrollmentsTable.RowCount = 1 + n + 1;

                titles = new string[] { "id", "id студента", "id курса" };
                for (int i = 0; i < 3; i++)
                {
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.Font = new Font(GetFont(13), FontStyle.Underline);
                    label.Text = titles[i];
                    enrollmentsTable.Controls.Add(label, i, 0);
                }

                for (int row = 1; row < 1 + n; row++)
                {
                    string[] fields = { enrollments[row - 1].Id.ToString(), enrollments[row - 1].StudentId.ToString(), enrollments[row - 1].CourseId.ToString() };

                    for (int col = 0; col < 3; col++)
                    {
                        Label label = new Label();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.AutoSize = false;
                        label.Dock = DockStyle.Fill;
                        label.Font = GetFont(13);
                        label.Text = fields[col];

                        enrollmentsTable.Controls.Add(label, col, row);
                        enrollmentsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
                        enrollmentsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    }
                }
            }

            {
                gradesTable.Controls.Clear();
                gradesTable.ColumnStyles.Clear();
                gradesTable.RowStyles.Clear();
                gradesTable.ColumnCount = 0;
                gradesTable.RowCount = 0;

                gradesTable.AutoScroll = true;

                gradesTable.ColumnCount = 5;
                List<Grade> grades = service.Grades.GetAll();
                n = grades.Count;
                gradesTable.RowCount = 1 + n + 1;

                titles = new string[] { "id", "id семестру", "id запису", "оцінка" };
                for (int i = 0; i < 4; i++)
                {
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.AutoSize = false;
                    label.Dock = DockStyle.Fill;
                    label.Font = new Font(GetFont(13), FontStyle.Underline);
                    label.Text = titles[i];
                    gradesTable.Controls.Add(label, i, 0);
                }

                for (int row = 1; row < 1 + n; row++)
                {
                    string[] fields = { grades[row - 1].Id.ToString(), grades[row - 1].SemesterId.ToString(), grades[row - 1].SemesterId.ToString(), grades[row - 1].Value.ToString() };

                    for (int col = 0; col < 4; col++)
                    {
                        Label label = new Label();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.AutoSize = false;
                        label.Dock = DockStyle.Fill;
                        label.Font = GetFont(13);
                        label.Text = fields[col];

                        gradesTable.Controls.Add(label, col, row);
                        gradesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
                        gradesTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    }
                }
            }
        }

    }
}
