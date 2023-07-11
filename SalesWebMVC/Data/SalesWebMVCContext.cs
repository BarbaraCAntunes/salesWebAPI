using Microsoft.EntityFrameworkCore;


namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public SalesWebMVCContext(DbContextOptions<SalesWebMVCContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }
        public DbSet<SalesWebMVC.Models.Department> Department { get; set; } = default!;
    }
}
