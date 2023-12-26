using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    internal class StudentsRepository
    {
        private readonly MySqlConnection connection;
        internal StudentsRepository(MySqlConnection connection) => this.connection = connection;


        internal void InsertStudentAndCreateUser(Student student)
        {
            string query = $"call insert_student_and_create_user" +
                $"('{student.LastName}', '{student.FirstName}', '{student.MiddleName}'," +
                $" '{student.Group}', '{student.Address}', '{student.Phone}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void DeleteStudentAndUser(int id)
        {
            string query = $"call delete_student_and_user({id});";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void Update(int id, Student student)
        {
            string query = $"update students set last_name = '{student.LastName}', first_name = '{student.FirstName}', " +
                $"middle_name = '{student.MiddleName}', group_name = '{student.Group}', address = '{student.Address}', " +
                $"phone = '{student.Phone}', facultatives_taken = '{student.CoursesTaken}' where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal List<Student> SelectAll()
        {
            List<Student> students = new List<Student>();
            string query = $"select * from students;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetInt32(7)));
                    }
                }
            }
            return students;
        }

        internal Student Select(int id)
        {
            Student student;
            string query = $"select * from students where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    student = new Student(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetInt32(7));
                }
            }
            return student;
        }
    }
}
