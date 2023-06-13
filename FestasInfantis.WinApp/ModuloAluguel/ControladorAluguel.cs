using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;
namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {

        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private TabelaAluguelControl? tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
            ConfigurarTela();        
        }

        public override void AtualizarListagem()
        {
            List<Aluguel> alugueis = repositorioAluguel.BuscarTodos();

            tabelaAluguel?.AtualizarLista(alugueis);

            TelaPrincipalForm.TelaPrincipal!.AlterarLabelRodape(alugueis.Count == 0 ? "Nenhum aluguel cadastrado até o momento!" : alugueis.Count == 1 ? "Exibindo 1 aluguel" : $"Exibindo {alugueis.Count} aluguéis.");
        }

        public override void ConfigurarTela()
        {
            TelaPrincipalForm.TelaPrincipal!.AlterarLabelMenu("Cadastro de Aluguel");

            Configuracao ??= new Configuracao("Adicionar Aluguel", "Editar Aluguel", "Excluir Aluguel");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            List<Tema> temas = repositorioTema.BuscarTodos();

            List<Cliente> clientes = repositorioCliente.BuscarTodos();

            TelaAluguelForm telaAluguel = new TelaAluguelForm(clientes, temas)
            {
                Text = "Cadastrar Aluguel"
            };
            
            DialogResult result = telaAluguel.ShowDialog();

            if(result == DialogResult.OK)
            {
                Aluguel novoAluguel = telaAluguel.Aluguel;

                repositorioAluguel.Cadastrar(novoAluguel);

                AtualizarListagem();
            }
        }

        public override UserControl ObterListagem()
        {
            tabelaAluguel ??= new TabelaAluguelControl();

            AtualizarListagem();

            return tabelaAluguel;
        }
    }
}
