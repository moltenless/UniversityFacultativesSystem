using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    internal class GradesRepository
    {
        private readonly MySqlConnection connection;
        internal GradesRepository(MySqlConnection connection) => this.connection = connection;

        internal void Insert(Grade grade)
        {
            string query = $"insert semesters_grades value ('{grade.SemesterId}', '{grade.EnrollmentId}', '{grade.Value}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void Update(int id, Grade grade)
        {
            string query = $"update semesters_grades set semester_id = '{grade.SemesterId}', enrollment_id = '{grade.EnrollmentId}'," +
                $" grade = '{grade.Value}' where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void Delete(int id)
        {
            string query = $"delete from semesters_grades where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal List<Grade> SelectAll()
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

        internal Grade Select(int id)
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

        internal Grade SelectBySemester(int semesterId)
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

        internal Grade SelectByEnrollment(int enrollmentId)
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

        internal List<DetailedGrade> SelectAllDetailed()
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
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetInt32(9),
                            reader.GetInt32(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetInt32(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetString(9),
                            reader.GetInt32(10)));
                    }
                }
            }
            return grades;
        }

        internal void ModifyGrades(int semesterId, int teacherId, int value)
        {
            string query = $"call modifygrades({semesterId}, {teacherId}, {value});";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
