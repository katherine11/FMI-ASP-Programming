using Microsoft.EntityFrameworkCore;

namespace SampleTestProject.Models
{
    public class SampleContext : DbContext
    {
        public  DbSet<Sample> Samples { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=sampledb;Trusted_Connection=True");
        }
    }
}