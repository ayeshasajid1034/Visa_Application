// /Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using VisaApplicationManager.Models;

namespace VisaApplicationManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<VisaApplication> VisaApplications { get; set; }
    }
}
