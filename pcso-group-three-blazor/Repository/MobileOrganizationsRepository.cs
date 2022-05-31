using pcso_group_three_blazor.Data;
using pcso_group_three_blazor.DBContext;
using pcso_group_three_blazor.IRepository;
using pcso_group_three_blazor.Model;

namespace pcso_group_three_blazor.Repository
{
	public class MobileOrganizationsRepository : IMobileOrganizationsRepository
	{

		private MobileOrganizationsContext _mobileorganizationcontext;

		public MobileOrganizationsRepository(MobileOrganizationsContext mobileOrganization)
		{
			_mobileorganizationcontext = mobileOrganization;
		}

		public string Delete(int mobileOrganizationsID = 0)
		{
			var item = _mobileorganizationcontext.mobileOrganizations.FirstOrDefault(x => x.MobileOrganizationsID == mobileOrganizationsID);
			if (item != null)
			{
				_mobileorganizationcontext.mobileOrganizations.Remove(item);
				_mobileorganizationcontext.SaveChanges();
				return "Deleted";
			}
			else {
				return "No record found";
			}
		}

		public MobileOrganizations Get(int mobileOrganizationsID = 0)
		{
			var item = _mobileorganizationcontext.mobileOrganizations.FirstOrDefault(x => x.MobileOrganizationsID == mobileOrganizationsID);
			return item;
	
		}

		public List<MobileOrganizations> Gets()
		{
			return _mobileorganizationcontext.mobileOrganizations.ToList();
		}

		public MobileOrganizations Save(MobileOrganizations mobileOrganizations)
		{
			_mobileorganizationcontext.mobileOrganizations.Add(mobileOrganizations);
			_mobileorganizationcontext.SaveChanges();
			return this.Get(mobileOrganizations.MobileOrganizationsID);

		}

		public MobileOrganizations Update(MobileOrganizations mobileOrganizations)
		{
			_mobileorganizationcontext.mobileOrganizations.Update(mobileOrganizations);
			_mobileorganizationcontext.SaveChanges();
			return this.Get(mobileOrganizations.MobileOrganizationsID);
		}
	}
}
