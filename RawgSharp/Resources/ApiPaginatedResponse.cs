using System;
namespace RawgSharp.Resources
{
	public class ApiPaginatedResponse<TModel>
	{
		public int Count { get; set; }
		public string? Next { get; set; }
		public string? Previous { get; set; }
		public List<TModel> Results { get; set; }
	}
}

