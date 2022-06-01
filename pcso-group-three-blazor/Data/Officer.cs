namespace pcso_group_three_blazor.Data
{
	public class Officer
	{
		public int id { get; set; }
		public string? name { get; set; }
		public string? position { get; set; }
		public string? department { get; set; }
		public string? imageURL { get; set; }
		public byte[]? image { get; set; } = null;
		public string? description { get; set; }
		public int officeId { get; set; }
		public DateTime created { get; set; }

	}
}
