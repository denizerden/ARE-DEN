using System.Data.Entity;

namespace are_den.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext():base("dataConnection")
        {
            Database.SetInitializer(new ProjectInitializer());
        }
        public DbSet<Project> Projects { get; set; }

    }
}