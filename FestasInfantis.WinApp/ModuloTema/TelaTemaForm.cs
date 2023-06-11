using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();
        }
        private Tema tema;

        public Tema Tema
        {
            get => tema;
            set
            {
                txtId.Text = value.Id.ToString();
                txtTema.Text = value.nome;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeTema = txtTema.Text;
            tema = new Tema(nomeTema);

            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                tema.Id = id;
            }

            string[] erros = tema.Validar();

            if (erros.Any())
            {
                TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

    }
}
