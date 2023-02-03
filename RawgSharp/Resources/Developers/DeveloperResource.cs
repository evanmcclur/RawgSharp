using System;

namespace RawgSharp.Resources.Developers
{
    public class DeveloperResource : Resource<Developer>, IDeveloperResource
    {
        public DeveloperResource(HttpClient client)
        {
        }

        /// <summary>
        /// Gets the details of a game developer
        /// </summary>
        /// <returns>Game developer details</returns>
        /// <exception cref="NotImplementedException"></exception>
        public DeveloperDetails Get(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of game developers
        /// </summary>
        /// <returns>List of game developers</returns>
        /// <exception cref="NotImplementedException"></exception>
        public ApiPaginatedResponse<Developer> GetAll()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}

