using Microsoft.EntityFrameworkCore;
using pcso_group_three_blazor.Data;

namespace pcso_group_three_blazor.Model
{
    public class MobileOrganizationsContext : DbContext
    {
        public MobileOrganizationsContext(DbContextOptions<MobileOrganizationsContext> options) : base(options)
        {

        }

        public DbSet<MobileOrganizations> mobileOrganizations { get; set; }

    }
}
