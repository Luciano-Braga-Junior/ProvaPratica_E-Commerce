using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;

namespace MetalCoin.Application.Services
{
    public class CupomService : ICupomService
    {
        private readonly ICupomRepository _cupomRepository;
        public CupomService(ICupomRepository repository)
        {
            _cupomRepository = repository;
        }
        
        public async Task<CupomResponse> CadastrarCupom(CupomCadastrarRequest cupom)
        {
            var cupomExistente = await _cupomRepository.BuscarPorNome(cupom.Descricao);

            if (cupomExistente != null) return null;

            var cupomEntidade = new Cupom
            {
                Descricao = cupom.Descricao,
                Codigo = cupom.Codigo,
                TipoStatusCupom = cupom.TipoStatusCupom,
                DataValidade = cupom.DataValidade,
                ValorDesconto = cupom.ValorDesconto,
                QuantidadeLiberada = cupom.QuantidadeLiberada,
                QuantidadeUsada = cupom.QuantidadeUsada,
                TipoDesconto = cupom.TipoDesconto

            };

            await _cupomRepository.Adicionar(cupomEntidade);

            var response = new CupomResponse
            {
                Descricao = cupomEntidade.Descricao,
                TipoStatusCupom = cupomEntidade.TipoStatusCupom,
                DataValidade = cupomEntidade.DataValidade,
                ValorDesconto = cupomEntidade.ValorDesconto,
                QuantidadeLiberada = cupomEntidade.QuantidadeLiberada,
                QuantidadeUsada = cupomEntidade.QuantidadeUsada,
                TipoDesconto = cupomEntidade.TipoDesconto
            };

            return response;
        }
        public async Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom)
        {
            var cupomDb = await _cupomRepository.BuscarPorNome(cupom.Descricao);

            cupomDb.TipoStatusCupom = cupom.TipoStatusCupom;
            cupomDb.Descricao = cupom.Descricao;
            cupomDb.DataValidade = cupom.DataValidade;
            cupomDb.TipoDesconto = cupom.TipoDesconto;
            cupomDb.QuantidadeLiberada = cupom.QuantidadeLiberada;
            cupomDb.QuantidadeUsada = cupom.QuantidadeUsada;
            cupomDb.ValorDesconto = cupom.ValorDesconto;

            await _cupomRepository.Atualizar(cupomDb);

            var response = new CupomResponse
            {
                Id = cupomDb.Id,
                Descricao = cupomDb.Descricao,
                TipoStatusCupom = cupomDb.TipoStatusCupom,
                DataValidade = cupomDb.DataValidade,
                TipoDesconto = cupomDb.TipoDesconto,
                QuantidadeLiberada = cupomDb.QuantidadeLiberada,
                QuantidadeUsada = cupomDb.QuantidadeUsada,
                ValorDesconto = cupomDb.ValorDesconto

            };

            return response;
        }
        public async Task<bool> DeletarCupom(Guid id)
        {
            var cupom = await _cupomRepository.ObterPorId(id);
            if (cupom == null) return false;


            await _cupomRepository.Remover(id);
            return true;
        }
    }
}