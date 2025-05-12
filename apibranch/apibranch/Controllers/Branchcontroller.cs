
using apibranch.DataContext;
using apibranch.Model;
using Microsoft.AspNetCore.Mvc;
using apibranch.DataContext;
namespace apibranch.Controllers
{
    public class Branchcontroller :Controller
    {
        private readonly DataContext1 _context;
        private readonly Branchmodel _model;

        public Branchcontroller(Branchmodel model, DataContext1 context)
        {
            _model = model;
            _context = context;
        }

    }
}
