namespace Metalcoin.Core.Interfaces.Services
{
    public class ICupomService
    {
        public interface ICupomService
        {
            Task<CupomResponse> CadastrarCupom(CupomCadastrarRequest cupom);
            Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom);
            Task<bool> DeletarCupom(Guid id);
            Task<bool> UtilizarCupom(string codigoCupom, Guid idUsuario);
            // Adicione outros métodos de serviço conforme necessário
        }
    }
}
}
