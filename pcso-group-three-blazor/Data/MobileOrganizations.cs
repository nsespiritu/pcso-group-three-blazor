namespace pcso_group_three_blazor.Data
{
	public class MobileOrganizations
	{
		public int MobileOrganizationsID { get; set; } = 0;

		public string? DepartmentName { get; set; } = "";

		public string? EmployeeName { get; set; } = "";

		public string? EmployeePosition { get; set; } = "";

		public byte[]? EmployeePicture { get; set; } = null;

		public string? EmployeePictureURL { get; set; } = "";
	}
}
