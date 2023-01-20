using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbMongoDBJE
{
    internal class CRUD
    {
        private readonly IMongoCollection<ProductODM> products;

        public CRUD(MongoDAO dao, string collectionName )
        {
            products = (IMongoCollection<ProductODM>?)dao.GetCollection<MongoDAO>(collectionName);
        }

        public void Create(ProductODM product)
        {
            products.InsertOne(product);
        }

        public ProductODM Read(string id)
        {
            var filter = Builders<ProductODM>.Filter.Eq("Id", id);
            return products.Find(filter).FirstOrDefault();
            //return this.collection.Find(new BsonDocument()).ToList();
        }

        public List<ProductODM> ReadAll()
        {
            return products.Find(new BsonDocument()).ToList();
        }

        public void Update(ProductODM product)
        {
            var filter = Builders<ProductODM>.Filter.Eq("Id", product.Id);
            products.ReplaceOne(filter, product);
        }

        public void Delete(string id)
        {
            var filter = Builders<ProductODM>.Filter.Eq("Id", id);
            products.DeleteOne(filter);
        }
    }
}
