using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFacultativesDAL.Entity;
using UniversityFacultativesDAL.Repository;

namespace UniversityFacultativesDAL.Service
{
    public class DataService
    {
        private readonly MySqlConnection connection;
        private readonly string userName;

        public DataService(string user, string password)
        {
            connection = new MySqlConnection($"Server=localhost; database=course; UID={user}; password={password}");
            connection.Open();
            userName = user;

            Teachers = new TeachersRepository(connection);
            Students = new StudentsRepository(connection);
            Subjects = new SubjectsRepository(connection);
            Semesters = new SemestersRepository(connection);
            Courses = new CoursesRepository(connection);
            Enrollments = new EnrollmentsRepository(connection);
            Grades = new GradesRepository(connection);

            logins = new LoginsRepository(connection);

        }

        public TeachersRepository Teachers { get; }
        public StudentsRepository Students { get; }
        public SubjectsRepository Subjects { get; }
        public SemestersRepository Semesters { get; }
        public CoursesRepository Courses { get; }
        public EnrollmentsRepository Enrollments { get; }
        public GradesRepository Grades { get; }

        private LoginsRepository logins;
        public LoginsRepository Logins
        {
            get
            {
                if (userName == "deanery") return logins;
                else return null;
            }
        }

        public void Close() => connection.Close();
    }
}
