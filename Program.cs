using LabbMongoDBJE;
using MongoDB.Driver;

var connection = "mongodb+srv://iths2018:iths2018@clusterone.lft8vp1.mongodb.net/test";
var dao = new MongoDAO(connection);
var cruds = new CRUD(dao, "Films");

var product1 = new ProductODM
{
    Title = "Inception",
    Director = "Cristopher Nolan",
    Genre = "Action, Sci-Fi",
    Price = 4.99m
};
cruds.Create(product1);
Console.WriteLine("Product created: " + product1.Title);

var product2 = cruds.Read("<insert product id here>");
Console.WriteLine("Product read: " + product2.Title);

product2.Price = 1.49m;
cruds.Update(product2);
Console.WriteLine("Product updated: " + product2.Title);

cruds.Delete("<insert product id here>");
Console.WriteLine("Product deleted.");