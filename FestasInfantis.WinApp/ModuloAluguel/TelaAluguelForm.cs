using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloCompartilhado;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {

        private Aluguel aluguel = null!;

        public Aluguel Aluguel
        {
            get => aluguel;
            set
            {




            }
        }

        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();

            clientes.ForEach(cliente => { txtCliente.Items.Add(cliente); });
            temas.ForEach(tema => { txtTema.Items.Add(tema); });

            var pgtos = Enum.GetValues<FormaDePagamento>().Select(valor => new { x = valor.ToDescription(), value = valor }).ToList();
            var descontos = Enum.GetValues<PorcentagemDesconto>().Select(valor => new { x = valor.ToDescription(), value = valor }).ToList();
            var entradas = Enum.GetValues<PorcentagemEntrada>().Select(valor => new { x = valor.ToDescription(), value = valor }).ToList();

            txtPagemento.DataSource = pgtos;
            txtDesconto.DataSource = descontos;
            txtEntrada.DataSource = entradas;

            txtPagemento.DisplayMember = "x";
            txtPagemento.ValueMember = "value";

            txtDesconto.DisplayMember = "x";
            txtDesconto.ValueMember = "value";

            txtEntrada.DisplayMember = "x";
            txtEntrada.ValueMember = "value";

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)txtCliente.SelectedItem;

            DateTime dataFesta = Convert.ToDateTime(txtData.Value.ToString());

            PorcentagemEntrada entrada = (PorcentagemEntrada)txtEntrada.SelectedValue;

            PorcentagemDesconto desconto = (PorcentagemDesconto)txtDesconto.SelectedValue;

            FormaDePagamento pagamento = (FormaDePagamento)txtPagemento.SelectedValue;

            string endereco = txtEndereco.Text;

            Tema tema = (Tema)txtTema.SelectedItem;

            aluguel = new Aluguel(tema, cliente, entrada, desconto, endereco, dataFesta, pagamento);

            string[] erros = aluguel.Validar();

            if (erros.Any())
            {
                TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void TxtTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItens.Items.Clear();

            Tema tema = (Tema)txtTema.SelectedItem;

            tema.Itens.ForEach(i => listItens.Items.Add(i));

            txtPreco.Text = tema.ValorTotal.ToString();
        }
    }
}
