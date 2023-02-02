using System;
namespace RawgSharp;

public class RawgClient
{
    private static RawgClient _instance = null;

    private RawgClient() { }

    public static RawgClient GetInstance()
    {
        if (_instance is null)
        {
            _instance = new RawgClient();
        }
        return _instance;
    }
}