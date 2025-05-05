using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DataAccess.models;
using DataAccess.NewFolder;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.repository
{
    public class employeerepo : ControllerBase
    {
        private datacontext _context;
        private employeemodel _model;

        public employeerepo(employeemodel model, datacontext context)
        {
            _model = model;
            _context = context;
        }
        public async Task<dynamic> Getnamerepo(string name)
        {
            var res = "my name is" + name;
            return res;
        }
        public async Task<IActionResult> GetAllempdetailsrepo()
        {
            var cmd = "select * from employee";
            var employees = new List<employeemodel>();
            using (var connection = _context.createconnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var employee = new employeemodel
                        {
                            id = reader.GetInt32(reader.GetOrdinal("Id")),
                            name = reader.GetString(reader.GetOrdinal("name")),
                            designation = reader.GetString(reader.GetOrdinal("designaton")),
                            department = reader.GetString(reader.GetOrdinal("department")),

                        };
                        employees.Add(employee);


                    }
                }
            }
            return Ok(employees);
        }
    }
}
    

