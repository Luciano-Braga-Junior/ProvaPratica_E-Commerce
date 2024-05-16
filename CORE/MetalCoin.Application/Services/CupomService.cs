using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;

namespace MetalCoin.Application.Services
{
    public class CupomService : ICupomService
    {
        Task<CupomResponse> ICupomService.AtualizarCupom(CupomAtualizarRequest cupomRequest)
        {
            throw new NotImplementedException();
        }

        Task<CupomResponse> ICupomService.CadastrarCupom(CupomCadastrarRequest cupomRequest)
        {
            throw new NotImplementedException();
        }

        Task ICupomService.CadastrarCupom(Cupom cupomRequest)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICupomService.DeletarCupom(Guid id)
        {
            throw new NotImplementedException();
        }

        Task ICupomService.ObterCupomPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICupomService.UtilizarCupom(string codigoCupom, Guid idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}