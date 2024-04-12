using MongoDB.Driver;
using MongoDB.Bson;
using ClashOfClansApi.Models;
using Microsoft.Extensions.Options;


namespace ClashOfClansApi.Services;

public class MongoDBservices
{
    private readonly IMongoCollection<Playlist> _playlistCollection;

    public MongoDBservices(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _playlistCollection = database.GetCollection<Playlist>(mongoDBSettings.Value.CollectionName);
    }
}

