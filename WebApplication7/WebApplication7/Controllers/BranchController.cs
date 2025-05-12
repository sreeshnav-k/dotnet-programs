
using Microsoft.AspNetCore.Mvc;
using WebApplication7.context;
using WebApplication7.model;
using Microsoft.Data.SqlClient;

namespace WebApplication7.Controllers
{
    public class BranchController :Controller/// controller
    {
        private readonly Datacontext _context;
        private readonly Branchmodel _model;

        public BranchController(Datacontext context, Branchmodel model)
        {
            _model = model;
            _context = context;
        }
        [HttpGet("GetAllEmpDetails", Name = "GetAllEmpDetails")]
        public async Task<IActionResult> GetAllEmpDetails()
        {
            var cmd = "select * from branch1";
            var branches = new List<Branchmodel>();
            using (var connection = _context.createconnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var branch = new Branchmodel
                        {
                            brid = reader.GetInt32(reader.GetOrdinal("brid")),
                            brname = reader.GetString(reader.GetOrdinal("brname")),
                            head = reader.GetString(reader.GetOrdinal("head")),
                            noofemployees = reader.GetInt32(reader.GetOrdinal("noofemployees")),

                        };
                        branches.Add(branch);


                    }
                }
            }
            return Ok(branches);
        }


        [HttpGet("Getbranchbyid", Name = "Getbranchbyid")]
        public async Task<IActionResult> Getbranchbyid()
        {
            var cmd = "select brid,brname from branch1";
            var branches = new List<Branchmodel>();
            using (var connection = _context.createconnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var branch = new Branchmodel
                        {
                            brid = reader.GetInt32(reader.GetOrdinal("brid")),
                            brname = reader.GetString(reader.GetOrdinal("brname")),

                        };
                        branches.Add(branch);
                    }
                }
            }
            return Ok(branches);
        }

        [HttpGet("Searchbyid/{id}", Name = "Searchbyid")]
        public async Task<IActionResult> Searchbyid([FromRoute] int id)
        {
            var cmd = "select * from branch1 where brid = @id";
            var branches = new List<Branchmodel>();
            using (var connection = _context.createconnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);
                command.Parameters.AddWithValue("@id", id);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var branch = new Branchmodel
                        {
                            brid = reader.GetInt32(reader.GetOrdinal("brid")),
                            brname = reader.GetString(reader.GetOrdinal("brname")),
                            head = reader.GetString(reader.GetOrdinal("head")),
                            noofemployees = reader.GetInt32(reader.GetOrdinal("noofemployees")),

                        };
                        branches.Add(branch);


                    }
                }
            }
            return Ok(branches);
        }




















        public IActionResult Index()
        {
            return View();
        }
    }
}