using System;
namespace RawgSharp.Resources
{
	public interface IResource<TModel>
	{
		TModel Get();
		List<TModel> GetAll();
	}
}

