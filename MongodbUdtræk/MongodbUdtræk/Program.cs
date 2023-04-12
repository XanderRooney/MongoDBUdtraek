using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;


namespace Shelter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb+srv://eaa:87654321@clusterboys.7blwzny.mongodb.net/test");
            var database = client.GetDatabase("shelterDB");

            var collection = database.GetCollection<BsonDocument>("shelter_minus");
            var documents = collection.Find(_ => true).ToList();
            Console.WriteLine(documents.Count);
            foreach (var doc in documents) {

                var s = doc["properties"]["facil_ty"].ToString();
                if (s.Equals("Shelter") )
                    Console.WriteLine(doc);
            }
        }
    }
}