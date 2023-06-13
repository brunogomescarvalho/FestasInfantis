
namespace FestasInfantis.WinApp.ModuloCompartilado
{
    public class Configuracao
    {
        #region ToolTips
        public string ToolTipInserir { get; private set; }
        public string ToolTipEditar { get; private set; }
        public string ToolTipExcluir { get; private set; }
        public string ToolTipAdicionarItem { get; set; }

        #endregion


        #region BtnsEnable
        public bool BtnAdicionarEnabled { get; set; }
        public bool BtnEditarEnabled { get; set; }
        public bool BtnExcluirEnabled { get; set; }
        public bool BtnItemTemaEnabled { get; set; } 

        #endregion


        public Configuracao(string toolTipInserir, string toolTipEditar, string toolTipExcluir)
        {
            ToolTipInserir = toolTipInserir;
            ToolTipEditar = toolTipEditar;
            ToolTipExcluir = toolTipExcluir;

            BtnAdicionarEnabled = true;
            BtnEditarEnabled = true;
            BtnExcluirEnabled = true;

        }


    }
}
