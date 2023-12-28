using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UniversityFacultativesDAL.Entity;
using UniversityFacultativesDAL.Service;
using UniversityFacultativesSystem.Properties;

namespace UniversityFacultativesSystem
{
    internal partial class DeaneryForm : Form
    {
        DataService service;

        public DeaneryForm(string user, string password)
        {
            InitializeComponent();
            Icon = Resources.education_computer_school_graduate_cap_monitor_icon_149680;
            closeButton.Style(1.6f, Color.LightSkyBlue);
            minimizeButton.Style(1.6f, Color.LightSkyBlue);
            buttonQuit.Style(1.6f, Color.LightSkyBlue);
            teacherExecute.Style(3.6f, Color.LightSkyBlue);

            service = new DataService(user, password);



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
            }

            {
                studentsTable.Controls.Clear();
                studentsTable.ColumnStyles.Clear();
                studentsTable.RowStyles.Clear();
                studentsTable.ColumnCount = 0;
                studentsTable.RowCount = 0;

                studentsTable.AutoScroll = true;

                studentsTable.ColumnCount = 8;
                List<Student> students = service.Students.GetAll();
                int n = students.Count;
                studentsTable.RowCount = 1 + n;

                string[] titles = { "id", "Прізвище", "Ім'я", "По батькові", "Група", "Адреса", "Номер", "Кількість вибраних курсів"};
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
            }

            {
                subjectsTable.Controls.Clear();
                subjectsTable.ColumnStyles.Clear();
                subjectsTable.RowStyles.Clear();
                subjectsTable.ColumnCount = 0;
                subjectsTable.RowCount = 0;

                subjectsTable.AutoScroll = true;

                subjectsTable.ColumnCount = 4;
                List<Subject> subjects = service.Subjects.GetAll();
                int n = subjects.Count;
                subjectsTable.RowCount = 1 + n + 1;

                string[] titles = { "id", "Назва", "Опис"};
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
            }


            {
                semestersTable.Controls.Clear();
                semestersTable.ColumnStyles.Clear();
                semestersTable.RowStyles.Clear();
                semestersTable.ColumnCount = 0;
                semestersTable.RowCount = 0;

                semestersTable.AutoScroll = true;

                semestersTable.ColumnCount = 5;
                List<Semester> semesters = service.Semesters.GetAll();
                int n = semesters.Count;
                semestersTable.RowCount = 1 + n + 1;

                string[] titles = { "id", "Дата початку", "Дата кінця", "Мінімальне число курсів студентам" };
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
                    string[] fields = { semesters[row - 1].Id.ToString(), semesters[row - 1].BeginningDate, semesters[row - 1].EndDate, semesters[row-1].StudentsMinCoursesCount.ToString() };


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
            }
        }

        private void teacherExecute_Click(object sender, EventArgs e)
        {
            if (teacherAdd.Checked)
            {
                try
                {
                    service.Teachers.RegisterNew(new Teacher(
                        -1, teachersecond.Text, teacherfirst.Text, teachermiddle.Text, teacherdepartament.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося зареєструвати", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (teacherUpdate.Checked)
            {
                try
                {
                    service.Teachers.ChangeInfo(int.Parse(teacherid.Text), new Teacher(
                        int.Parse(teacherid.Text), teachersecond.Text, teacherfirst.Text, teachermiddle.Text, teacherdepartament.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося оновити дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (teacherDelete.Checked)
            {
                try
                {
                    service.Teachers.Unregister(int.Parse(teacherid.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося видалити", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DeaneryForm_Load(null, null);
        }

        private void studentExecute_Click(object sender, EventArgs e)
        {
            if (studentAdd.Checked)
            {
                try
                {
                    service.Students.RegisterNew(new Student(
                        -1, studentlast.Text, studentfirst.Text, studentmiddle.Text, studentgroup.Text, studentaddress.Text, studentphone.Text, -1));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося зареєструвати", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (studentUpdate.Checked)
            {
                try
                {
                    service.Students.ChangeInfo(int.Parse(studentid.Text), new Student(
                        int.Parse(studentid.Text), studentlast.Text, studentfirst.Text, studentmiddle.Text, studentgroup.Text, studentaddress.Text, studentphone.Text, -1));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося оновити дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (studentDelete.Checked)
            {
                try
                {
                    service.Students.Unregister(int.Parse(studentid.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося видалити", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DeaneryForm_Load(null, null);
        }

        private void subjectExecute_Click(object sender, EventArgs e)
        {
            if (subjectsadd.Checked)
            {
                try
                {
                    service.Subjects.AddNew(new Subject(
                        -1, subjectname.Text, subjectdescription.Text ));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося додати", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (subjectsupdate.Checked)
            {
                try
                {
                    service.Subjects.ChangeInfo(int.Parse(subjectid.Text), new Subject(
                        int.Parse(subjectid.Text), subjectname.Text, subjectdescription.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося оновити дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (subjectsdelete.Checked)
            {
                try
                {
                    service.Subjects.Remove(int.Parse(subjectid.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося видалити", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DeaneryForm_Load(null, null);
        }

        private void semesterExecute_Click(object sender, EventArgs e)
        {
            if (semesterAdd.Checked)
            {
                try
                {
                    service.Semesters.AddNew(new Semester(
                        -1, semesterstart.Text, semesterend.Text, int.Parse(semestermin.Text)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося додати", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (semesterUpdate.Checked)
            {
                try
                {
                    service.Semesters.ChangeInfo(int.Parse(semesterid.Text), new Semester(
                        -1, semesterstart.Text, semesterend.Text, int.Parse(semestermin.Text)));    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося оновити дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (semesterDelete.Checked)
            {
                try
                {
                    service.Semesters.Remove(int.Parse(semesterid.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не вдалося видалити", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DeaneryForm_Load(null, null);
        }
    }
}
