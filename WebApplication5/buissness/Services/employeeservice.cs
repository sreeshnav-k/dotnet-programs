using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.repository;
using Microsoft.AspNetCore.Mvc;

namespace buissness.Services
{
    public class employeeservice
    {
        private readonly employeerepo _repo;
        public employeeservice(employeerepo repo)
        {
            _repo = repo;
        }
        public async Task<dynamic> GetnameService(string name)
        {
            var res=await _repo.Getnamerepo(name);
            return res;
        }
        public async Task<IActionResult>GetAllempdetailsService()
        {
            var res = await _repo.GetAllempdetailsrepo();
            return res;
        }
    }
}
