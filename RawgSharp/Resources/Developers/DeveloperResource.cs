using System;

namespace RawgSharp.Resources.Developers
{
    public class DeveloperResource : Resource<Developer>, IDeveloperResource
    {
        private HttpClient _client;

        public DeveloperResource(HttpClient client)
        {
            _client = client;
        }

        public async Task<Paginated<Developer>> GetAllDevelopersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Developer> GetDeveloperDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

