using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CupomController : ControllerBase
    {
        private readonly ICupomRepository _cupomRepository;
        private readonly ICupomService _cupomService;

        public CupomController(ICupomRepository cupomRepository, ICupomService cupomService)
        {
            _cupomRepository = cupomRepository;
            _cupomService = cupomService;
        }

        [HttpGet]
        [Route("todoscupom")]
        public async Task<ActionResult<IEnumerable<Cupom>>> ObterTodosCupons()
        {
            var listaCupons = await _cupomRepository.ObterTodos();

            if (listaCupons.Count == 0) return NoContent();

            return Ok(listaCupons);
        }

        [HttpGet]
        [Route("idcupom")]
        public async Task<ActionResult<Cupom>> ObterUmCupom(Guid id)
        {
            var cupom = await _cupomRepository.ObterPorId(id);
            if (cupom == null) return NotFound("Cupom não encontrado");
            return Ok(cupom);
        }

        [HttpPost]
        [Route("cadastrarcupom")]
        public async Task<ActionResult<Cupom>> CadastrarCupom(CupomCadastrarRequest cupom)
        {
            if (cupom == null)
                return BadRequest("Informe os dados do cupom");
           
            var response = await _cupomService.CadastrarCupom(cupom);

            if (response == null)
                return BadRequest("Falha ao cadastrar o cupom");

            return Created("cadastrar", response);
            
        }

        [HttpPut]
        [Route("atualizarcupom")]
        public async Task<ActionResult<Cupom>> AtualizarCupom(CupomAtualizarRequest cupom)
        {
            if (cupom == null) return BadRequest("Nenhum valor chegou na API");

            var response = await _cupomService.AtualizarCupom(cupom);

            if (response == null) return NotFound("Cupom não encontrado");

            return Ok(response);
        }

        [HttpDelete]
        [Route("deletarcupom")]
        public async Task<ActionResult<string>> RemoverCupom(Guid id)
        {
            if (id == Guid.Empty) return BadRequest("Id não informado");

            var resultado = await _cupomService.DeletarCupom(id);

            if (!resultado) return NotFound("O cupom que está tentando deletar não existe");

            return Ok("Cupom deletado com sucesso");
        }
    }
}
