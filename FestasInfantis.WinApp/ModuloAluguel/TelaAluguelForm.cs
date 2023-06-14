using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloCompartilhado;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {

        Aluguel aluguel = null!;
        Tema tema = null!;

        List<Cliente> Clientes = null! ;
        List<Tema> Temas = null!;
        List<ItemTema> ItensAdicionais = null!;

        public Aluguel Aluguel
        {
            get => aluguel;

            set
            {
                PreencherCamposEditar(value, Clientes, Temas);
            }
        }

        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.Clientes = clientes;
            this.Temas = temas;

            clientes.ForEach(cliente => { txtCliente.Items.Add(cliente); });
            temas.ForEach(tema => { txtTema.Items.Add(tema); });

            var pgtos = Enum.GetValues<FormaDePagamento>().Select(valor => new { x = valor.ToDescription(), value = valor }).ToList();
            var descontos = Enum.GetValues<PorcentagemDesconto>().Select(valor => new { x = valor.ToDescription(), value = valor }).ToList();
            var entradas = Enum.GetValues<PorcentagemEntrada>().Select(valor => new { x = valor.ToDescription(), value = valor }).ToList();

            txtPagamento.DataSource = pgtos;
            txtDesconto.DataSource = descontos;
            txtEntrada.DataSource = entradas;

            txtPagamento.DisplayMember = "x";
            txtPagamento.ValueMember = "value";

            txtDesconto.DisplayMember = "x";
            txtDesconto.ValueMember = "value";

            txtEntrada.DisplayMember = "x";
            txtEntrada.ValueMember = "value";

        }

        private void PreencherCamposEditar(Aluguel aluguel, List<Cliente> clientes, List<Tema> temas)
        {
            ItensAdicionais = aluguel.Adicionais;
            tema = aluguel.Tema;

            var temaSelecionado = temas.FirstOrDefault(i => i.Equals(aluguel.Tema));
            var clienteSelecionado = clientes.FirstOrDefault(i => i.Equals(aluguel.Cliente));

            txtData.Text = aluguel.DataFesta.ToString();
            txtPreco.Text = aluguel.ValorTotal.ToString();
            txtEndereco.Text = aluguel.Endereco;
            txtId.Text = aluguel.Id.ToString();

            txtCliente.Enabled = false;

            foreach (var item in txtCliente.Items)
            {
                if (item == clienteSelecionado)
                    txtCliente.SelectedItem = item;
            }

            foreach (var item in txtTema.Items)
            {
                if (item == temaSelecionado)
                    txtTema.SelectedItem = item;
            }

            foreach (var item in txtPagamento.Items)
            {
                var pgto = new { x = aluguel.FormaPagamento.ToDescription(), value = aluguel.FormaPagamento };

                if (pgto.Equals(item))
                {
                    txtPagamento.SelectedItem = pgto;
                    break;
                }
            }

            foreach (var item in txtDesconto.Items)
            {
                var desc = new { x = aluguel.Desconto.ToDescription(), value = aluguel.Desconto };

                if (desc.Equals(item))
                {
                    txtDesconto.SelectedItem = desc;
                    break;
                }
            }

            foreach (var item in txtEntrada.Items)
            {
                var entrad = new { x = aluguel.PorcentagemDeEntrada.ToDescription(), value = aluguel.PorcentagemDeEntrada };

                if (entrad.Equals(item))
                {
                    txtEntrada.SelectedItem = entrad;
                    break;
                }
            }

            if(aluguel.Adicionais!=null)
            {
                foreach (var item in aluguel.Adicionais)
                {
                   
                    listAdicionais.Items.Add(item);
                }

                txtPreco.Text = aluguel.ValorTotal.ToString();
            }


        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)txtCliente.SelectedItem;

            DateTime dataFesta = Convert.ToDateTime(txtData.Value.ToString());

            PorcentagemEntrada entrada = (PorcentagemEntrada)txtEntrada.SelectedValue;

            PorcentagemDesconto desconto = (PorcentagemDesconto)txtDesconto.SelectedValue;

            FormaDePagamento pagamento = (FormaDePagamento)txtPagamento.SelectedValue;

            string endereco = txtEndereco.Text;

            Tema tema = (Tema)txtTema.SelectedItem;

            aluguel = new Aluguel(tema, cliente, entrada, desconto, endereco, dataFesta, pagamento, ItensAdicionais);

            string[] erros = aluguel.Validar();

            if (txtId.Text != "")
                aluguel.Id = Convert.ToInt32(txtId.Text);

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


        private void BtnAddItensOpcionais_Click(object sender, EventArgs e)
        {

            tema = (Tema)txtTema.SelectedItem;

            var telaAdicionais = new TelaItensOpcionaisForm(Temas, tema)
            {
                Text = "Adicionar itens opcionais"
            };

            if (tema == null) return;

            ItensAdicionais ??= new();
          
            DialogResult result = telaAdicionais.ShowDialog();
            {
                if (result == DialogResult.OK)
                {
                    ItensAdicionais.AddRange( telaAdicionais.itensOpcionais);
                    CarregarItens();
                }
            }
        }

        private void CarregarItens()
        {
            listAdicionais.Items.Clear(); 
            ItensAdicionais.ForEach(i => listAdicionais.Items.Add(i));
            
            decimal preco = 0;
            preco = Convert.ToDecimal(tema.ValorTotal);
            preco += ItensAdicionais.Sum(i => i.Valor);
            txtPreco.Text = preco.ToString();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ItensAdicionais.Remove((ItemTema)listAdicionais.SelectedItem);
            listAdicionais.Items.Clear();
            CarregarItens();
        }
    }
}
