using System;
namespace RawgSharp.Resources.Developers
{
	public class DeveloperDetails
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Slug { get; set; }
		public int GamesCount { get; set; }
		public string ImageBackground { get; set; }
		public string Description { get; set; }

		internal DeveloperDetails() { }
	}
}

