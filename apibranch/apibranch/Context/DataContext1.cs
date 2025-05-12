using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using apibranch.DataContext;
namespace apibranch.DataContext
{
        public class DataContext1 : DbContext
        {
            private readonly string _connectionstring;
            public DataContext1(IConfiguration configuration)
            {
                _connectionstring = configuration.GetConnectionString("Sqlconnection");

            }
            public SqlConnection createconnection()
            {
                return new SqlConnection(_connectionstring);
            }
        }
    }

