using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Nu3.Configuration;
using Nu3.Models;
using Nu3.Services.Interfaces;

namespace Nu3.Services
{
    public class MongoAccess : IDataAccessProvider
    {
        private MongoClient _client;
        private MongoServer _server;
        private MongoDatabase _db;
 
        public MongoAccess()
        {
            _client = new MongoClient(DatabaseConfiguration.DBConnectionString);
            _server = _client.GetServer();
            _db = _server.GetDatabase(DatabaseConfiguration.DBName);
        }
 
        public IEnumerable<T> Get<T>(string entity)
        {
            return _db.GetCollection<T>(entity).FindAll();
        }
 
 
        public T Get<T>(ObjectId id, string entity)
        {
            var res = Query<User>.EQ(p=>p.Id,id);
            return _db.GetCollection<T>(entity).FindOne(res);
        }
 
        public T Create<T>(T p, string entity)
        {
            _db.GetCollection<T>(entity).Save(p);
            return p;
        }
 
        public void Update(ObjectId id, User p)
        {
            p.Id = id;
            var res = Query<User>.EQ(pd => pd.Id,id);
            var operation = Update<User>.Replace(p);
            _db.GetCollection<User>("Users").Update(res,operation);
        }
        public void Remove(ObjectId id, string entity)
        {
            var res = Query<User>.EQ(e => e.Id, id);
            _db.GetCollection<User>(entity).Remove(res);
        }

        public bool Exists<T>(ObjectId id, string entity)
        {
            return (Get<T>(id, entity) != null);
        }
    }
}