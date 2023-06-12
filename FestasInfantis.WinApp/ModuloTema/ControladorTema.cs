using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.InfraDados.ModuloCliente;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        IRepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTemas;

        public ControladorTema(IRepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;

            ConfigurarTela();

        }
        public override void AtualizarListagem()
        {
            List<Tema> temas = repositorioTema.BuscarTodos();

            tabelaTemas.AtualizarLista(temas);

            TelaPrincipalForm.TelaPrincipal?.AlterarLabelRodape(ObterTextoRodape(temas));
        }

        private static string ObterTextoRodape(List<Tema> temas)
        {
            if (temas.Count == 0)
                return "Nenhum tema cadastrado até o momento!";
            else if (temas.Count == 1)
                return "Exibindo 1 tema";

            return $"Exibindo {temas.Count} temas.";
        }

        public override void ConfigurarTela()
        {
            TelaPrincipalForm.TelaPrincipal?.AlterarLabelMenu("Cadastro Temas");

            Configuracao ??= new Configuracao("Inserir Tema", "Editar Tema", "Excluir Tema");
            
            Configuracao.BtnAdicionarEnabled = true;

            Configuracao.ToolTipAdicionarItem = "Adicionar Item ao Tema";

        }
        public override void Editar()
        {
            int id = tabelaTemas!.BuscarIdSelecionado();

            if (id == -1) return;

            Tema temaSelecionado = repositorioTema.ObterPorId(id);

            TelaTemaForm telaTema = new()
            {
                Text = "Editar Tema"
            };

            telaTema.Tema = temaSelecionado;

            DialogResult dialog = telaTema.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                Tema temaEditado = telaTema.Tema;

                bool editou = repositorioTema.Editar(temaEditado);

                if (editou == false)
                {
                    MessageBox.Show("O tema informado já está cadastrado", "Tema já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AtualizarListagem();
                }
            }
        }

        public override void Excluir()
        {
            int id = tabelaTemas!.BuscarIdSelecionado();
            if (id == -1) return;

            Tema temaSelecionado = repositorioTema.ObterPorId(id);

            DialogResult opcao = MessageBox.Show($"Confirma excluir o tema {temaSelecionado.Nome}? ", "Excluir Tema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                repositorioTema.Excluir(temaSelecionado.Id);
            }

            AtualizarListagem();
        }

        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm()
            {
                Text = "Cadastro de Temas"
            };

            DialogResult dialog = telaTema.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                Tema temaNovo = telaTema.Tema;

                bool cadastrou = repositorioTema.Cadastrar(temaNovo);

                if (cadastrou == false)
                {
                    MessageBox.Show("O tema informado já está cadastrado", "Tema já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AtualizarListagem();
                }
                
            }
        }

        public override UserControl ObterListagem()
        {
            tabelaTemas ??= new TabelaTemaControl();

            AtualizarListagem();

            return tabelaTemas;
        }

        public override void AdicionarItemTema()
        {
            int id = tabelaTemas!.BuscarIdSelecionado();
            if (id == -1) return;

            Tema temaSelecionado = repositorioTema.ObterPorId(id);

            TelaItemTemaForm telaItemForm = new TelaItemTemaForm(temaSelecionado);

            DialogResult opcaoEscolhida = telaItemForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                temaSelecionado.Itens.Clear();

                List<ItemTema> itens = telaItemForm.BuscarItem();

                foreach (ItemTema item in itens)
                {
                    temaSelecionado.AdicionarItemNoTema(item);
                }

                temaSelecionado.CalcularValorTotal();

                repositorioTema.Editar(temaSelecionado);

                AtualizarListagem();
            }
        }
    }
}
