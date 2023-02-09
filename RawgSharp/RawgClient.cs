using System;
using RawgSharp.Resources.Developers;

namespace RawgSharp;

public class RawgClient
{
    // Only create one instance per application
    private static RawgClient _instance = null;
    // HttpClient is reused for each connection
    private static readonly HttpClient _client = new HttpClient();

    private RawgClient()
    {
        // set the base address for all requests
        _client.BaseAddress = new Uri("https://api.rawg.io/api/");
        // init resources below
        DeveloperResource = new DeveloperResource(_client);
    }

    public static RawgClient GetInstance()
    {
        if (_instance == null)
        {
            _instance = new RawgClient();
        }
        return _instance;
    }

    public IDeveloperResource DeveloperResource { get; }
}