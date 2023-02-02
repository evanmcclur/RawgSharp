using System;
namespace RawgSharp.Resources.Developers
{
	public class Developer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Slug { get; set; }
		public int GamesCount { get; set; }
		public string ImageBackground { get; set; }

		internal Developer() { }
	}
}

