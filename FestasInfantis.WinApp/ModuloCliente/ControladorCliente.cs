using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        readonly IRepositorioCliente repositorioCliente;

        TabelaClientesControl? tabelaClientes;


        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;

            ConfigurarTela();

        }

        public override void AtualizarListagem()
        {
            List<Cliente> clientes = repositorioCliente.BuscarTodos();

            tabelaClientes?.AtualizarLista(clientes);

            TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(clientes.Count == 0 ? "Nenhum cliente cadastrado até o momento!" : clientes.Count == 1 ? "Exibindo 1 cliente" : $"Exibindo {clientes.Count} clientes.");

        }

        public override void ConfigurarTela()
        {
            TelaPrincipalForm.TelaPrincipal?.AlterarLabelMenu("Cadastro Clientes");

            Configuracao ??= new Configuracao("Inserir Cliente", "Editar Cliente", "Excluir Cliente");

        }

        public override void Editar()
        {
            int id = tabelaClientes!.BuscarIdSelecionado();

            if (id == -1) return;

            Cliente clienteSelecionado = repositorioCliente.ObterPorId(id);

            TelaClienteForm telaCliente = new()
            {
                Text = "Editar Cliente"
            };

            telaCliente.Cliente = clienteSelecionado;

            DialogResult dialog = telaCliente.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                Cliente clienteEditado = telaCliente.Cliente;
              
                bool editou = repositorioCliente.Editar(clienteEditado);

                if (editou == false)
                {
                    MessageBox.Show("O cpf informado já está cadastrado", "CPF já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AtualizarListagem();
                }
            }
        }

        public override void Excluir()
        {
            int id = tabelaClientes!.BuscarIdSelecionado();

            if (id == -1) return;

            Cliente clienteSelecionado = repositorioCliente.ObterPorId(id);

            DialogResult opcao = MessageBox.Show($"Confirma excluír o cliente {clienteSelecionado.Nome}? ", "Excluir Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                repositorioCliente.Excluir(clienteSelecionado.Id);
            }

            AtualizarListagem();
        }

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new()
            {
                Text = "Cadastrar Cliente"
            };

            DialogResult dialog = telaCliente.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                Cliente novoCliente = telaCliente.Cliente;

                bool cadastrou = repositorioCliente.Cadastrar(novoCliente);

                if (cadastrou == false)
                {
                    MessageBox.Show("O cpf informado já está cadastrado", "CPF já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AtualizarListagem();
                }
            }

        }

        public override UserControl ObterListagem()
        {
            tabelaClientes ??= new TabelaClientesControl();

            AtualizarListagem();

            return tabelaClientes;
        }
    }
}
