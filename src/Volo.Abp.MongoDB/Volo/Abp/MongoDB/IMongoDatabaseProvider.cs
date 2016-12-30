﻿using MongoDB.Driver;

namespace Volo.Abp.MongoDB
{
    public interface IMongoDatabaseProvider<TMongoDbContext>
        where TMongoDbContext : AbpMongoDbContext
    {
        IMongoDatabase GetDatabase();
    }
}