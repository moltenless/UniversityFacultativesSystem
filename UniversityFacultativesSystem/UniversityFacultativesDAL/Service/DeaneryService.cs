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
    public class DeaneryService
    {
        private readonly MySqlConnection connection;

        private readonly TeachersRepository teachersRepository;
        private readonly StudentsRepository studentsRepository;

        public DeaneryService(string user, string password)
        {
            connection = new MySqlConnection($"Server=localhost; database=course; UID={user}; password={password}");
            connection.Open();

            teachersRepository = new TeachersRepository(connection);
            studentsRepository = new StudentsRepository(connection);
        }



        public void Close() => connection.Close();
    }
}
