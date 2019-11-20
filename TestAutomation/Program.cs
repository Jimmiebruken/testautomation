using System;
using MongoDB;
using MongoDB.Driver;

namespace TestAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("Trafikverket");
            Console.ReadLine();
        }
    }

    public class MongoCRUD 
         
    {
        private IMongoDatabase db;
        
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);

        }

        
    }
}
