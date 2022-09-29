using System;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Learning.MongoDb.Cli
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connectionString = "mongodb://root:mongodb1!@localhost:27017";
            var client = new MongoClient(connectionString);

            Console.WriteLine("Databases");
            Console.WriteLine("----------------------------------------");

            var cursor = await client.ListDatabasesAsync();
            await cursor.ForEachAsync(db => Console.WriteLine(db["name"]));
        }
    }
}
