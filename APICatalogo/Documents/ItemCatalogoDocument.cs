using MongoDB.Bson;

namespace APICatalogo.Documents
{
    public class ItemCatalogoDocument
    {
        public ObjectId _id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double? Preco { get; set; }
        public double? ValorHora { get; set; }
        public FornecedorProduto DadosFornecedor { get; set; }        
    }

    public class FornecedorProduto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
    }
}