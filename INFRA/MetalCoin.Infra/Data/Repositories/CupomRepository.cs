using Metalcoin.Core.Domain;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MetalCoin.Infra.Data.Repositories
{
    public class CupomRepository : Repository<Cupom>, ICupomRepository
    {
        public CupomRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<Cupom> BuscarPorNome(string descricao)
        {
            return await DbSet.FirstOrDefaultAsync(c => c.Descricao == descricao);
        }

        public async Task<Cupom> ObterCupomPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }
        
    }
}
