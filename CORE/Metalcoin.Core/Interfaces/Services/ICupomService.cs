﻿using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;

namespace Metalcoin.Core.Interfaces.Services
{
    public interface ICupomService
    {
        Task<CupomResponse> CadastrarCupom(CupomCadastrarRequest cupom);
        Task<CupomResponse> AtualizarCupom(CupomAtualizarRequest cupom);
        Task<bool> DeletarCupom(Guid id);
    }
}


