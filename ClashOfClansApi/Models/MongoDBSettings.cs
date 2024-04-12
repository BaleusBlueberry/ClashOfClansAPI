﻿namespace ClashOfClansApi.Models;

public class MongoDBSettings
{
    public string ConnectionUri { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string CollectionName { get; set; } = null!;
}

