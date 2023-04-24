using backendtask4.DataAccess;
using backendtask4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace backendtask4.Controllers
{
    public class MemberController : Controller
    {
            private readonly DataContext _context;
            public MemberController(DataContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                List<TeamMember> services = _context.TeamMembers.ToList();
                return View(services);
            }
        }
    
}
