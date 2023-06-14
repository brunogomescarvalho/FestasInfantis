using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaItensOpcionaisForm : Form
    {

       public List<ItemTema> itensOpcionais = null!;

        public TelaItensOpcionaisForm(List<Tema> temas, Tema tema)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            temas.ForEach(t => t.Itens.ForEach(i =>
            {
                if(tema.Itens.Contains(i) == false)
                {
                    listAdicionais.Items.Add(i);
                }
               
            }));
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
             itensOpcionais = new List<ItemTema>(listAdicionais.CheckedItems.Cast<ItemTema>().ToList());
        }
    }
}
