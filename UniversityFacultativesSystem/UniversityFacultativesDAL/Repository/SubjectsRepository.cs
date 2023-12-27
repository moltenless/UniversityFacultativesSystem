using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    public class SubjectsRepository
    {
        private readonly MySqlConnection connection;
        public SubjectsRepository(MySqlConnection connection) => this.connection = connection;

        public void AddNew(Subject subject)
        {
            string query = $"insert subjects value ('{subject.Name}', '{subject.Description}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void ChangeInfo(int id, Subject subject)
        {
            string query = $"update subjects set name = '{subject.Name}', description = '{subject.Description}' where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void Remove(int id)
        {
            string query = $"delete from subjects where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<Subject> GetAll()
        {
            List<Subject> subjects = new List<Subject>();
            string query = $"select * from subjects;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)));
                    }
                }
            }
            return subjects;
        }

        public Subject Get(int id)
        {
            Subject subject;
            string query = $"select * from subjects where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    subject = new Subject(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2));
                }
            }
            return subject;
        }
    }
}
