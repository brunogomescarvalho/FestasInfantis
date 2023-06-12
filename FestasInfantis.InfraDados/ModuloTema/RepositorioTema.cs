using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloCompartilhado;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.InfraDados.ModuloTema
{
    public class RepositorioTema : RepositorioBase<Tema>, IRepositorioTema
    {

        public RepositorioTema(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Tema>? ObterDados()
        {
            return contexto.Temas;
        }

        public override bool Cadastrar(Tema tema)
        {
            if (ObterDados()!.Any(i => i.Nome == tema.Nome))
            {
                return false;
            }
            return base.Cadastrar(tema);
        }

        public override bool Editar(Tema tema)
        {
            if (ObterDados()!.Any(i => i.Nome == tema.Nome && i.Id != tema.Id))
            {
                return false;
            }

            return base.Editar(tema);
        }

        
    }
}
