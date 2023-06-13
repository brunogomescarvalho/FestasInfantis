using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaItemTemaForm : Form
    {
        Tema tema = null!;

        public TelaItemTemaForm(Tema temaSelecionado)
        {
            tema = temaSelecionado;

            InitializeComponent();

            CarregarTemas();
        }

        private void CarregarTemas()
        {
            txtId.Text = tema.Id.ToString();

            txtTema.Text = tema.Nome;

            listBoxItensTema.Items.Clear();

            if(tema.Itens != null)
            {
                foreach (ItemTema item in tema.Itens)
                {
                    listBoxItensTema.Items.Add(item);
                }
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            string itemDescrito = txtNomeItem.Text;

            decimal valor = Convert.ToDecimal(numericValor.Value);

            if (string.IsNullOrEmpty(itemDescrito) && string.IsNullOrWhiteSpace(itemDescrito))
            {
                MessageBox.Show("Nome inválido", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var itemTema = new ItemTema(valor, itemDescrito);

                tema.Itens ??= new();

                bool cadastrou = tema.AdicionarItemNoTema(itemTema);

                if (cadastrou == false)
                {
                    MessageBox.Show("Item com um nome igual já cadastrado", "Item já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
                else
                {
                    listBoxItensTema.Items.Add(itemTema);
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ItemTema item = (ItemTema)listBoxItensTema.SelectedItem;

            tema.Itens.Remove(item);

            listBoxItensTema.Items.Remove(item);         
        }
    }
}
