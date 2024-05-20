using Metalcoin.Core.Enums;

namespace Metalcoin.Core.Dtos.Response
{
    public class CupomResponse
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDesconto { get; set; }
        public TipoDesconto TipoDesconto { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeLiberada { get; set; }
        public int QuantidadeUsada { get; set; }
        public TipoStatusCupom TipoStatusCupom { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
