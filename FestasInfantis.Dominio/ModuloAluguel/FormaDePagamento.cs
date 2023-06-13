using System.ComponentModel;

namespace FestasInfantis.Dominio.ModuloAluguel
{
    public enum FormaDePagamento
    {
        [Description("Dinheiro")] Dinheiro,
        [Description("Cartão")] Cartao,
        [Description("Pix")] Pix
    }

}
