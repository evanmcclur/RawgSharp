using System;
using RawgSharp.Resources.Developers;

namespace RawgSharp;

public class RawgClient
{
    private static RawgClient _instance = null;
    private static readonly HttpClient _client = new HttpClient();

    private RawgClient()
    {
        // init resources here
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