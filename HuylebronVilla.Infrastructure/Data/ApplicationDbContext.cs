using HuylebronVilla.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HuylebronVilla.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
    }
}