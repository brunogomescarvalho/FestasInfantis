using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();
        }

        private Tema tema = null!;

        public Tema Tema
        {
            get => tema;
            set
            {
                txtId.Text = value.Id.ToString();

                txtTema.Text = value.Nome;
 
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeTema = txtTema.Text;

            tema = new Tema(nomeTema);

            if (txtId.Text != "")
            {
                tema.Id = Convert.ToInt32(txtId.Text);              
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
