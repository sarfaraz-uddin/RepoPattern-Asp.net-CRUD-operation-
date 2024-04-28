using crud_repo_day_2_.Data;
using crud_repo_day_2_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace crud_repo_day_2_.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Fruit> fruits { get; set; }    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
    }
}
