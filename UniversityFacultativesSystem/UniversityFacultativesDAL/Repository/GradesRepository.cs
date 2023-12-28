using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    public class GradesRepository
    {
        private readonly MySqlConnection connection;
        public GradesRepository(MySqlConnection connection) => this.connection = connection;

        public void AddNew(Grade grade)
        {
            string query = $"insert semesters_grades (semester_id, enrollment_id, grade) value ('{grade.SemesterId}', '{grade.EnrollmentId}', '{grade.Value}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void ChangeInfo(int id, Grade grade)
        {
            string query = $"update semesters_grades set semester_id = '{grade.SemesterId}', enrollment_id = '{grade.EnrollmentId}'," +
                $" grade = '{grade.Value}' where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void Remove(int id)
        {
            string query = $"delete from semesters_grades where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<Grade> GetAll()
        {
            List<Grade> grades = new List<Grade>();
            string query = $"select * from semesters_grades;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grades.Add(new Grade(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3)));
                    }
                }
            }
            return grades;
        }

        public Grade Get(int id)
        {
            Grade grade;
            string query = $"select * from semesters_grades where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    grade = new Grade(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3));
                }
            }
            return grade;
        }

        public Grade GetWithSemester(int semesterId)
        {
            Grade grade;
            string query = $"select * from semesters_grades where semester_id = {semesterId};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    grade = new Grade(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3));
                }
            }
            return grade;
        }

        public Grade GetWithEnrollment(int enrollmentId)
        {
            Grade grade;
            string query = $"select * from semesters_grades where enrollment_id = {enrollmentId};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    grade = new Grade(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3));
                }
            }
            return grade;
        }

        public List<DetailedGrade> GetAllDetailed()
        {
            List<DetailedGrade> grades = new List<DetailedGrade>();
            string query = $"select * from semesters_grades_inclusive_view;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        grades.Add(new DetailedGrade(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5),
                            reader.GetInt32(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(10),
                            reader.GetString(11),
                            reader.GetString(12),
                            reader.GetString(13),
                            reader.GetInt32(14),
                            reader.GetInt32(15),
                            reader.GetString(16),
                            reader.GetString(17),
                            reader.GetInt32(18),
                            reader.GetString(19),
                            reader.GetString(20),
                            reader.GetString(21),
                            reader.GetString(22),
                            reader.GetString(23),
                            reader.GetString(24),
                            reader.GetInt32(25)));
                    }
                }
            }
            return grades;
        }

        public void ModifyGrades(int semesterId, int teacherId, int value)
        {
            string query = $"call modifygrades({semesterId}, {teacherId}, {value});";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
