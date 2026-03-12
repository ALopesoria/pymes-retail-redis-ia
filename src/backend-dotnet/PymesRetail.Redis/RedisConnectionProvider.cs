using StackExchange.Redis;

namespace PymesRetail.Redis;

public class RedisConnectionProvider
{
    private readonly ConnectionMultiplexer _muxer;

    // Por ahora asumimos Redis en localhost:6379 sin password para desarrollo
    public RedisConnectionProvider(string connectionString = "localhost:6379")
    {
        _muxer = ConnectionMultiplexer.Connect(connectionString);
    }

    public IDatabase GetDatabase()
    {
        return _muxer.GetDatabase();
    }
}
