using backendtask4.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using backendtask4.Models;

namespace backendtask4.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DataContext _context;
        public ServiceController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Services> services = _context.Services.ToList();
            return View(services);
        }
    }
}
