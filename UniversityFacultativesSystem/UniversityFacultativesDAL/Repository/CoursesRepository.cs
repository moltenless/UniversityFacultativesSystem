using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    internal class CoursesRepository
    {
        private readonly MySqlConnection connection;
        internal CoursesRepository(MySqlConnection connection) => this.connection = connection;

        internal void Insert(Course course)
        {
            string query = $"insert facultativecourses value ('{course.SubjectId}', '{course.TeacherId}', '{course.Hours}', '{course.Type}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void Update(int id, Course course)
        {
            string query = $"update facultativecourses set subject_id = '{course.SubjectId}', teacher_id = '{course.TeacherId}'," +
                $" hours = '{course.Hours}', type = '{course.Type}' where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal void Delete(int id)
        {
            string query = $"delete from facultativecourses where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        internal List<Course> SelectAll()
        {
            List<Course> courses = new List<Course>();
            string query = $"select * from facultativecourses;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetString(4)));
                    }
                }
            }
            return courses;
        }

        internal Course Select(int id)
        {
            Course course;
            string query = $"select * from facultativecourses where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    course = new Course(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetString(4));
                }
            }
            return course;
        }

        internal Course SelectByTeacher(int teacherId)
        {
            Course course;
            string query = $"select * from facultativecourses where teacher_id = {teacherId};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    course = new Course(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetString(4));
                }
            }
            return course;
        }

        internal Course SelectBySubject(int subjectId)
        {
            Course course;
            string query = $"select * from facultativecourses where subject_id = {subjectId};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    course = new Course(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetString(4));
                }
            }
            return course;
        }

        internal List<DetailedCourse> SelectAllDetailed()
        {
            List<DetailedCourse> courses = new List<DetailedCourse>();
            string query = $"select * from facultativescourses_inclusive_view;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new DetailedCourse(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(10)));
                    }
                }
            }
            return courses;
        }
    }
}
