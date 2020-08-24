using Microsoft.AspNetCore.Mvc;
using APICatalogo.Data;
using APICatalogo.Models;
using APICatalogo.Documents;
using AutoMapper;

namespace APICatalogo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogoController : ControllerBase
    {
        private readonly CatalogoContext _context;
        private readonly IMapper _mapper;

        public CatalogoController(CatalogoContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("produtos/{codigo}")]
        public ActionResult<Produto> GetProduto(string codigo)
        {
            ItemCatalogoDocument docProduto = null;
            if (codigo.StartsWith("PROD"))
                docProduto = _context.GetItem(codigo);

            if (docProduto != null)
                return _mapper.Map<Produto>(docProduto);
            else
                return NotFound();
        }

        [HttpGet("servicos/{codigo}")]
        public ActionResult<Servico> GetServico(string codigo)
        {
            ItemCatalogoDocument docServico = null;
            if (codigo.StartsWith("SERV"))
                docServico = _context.GetItem(codigo);

            if (docServico != null)
                return _mapper.Map<Servico>(docServico);
            else
                return NotFound();
        }
    }
}