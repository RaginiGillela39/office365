using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TQMS_Admin_Identity.Seeds;

namespace TQMS_Admin_Identity.DbContext
{
    public class ApplicationDb:IdentityDbContext<IdentityUser>
    {
        ApplicationDb(DbContextOptions<ApplicationDb> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //SeedRole.
        }
    }

    
}
