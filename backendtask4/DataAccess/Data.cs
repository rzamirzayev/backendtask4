using backendtask4.Models;
using System.Collections.Generic;
namespace backendtask4.DataAccess
{
    public static class Data
    {
        public static List<Services> Services = new List<Services>
       {
           new Services{Id=1,Title="Lorem Ipsum",Icon="bx bxl-dribbble",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
           new Services{Id=2,Title="Sed ut perspiciatis",Icon="bx bx-file",Description="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
           new Services{Id=3,Title="Magni Dolores",Icon="bx bx-tachometer",Description="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
       };
        public static List<TeamMember> TeamMembers = new List<TeamMember>
        {
            new TeamMember{Id=1,Name="Walter White",Icon="img-fluid",Description="Chief Executive Officer"},
            new TeamMember{Id=2,Name="Sarah Jhonson",Icon="img-fluid",Description="Product Manager"},
            new TeamMember{Id=3,Name="William Anderson",Icon="img-fluid",Description="William Anderson"},
            new TeamMember{Id=4,Name="Amanda Jebson",Icon="img-fluid",Description="Accountant"},
        };
    }
}
