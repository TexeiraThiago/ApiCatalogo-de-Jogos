using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using ApiCatalogoJogos.Services;
namespace ApiCatalogoJogos.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]

    public class JogosController : ControllerBase
    {
        private readonly IJogoService _jogoService;
        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }
        [HttpGet]
        public async Task<ActionResult<List<JogoViewModel>>> Obter() => Ok();

        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<JogoViewModel>> Obter(Guid idJogo) => Ok();

        [HttpPost]
        public async Task<ActionResult<JogoViewModel>> InserirJogo(JogoInputModel jogo) => Ok();

        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, JogoInputModel jogo) => Ok();

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, double preco) => Ok();

        [HttpDelete("{idJogo:guid}")]
        public async Task<ActionResult> ApagarJogo(Guid idJogo) => Ok();

    }


}