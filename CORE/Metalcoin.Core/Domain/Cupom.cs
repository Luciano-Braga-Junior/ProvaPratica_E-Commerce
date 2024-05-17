using Metalcoin.Core.Abstracts;
using Metalcoin.Core.Enums;

namespace Metalcoin.Core.Domain
{
    public class Cupom : Entidade
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDesconto { get; set; }
        public TipoDesconto TipoDesconto { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeLiberada { get; set; }
        public int QuantidadeUsada { get; set; }
        public TipoStatusCupom TipoStatusCupom { get; set; }
    }
}
