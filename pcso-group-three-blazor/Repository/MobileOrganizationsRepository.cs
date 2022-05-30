using pcso_group_three_blazor.Data;
using pcso_group_three_blazor.DBContext;
using pcso_group_three_blazor.IRepository;

namespace pcso_group_three_blazor.Repository
{
	public class MobileOrganizationsRepository : IMobileOrganizationsRepository
	{

		ContextDB _contextDB;

		public MobileOrganizationsRepository(ContextDB contextDB)
		{
			_contextDB = contextDB;
		}

		public string Delete(int mobileOrganizationsID = 0)
		{
			var item = _contextDB.mobileOrganizations.FirstOrDefault(x => x.MobileOrganizationsID == mobileOrganizationsID);
			_contextDB.mobileOrganizations.Remove(item);
			_contextDB.SaveChanges();
			return "Deleted";

		}

		public MobileOrganizations Get(int mobileOrganizationsID = 0)
		{
			return _contextDB.mobileOrganizations.FirstOrDefault(x => x.MobileOrganizationsID == mobileOrganizationsID);
		}

		public List<MobileOrganizations> Gets()
		{
			return _contextDB.mobileOrganizations.ToList();
		}

		public MobileOrganizations Save(MobileOrganizations mobileOrganizations)
		{
			_contextDB.mobileOrganizations.Add(mobileOrganizations);
			_contextDB.SaveChanges();
			return this.Get(mobileOrganizations.MobileOrganizationsID);

		}

		public MobileOrganizations Update(MobileOrganizations mobileOrganizations)
		{
			_contextDB.mobileOrganizations.Update(mobileOrganizations);
			_contextDB.SaveChanges();
			return this.Get(mobileOrganizations.MobileOrganizationsID);
		}
	}
}
