using System.Collections.Generic;
using backendtask4.Models;

namespace backendtask4.ViewModels
{
    public class HomeViewModel
    {
        public List<Services> Services { get; set; }
        public List<TeamMember> Members { get; set; }
    }
}
