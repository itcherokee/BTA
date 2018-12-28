namespace BTA.Data
{
    using BTA.Core.Domain.Orgaization;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class BtaDbContext : IdentityDbContext
    {
        public BtaDbContext(DbContextOptions<BtaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Zone> Zones { get; set; }

        public DbSet<Country> Country { get; set; }

        public DbSet<Area> Areas { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<BusinessUnit> BusinessUnit { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}