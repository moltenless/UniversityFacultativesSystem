using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityFacultativesDAL.Repository
{
    internal class TeachersRepository
    {
        private readonly MySqlConnection connection;
        internal TeachersRepository(MySqlConnection connection) => this.connection = connection;

        
    }
}
