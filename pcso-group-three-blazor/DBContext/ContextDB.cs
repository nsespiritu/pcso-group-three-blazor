using Microsoft.EntityFrameworkCore;
using pcso_group_three_blazor.Data;

namespace pcso_group_three_blazor.DBContext
{
	public class ContextDB : DbContext
	{

		// overload constructor
		public ContextDB(DbContextOptions<ContextDB> options) : base(options)
		{

		}

		public DbSet<MobileOrganizations> mobileOrganizations { get; set; }

	}
}
