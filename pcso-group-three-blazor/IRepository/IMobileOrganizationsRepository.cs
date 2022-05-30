using pcso_group_three_blazor.Data;

namespace pcso_group_three_blazor.IRepository
{
	public interface IMobileOrganizationsRepository
	{
		public MobileOrganizations Save(MobileOrganizations mobileOrganizations);
		public MobileOrganizations Update(MobileOrganizations mobileOrganizations);
		public MobileOrganizations Get(int mobileOrganizationsID = 0);
		public List<MobileOrganizations> Gets();
		public string Delete(int mobileOrganizationsID = 0);

	}
}
