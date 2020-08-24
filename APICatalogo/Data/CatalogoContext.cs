using System.Linq;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using APICatalogo.Documents;

namespace APICatalogo.Data
{
    public class CatalogoContext
    {
        private IConfiguration _configuration;

        public CatalogoContext(IConfiguration config)
        {
            _configuration = config;
        }

        public ItemCatalogoDocument GetItem(string codigo)
        {
            MongoClient client = new MongoClient(
                _configuration.GetConnectionString("ConexaoCatalogo"));
            IMongoDatabase db = client.GetDatabase("DBCatalogo");

            var filter = Builders<ItemCatalogoDocument>
                .Filter.Eq("Codigo", codigo);

            return db.GetCollection<ItemCatalogoDocument>("Catalogo")
                .Find(filter).FirstOrDefault();
        }        
    }
}