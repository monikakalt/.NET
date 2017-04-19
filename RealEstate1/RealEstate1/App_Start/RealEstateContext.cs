using MongoDB.Driver;
using RealEstate1.Properties;

namespace RealEstate1.App_Start
{
    public class RealEstateContext
    {
        public MongoDatabase Database;

        public RealEstateContext()
        {
            var client = new MongoClient(Settings.Default.RealEstateConnectionString);
            var server = client.GetServer();
            Database = server.GetDatabase(Settings.Default.RealEstateDatabaseName);
        }
    }
}