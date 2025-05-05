using buissness.Services;
using DataAccess.repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class employeecontroller : Controller
    {
        private readonly employeerepo _repo;
        private readonly employeeservice _service;

        public employeecontroller(employeeservice service,employeerepo repo)
        {
            _service = service;
            _repo =repo;

        }
        [HttpGet("Getname/{name}",Name ="Getname")]
        public async Task<dynamic> getname([FromRoute] string name)
        {
            var res=await _service.GetnameService(name);
            return res;
        }
        [HttpGet("GetAllEmpDetails/",Name ="GetAllEmpetails")]

        public async Task<IActionResult> GetAllEmpDetails()
        {
            var res = await _service.GetAllempdetailsService();
            return res;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
