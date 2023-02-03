using System;

namespace RawgSharp.Resources
{
	public abstract class Resource<T>
	{
		protected readonly string BASE_URL = "https://api.rawg.io/api/";

        public Resource()
		{
		}
    }
}

