using AplicacaoBanco.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoBanco.Controllers
{
    public class EnderecoController : Controller
    {
        private IEnderecoRepositorio _enderecoRepositorio;
        public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        public IActionResult Index()
        {
            return View(_enderecoRepositorio.ObterTodosEnderecos() );
        }
    }
}
