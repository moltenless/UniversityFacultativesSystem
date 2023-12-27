using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    public class SemestersRepository
    {
        private readonly MySqlConnection connection;
        public SemestersRepository(MySqlConnection connection) => this.connection = connection;

        public void AddNew(Semester semester)
        {
            string query = $"insert semesters value ('{semester.BeginningDate}', '{semester.EndDate}', '{semester.StudentsMinCoursesCount}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void ChangeInfo(int id, Semester semester)
        {
            string query = $"update semesters set beginning_date = '{semester.BeginningDate}', end_date = '{semester.EndDate}', students_min_subjects_count = '{semester.StudentsMinCoursesCount}' where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void Remove(int id)
        {
            string query = $"delete from semesters where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<Semester> GetAll()
        {
            List<Semester> semesters = new List<Semester>();
            string query = $"select * from semesters;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        semesters.Add(new Semester(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3)));
                    }
                }
            }
            return semesters;
        }

        public Semester Get(int id)
        {
            Semester semester;
            string query = $"select * from semesters where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    semester = new Semester(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3));
                }
            }
            return semester;
        }
    }
}
