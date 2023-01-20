using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbMongoDBJE
{
    
    internal class MongoDAO
    {
        private readonly IMongoDatabase database;

        public MongoDAO(string connection)
        {
            MongoClient dbClient = new MongoClient(connection);
            database = dbClient.GetDatabase("Webshop");
        }

        public IMongoCollection<T>GetCollection<T>(string name) 
        {
            return database.GetCollection<T>(name);
        }
    }
}
