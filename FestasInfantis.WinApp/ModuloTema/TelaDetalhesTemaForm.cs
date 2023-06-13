
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaDetalhesTemaForm : Form
    {
        public TelaDetalhesTemaForm(Dominio.ModuloTema.Tema tema)
        {
            InitializeComponent();

            PreencherCampos(tema);

            this.ConfigurarDialog();
        }

        private void PreencherCampos(Tema tema)
        {
            txtNr.Text = tema.Id.ToString();
            txtPreco.Text = tema.ValorTotal.ToString();
            txtTema.Text = tema.Nome.ToString();

            listItens.DataSource = tema.Itens;
            listItens.TabStop = false;
        }
    }
}
