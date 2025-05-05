using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.NewFolder
{
    public class datacontext : DbContext
    {
        private readonly string _connectionstring;
        public datacontext(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("Sqlconnection");
            
            }
    public SqlConnection createconnection()
        {
            return new SqlConnection(_connectionstring);
        }
    }
}
