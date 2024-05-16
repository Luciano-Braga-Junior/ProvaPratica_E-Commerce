using Metalcoin.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public record CupomCadastrarRequest
    {
        [Required(ErrorMessage = "O código do cupom é obrigatório")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "A descrição do cupom é obrigatória")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor do desconto é obrigatório")]
        public decimal ValorDesconto { get; set; }

        [Required(ErrorMessage = "O tipo de desconto é obrigatório")]
        public TipoDesconto TipoDesconto { get; set; }

        [Required(ErrorMessage = "A data de validade é obrigatória")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "A quantidade liberada é obrigatória")]
        public int QuantidadeLiberada { get; set; }
    }
}
