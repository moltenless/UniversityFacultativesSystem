﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using UniversityFacultativesDAL.Entity;

namespace UniversityFacultativesDAL.Repository
{
    public class EnrollmentsRepository
    {
        private readonly MySqlConnection connection;
        public EnrollmentsRepository(MySqlConnection connection) => this.connection = connection;

        public void AddNew(Enrollment enrollment)
        {
            string query = $"insert enrollments (student_id, course_id) value " +
                $"('{enrollment.StudentId}', '{enrollment.CourseId}');";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void Remove(int id)
        {
            string query = $"delete from enrollments where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<Enrollment> GetAll()
        {
            List<Enrollment> enrollments = new List<Enrollment>();
            string query = $"select * from enrollments;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enrollments.Add(new Enrollment(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2)));
                    }
                }
            }
            return enrollments;
        }

        public Enrollment Get(int id)
        {
            Enrollment enrollment;
            string query = $"select * from enrollments where id = {id};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    enrollment = new Enrollment(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2));
                }
            }
            return enrollment;
        }

        public Enrollment GetWithStudent(int studentId)
        {
            Enrollment enrollment;
            string query = $"select * from enrollments where student_id = {studentId};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    enrollment = new Enrollment(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2));
                }
            }
            return enrollment;
        }

        public Enrollment GetWithCourse(int courseId)
        {
            Enrollment enrollment;
            string query = $"select * from enrollments where course_id = {courseId};";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read()) throw new Exception("Reader hasn't found anything");
                    enrollment = new Enrollment(reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2));
                }
            }
            return enrollment;
        }

        public List<DetailedEnrollment> GetAllDetailed()
        {
            List<DetailedEnrollment> enrollments = new List<DetailedEnrollment>();
            string query = $"select * from enrollments_inclusive_view;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enrollments.Add(new DetailedEnrollment(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetInt32(9),
                            reader.GetInt32(10),
                            reader.GetString(11),
                            reader.GetString(12),
                            reader.GetInt32(13),
                            reader.GetString(14),
                            reader.GetString(15),
                            reader.GetString(16),
                            reader.GetString(17),
                            reader.GetString(18),
                            reader.GetString(19)));
                    }
                }
            }
            return enrollments;
        }
    }
}
