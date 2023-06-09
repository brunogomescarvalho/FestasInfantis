using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClientesControl : UserControl
    {
        public TabelaClientesControl()
        {
            InitializeComponent();

            CriarColunas();

            gridClientes.ConfigurarGridSomenteLeitura();

            gridClientes.ConfigurarGridZebrado();
        }

        public void AtualizarLista(List<Cliente> clientes)
        {
            gridClientes.Rows.Clear();

            clientes.ForEach(i =>
            {
                gridClientes.Rows.Add(i.Id, i.Nome, i.Cpf, i.Telefone, i.Email);
            });
        }


        public int BuscarIdSelecionado()
        {
            try
            {
                return Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }

        private void CriarColunas()
        {
            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn()
                { Name = "id", HeaderText = "Número"},

                new DataGridViewTextBoxColumn()
                { Name = "nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn()
                {Name = "cpf", HeaderText = "CPF" },

                new DataGridViewTextBoxColumn()
                {Name = "telefone", HeaderText = "Telefone" },

                new DataGridViewTextBoxColumn()
                {Name = "e_mail", HeaderText = "E-mail" }

            };

            gridClientes.Columns.AddRange(columns);
        }
    }
}
