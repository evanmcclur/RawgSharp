using System;
namespace RawgSharp.Resources.Developers
{
	public interface IDeveloperResource
	{
		Task<Developer> GetDeveloperDetailsAsync(int id);
		Task<Paginated<Developer>> GetAllDevelopersAsync();
	}
}

