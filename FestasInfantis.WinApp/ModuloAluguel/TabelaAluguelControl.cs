
using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCompartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();
           
            CriarColunas();

            gridAluguel.ConfigurarGridSomenteLeitura();

            gridAluguel.ConfigurarGridZebrado();
        }

        public void AtualizarLista(List<Aluguel> alugueis)
        {
            gridAluguel.Rows.Clear();

            alugueis.ForEach(i =>
            {
                gridAluguel.Rows.Add(i.Id, i.Cliente.Nome, i.Cliente.Telefone, i.DataFesta.ToShortDateString(),
                    i.Tema.Nome,$"R$ {i.ValorTotal}", i.FormaPagamento.ToDescription(), i.PorcentagemDeEntrada.ToDescription(), i.Desconto.ToDescription(),
                    $"R$ {i.Debito}", i.EstaEmAberto ? "Sim": "Não", $"{i.DataPedido.ToShortDateString()}");
            });
        }


        public int BuscarIdSelecionado()
        {
            try
            {
                return Convert.ToInt32(gridAluguel.SelectedRows[0].Cells[0].Value);
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
                { Name = "nome", HeaderText = "Nome Cliente"},

                new DataGridViewTextBoxColumn()
                {Name = "telCliente", HeaderText = "Tel Cliente" },

                new DataGridViewTextBoxColumn()
                {Name = "dataFesta", HeaderText = "Data Festa" },

                new DataGridViewTextBoxColumn()
                {Name = "nomeTema", HeaderText = "Tema" },

                new DataGridViewTextBoxColumn()
                {Name = "valorTotal", HeaderText = "Valor Total" },

                new DataGridViewTextBoxColumn()
                {Name = "formaPgto", HeaderText = "Pagamento" },

                new DataGridViewTextBoxColumn()
                {Name = "entrada", HeaderText = "Entrada" },

                new DataGridViewTextBoxColumn()
                {Name = "desconto", HeaderText = "Desconto" },

                new DataGridViewTextBoxColumn()
                {Name = "debito", HeaderText = "Débito" },

                new DataGridViewTextBoxColumn()
                {Name = "estaAberto", HeaderText = "Em Aberto" },

                new DataGridViewTextBoxColumn()
                {Name = "dataPedido", HeaderText = "Data Pedido" }

            };

            gridAluguel.Columns.AddRange(columns);
        }



    }
}
