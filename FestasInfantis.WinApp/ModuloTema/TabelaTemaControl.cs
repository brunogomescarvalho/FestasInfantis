
using FestasInfantis.Dominio.ModuloTema;

public delegate void OnEnviarIdSelecionado_EventHandler(int id);

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {

        public OnEnviarIdSelecionado_EventHandler onEnviarId = null!;
        public TabelaTemaControl()
        {
            InitializeComponent();

            CriarColunas();

            gridTema.ConfigurarGridSomenteLeitura();

            gridTema.ConfigurarGridZebrado();

            gridTema.CellDoubleClick += GridTema_ObterDetalhes!;
        }

        public void AtualizarLista(List<Tema> temas)
        {
            gridTema.Rows.Clear();

            temas.ForEach(i =>
            {
                gridTema.Rows.Add(i.Id, i.Nome, i.Itens == null || i.Itens.Count == 0 ? 0 : i.Itens.Count, $"RS {i.ValorTotal}");
            });
        }


        public int BuscarIdSelecionado()
        {
            try
            {
                return Convert.ToInt32(gridTema.SelectedRows[0].Cells[0].Value);
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
                { Name = "nome", HeaderText = "Tema"},

                new DataGridViewTextBoxColumn()
                {Name = "totalItens", HeaderText = "Qtd Itens" },

                new DataGridViewTextBoxColumn()
                {Name = "valorTotal", HeaderText = "Valor Total" },

            };

            gridTema.Columns.AddRange(columns);
        }

        private void GridTema_ObterDetalhes(object sender, EventArgs e)
        {
            int id =(int)gridTema.SelectedRows[0].Cells[0].Value;

            onEnviarId(id);          
        }
    }
}
