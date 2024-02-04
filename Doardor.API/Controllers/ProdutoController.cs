using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    public class ProdutoController : Controller
    {
       private readonly IProdutoService _produtoService;

        public ProdutoController (IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> PostCadastrarAsync(ProdutoCommand command)
        {
            return Ok(await _produtoService.PostCadastrarAsync(command));

        }
        [HttpGet]
        [Route("Read")]
        public async Task<IActionResult> GetActionAsync()
        {
            return Ok(await _produtoService.GetActionAsync());
        }

        [HttpPut]
        [Route("Update")]

        public async Task<IActionResult> PutAtualizarAsync(int ProdutoID, ProdutoCommand command)
        {
            return Ok(await _produtoService.PutAtualizarAsync(ProdutoID, command));


        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteAsync(int ProdutoID)
        {
            return Ok(await _produtoService.DeleteAsync(ProdutoID));
        }

    }
}
