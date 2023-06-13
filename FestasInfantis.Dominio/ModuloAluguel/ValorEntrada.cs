using System.ComponentModel;

namespace FestasInfantis.Dominio.ModuloAluguel
{
    public enum PorcentagemEntrada
    {
        [Description("40%")] _40porcento = 40,
        [Description("50%")]_50porcento = 50,
        [Description("60%")]_60porcento = 60,
        [Description("100%")]_100porcento = 100
    }

}
