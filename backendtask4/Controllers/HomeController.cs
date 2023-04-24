using backendtask4.DataAccess;
using backendtask4.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backendtask4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel vm=new HomeViewModel
            {
                Services=Data.Services,
                Members=Data.TeamMembers
            };
            return View(vm);
        }
    }
}
