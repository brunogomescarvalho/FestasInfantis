using FestasInfantis.Dominio.ModuloAluguel;

namespace FestasInfantis.InfraDados.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBase<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguel(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Aluguel>? ObterDados()
        {
           return contexto.Alugueis;
        }
    }
}
