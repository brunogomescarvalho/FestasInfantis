using System.ComponentModel;

namespace FestasInfantis.Dominio.ModuloAluguel;

public enum PorcentagemDesconto
{
    [Description("Sem Desconto")]SemDesconto = 0,
    [Description("5%")]Cinco_PorCento = 5,
    [Description("10%")]Dez_PorCento = 10,
    [Description("15%")]Quinze_PorCento = 15,
}
