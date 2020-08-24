using AutoMapper;
using APICatalogo.Models;
using APICatalogo.Documents;

namespace APICatalogo.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ItemCatalogoDocument, Produto>()
                .ForMember(dest => dest.CodProduto, m => m.MapFrom(c => c.Codigo))            
                .ForMember(dest => dest.InfoFornecedor, m => m.MapFrom(c => c.DadosFornecedor));            
            CreateMap<ItemCatalogoDocument, Servico>()
                .ForMember(dest => dest.CodServico, m => m.MapFrom(c => c.Codigo))            
                .ForMember(dest => dest.VlHora, m => m.MapFrom(c => c.ValorHora));            
            CreateMap<FornecedorProduto, Fornecedor>()
                .ForMember(dest => dest.CodFornecedor, m => m.MapFrom(c => c.Codigo));        
        }
    }
}