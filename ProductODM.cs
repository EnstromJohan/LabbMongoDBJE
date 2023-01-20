using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbMongoDBJE
{
    internal class ProductODM
    {
        [BsonId]

        public ObjectId Id { get; set; }
        [BsonElement("title")]

        public string Title { get; set; }
        [BsonElement("director")]
        public string Director { get; set; }
        [BsonElement("genre")]
        public string Genre { get; set; }
        [BsonElement("price")]
        public decimal Price { get; set; }
    }
}
