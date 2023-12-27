using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    public class TeachersRepository
    {
        private readonly MySqlConnection connection;
        public TeachersRepository(MySqlConnection connection) => this.connection = connection;

        public void RegisterNew(Teacher teacher)
        {
            string query = $"call insert_teacher_and_create_user" +
                $"('{teacher.LastName}', '{teacher.FirstName}', '{teacher.MiddleName}', '{teacher.Department}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void Unregister(int id)
        {
            string query = $"call delete_teacher_and_user({id});";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void ChangeInfo(int id, Teacher teacher)
        {
            string query = $"update teachers set last_name = '{teacher.LastName}', first_name = '{teacher.FirstName}', " +
                $"middle_name = '{teacher.MiddleName}', department = '{teacher.Department}' where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<Teacher> GetAll()
        {
            List<Teacher> teachers = new List<Teacher>();
            string query = $"select * from teachers;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teachers.Add(new Teacher(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4)));
                    }
                }
            }
            return teachers;
        }

        public Teacher Get(int id)
        {
            Teacher teacher;
            string query = $"select * from teachers where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    teacher = new Teacher(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4));
                }
            }
            return teacher;
        }
    }
}
