using MySql.Data.MySqlClient;
using System.Collections.Generic;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    public class LoginsRepository
    {
        private readonly MySqlConnection connection;
        public LoginsRepository(MySqlConnection connection) => this.connection = connection;

        public List<UserLogin> GetTeachersLogins()
        {
            List<UserLogin> teachers = new List<UserLogin>();
            string query = $"select * from teacher_logins;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teachers.Add(new UserLogin(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)));
                    }
                }
            }
            return teachers;
        }

        public List<UserLogin> GetStudentsLogins()
        {
            List<UserLogin> students = new List<UserLogin>();
            string query = $"select * from student_logins;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new UserLogin(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)));
                    }
                }
            }
            return students;
        }
    }
}
