using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Poznamky.Models;

namespace Poznamky.Data
{
    public class ApplicationDbContext : IdentityDbContext<Uzivatel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Poznamka> Poznamky { get; set; }
    }
}