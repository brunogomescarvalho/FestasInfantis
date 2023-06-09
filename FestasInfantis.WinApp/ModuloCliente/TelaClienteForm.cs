using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente? cliente;

        public Cliente Cliente
        {
            get => cliente!;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtCpf.Text = value.Cpf;
                txtTelefone.Text = value.Telefone;
                txtEmail.Text = value.Email;
            }

        }

        public TelaClienteForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            cliente = new Cliente(nome, telefone, email, cpf);

            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                cliente.Id = id;
            }

            string[] erros = cliente.Validar();

            if (erros.Any())
            {
                TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
