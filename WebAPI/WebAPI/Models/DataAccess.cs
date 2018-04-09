using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace WebAPI.Models
{
    public class DataAccess
    {
        private string connectionString;
        IMongoDatabase _db;
        MongoClient _client;
        public DataAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMongo"].ConnectionString;
            _client = new MongoClient(connectionString);
            _db = _client.GetDatabase("ProjetoMarte");
        }

        public MoveMongo Create(MoveMongo m)
        {
            _db.GetCollection<MoveMongo>("Move").InsertOne(m);
            return m;
        }
    }
}