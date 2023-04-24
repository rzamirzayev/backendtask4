using backendtask4.Models;
using Microsoft.EntityFrameworkCore;
namespace backendtask4.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        public DbSet<Services> Services { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
