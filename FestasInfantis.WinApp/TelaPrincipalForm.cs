using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.InfraDados.ModuloCliente;
using FestasInfantis.InfraDados.ModuloCompartilhado;
using FestasInfantis.InfraDados.ModuloTema;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloCompartilado;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        private static readonly ContextoDados contexto = new ContextoDados(carregarArquivos: true);

        private readonly IRepositorioCliente repositorioCliente = new RepositorioCliente(contexto);

        private readonly IRepositorioTema repositorioTema = new RepositorioTema(contexto);

        public static TelaPrincipalForm? TelaPrincipal { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            TelaPrincipal = this;
        }

        public void AlterarLabelMenu(string texto)
        {
            this.labelMenu.Text = texto;
        }

        public void AlterarLabelRodape(string texto)
        {
            this.labelRodape.Text = texto;
        }

        private void ConfigurarTabela(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelTelaPrincipal.Controls.Clear();

            panelTelaPrincipal.Controls.Add(listagem);
        }

        private void ClientesMenu_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);

            ConfigurarBotoes(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarBotoes(ControladorBase controlador)
        {

            btnAdicionar.Enabled = controlador.Configuracao.BtnAdicionarEnabled;

            btnEditar.Enabled = controlador.Configuracao.BtnEditarEnabled;

            btnExcluir.Enabled = controlador.Configuracao.BtnExcluirEnabled;

            btnItemTema.Enabled = controlador.Configuracao.BtnAdicionarEnabled;

        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnAdicionar.ToolTipText = controlador.Configuracao.ToolTipInserir;

            btnEditar.ToolTipText = controlador.Configuracao.ToolTipEditar;

            btnExcluir.ToolTipText = controlador.Configuracao.ToolTipExcluir;

            btnItemTema.ToolTipText = controlador.Configuracao.ToolTipAdicionarItem;

        }

        private void TematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);

            ConfigurarBotoes(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);
        }

        private void btnItemTema_Click(object sender, EventArgs e)
        {
            controlador.AdicionarItemTema();
        }
    }
}