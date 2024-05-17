using Metalcoin.Core.Domain;
using Metalcoin.Core.Enums;

namespace Metalcoin.Core.Interfaces.Repositories
{
    public interface ICupomRepository : IRepository<Cupom>
    {
        Task<Cupom> BuscarPorNome(string descricao);
    }
}
