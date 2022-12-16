using CadastroDeContatos.Controllers;
using CadastroDeContatos.Models;
using CadastroDeContatos.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ContatoModel>>> BuscarTodos()
        {
            List<ContatoModel> contatos = await _contatoRepositorio.BuscarTodos();
            return Ok(contatos);
        }

        [HttpPost]
        public async Task<ActionResult<ContatoModel>> Cadastrar([FromBody] ContatoModel contatoModel)
        {
            ContatoModel contato = await _contatoRepositorio.Adicionar(contatoModel);
            return Ok(contato);
        }
    }

}
