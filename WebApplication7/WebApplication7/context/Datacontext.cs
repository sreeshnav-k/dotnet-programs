
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WebApplication7.context
{
    public class Datacontext : DbContext
    {
        private readonly string _connectionstring;
        public Datacontext(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("Sqlconnection"); //sqlconnection this name should be same as those specified in the appp settings coonection string

        }
        public SqlConnection createconnection()
        {
            return new SqlConnection(_connectionstring);
        }
    }

}

