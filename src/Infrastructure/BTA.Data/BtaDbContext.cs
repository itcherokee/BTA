namespace BTA.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class BtaDbContext : IdentityDbContext
    {
        public BtaDbContext(DbContextOptions<BtaDbContext> options)
            : base(options)
        {
        }
    }
}