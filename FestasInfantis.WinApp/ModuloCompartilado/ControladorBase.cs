namespace FestasInfantis.WinApp.ModuloCompartilado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract UserControl ObterListagem();

        public abstract void ConfigurarTela();

        public virtual void Filtrar() { }

        public abstract void AtualizarListagem();

        public Configuracao Configuracao = null!;


    }
}
