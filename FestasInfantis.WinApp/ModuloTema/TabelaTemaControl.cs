
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            CriarColunas();

            gridTema.ConfigurarGridSomenteLeitura();

            gridTema.ConfigurarGridZebrado();
        }

        public void AtualizarLista(List<Tema> temas)
        {
            gridTema.Rows.Clear();

            temas.ForEach(i =>
            {
                gridTema.Rows.Add(i.Id, i.Nome, String.Join(",", i.Itens), $"RS{i.Total}");
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
                {Name = "itens", HeaderText = "Itens" },

                new DataGridViewTextBoxColumn()
                {Name = "valorTotal", HeaderText = "Valor Total" },

            };

            gridTema.Columns.AddRange(columns);
        }
    }
}
