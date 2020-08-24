using MongoDB.Bson;

namespace APICatalogo.Models
{
    public class Produto
    {
        public string CodProduto { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }
        public Fornecedor InfoFornecedor { get; set; }
    }

    public class Fornecedor
    {
        public string CodFornecedor { get; set; }
        public string Nome { get; set; }
    }

    public class Servico
    {
        public string CodServico { get; set; }
        public string Nome { get; set; }
        public double VlHora { get; set; }
    }
}