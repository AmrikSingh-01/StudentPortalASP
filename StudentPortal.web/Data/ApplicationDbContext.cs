using Microsoft.EntityFrameworkCore;
using StudentPortal.web.Models.Entities;

namespace StudentPortal.web.Data // name of the folder
{
    public class ApplicationDbContext: DbContext // inside this we tell what all tables we want to have in our db
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Student> Students { get; set; } // to interact with student table in sql server data base
    }
}
