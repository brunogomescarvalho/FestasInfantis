using FestasInfantis.Dominio.ModuloTema;
using System.Linq;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaItemTemaForm : Form
    {

        List<ItemTema> listaItemTema = new List<ItemTema>();
        List<ItemTema> listaReserva = new List<ItemTema>();

        public TelaItemTemaForm(Tema temaSelecionado)
        {
            InitializeComponent();

            CarregarTemas(temaSelecionado);

            CarregarListaItens(temaSelecionado);

        }

        private void CarregarTemas(Tema temaSelecionado)
        {
            txtTema.Text = temaSelecionado.Nome;

            listBoxItensTema.Items.Clear();

            List<ItemTema> itemTemas = temaSelecionado.Itens.ToList();

            foreach (ItemTema itemTema in itemTemas)
            {
                listBoxItensTema.Items.Add($"{itemTema.nome} | {itemTema.valor}");
            }
        }

        public List<ItemTema> BuscarItem()
        {
            return listaItemTema;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string itemDescrito = txtNomeItem.Text;

            decimal valor = Convert.ToDecimal(numericValor.Value);

            if (String.IsNullOrEmpty(itemDescrito) && String.IsNullOrWhiteSpace(itemDescrito))
            {
                MessageBox.Show("Nome inválido", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ItemTema itemTema = new ItemTema(valor, itemDescrito);

                listaItemTema.Add(itemTema);
                listaReserva.Add(itemTema);

                listBoxItensTema.Items.Add($"{itemTema.nome} | {itemTema.valor}");

                txtNomeItem.Clear();
                numericValor.Value = 0;
            }

        }

        public void CarregarListaItens(Tema temaSelecionado)
        {
            foreach (ItemTema item in temaSelecionado.Itens)
            {
                listaItemTema.Add(item);
                listaReserva.Add(item);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            foreach (ItemTema item in listaReserva)
            {
                if (listBoxItensTema.SelectedItem.ToString().Contains(item.nome))
                {
                    listaItemTema.Remove(item);
                }
            }

            listBoxItensTema.Items.Clear();

            foreach (ItemTema item in listaItemTema)
            {
                listBoxItensTema.Items.Add($"{item.nome} | {item.valor}");
            }
        }
    }
}
