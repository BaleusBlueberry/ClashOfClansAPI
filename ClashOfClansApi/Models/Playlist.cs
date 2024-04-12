using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ClashOfClansApi.Models;

public class Playlist
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("title")]
    public string title { get; set; } = null!;

    public List<string> cast { get; set; } = null!;
}

