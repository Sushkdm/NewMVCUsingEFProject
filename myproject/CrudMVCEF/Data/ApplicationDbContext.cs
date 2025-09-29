using CrudMVCEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVCEF.Data
{
    public class ApplicationDbContext :  DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
