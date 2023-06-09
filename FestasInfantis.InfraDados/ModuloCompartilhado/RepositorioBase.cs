using FestasInfantis.Dominio.ModuloCompartilhado;

namespace FestasInfantis.InfraDados.ModuloCompartilhado;

public abstract class RepositorioBase<TEntidade>: IRepositorioBase<TEntidade> where TEntidade: EntidadeBase<TEntidade> 
{
    protected ContextoDados contexto;

    private readonly List<TEntidade> registros;

    private int contadorId;

    protected RepositorioBase(ContextoDados contexto)
    {
        this.contexto = contexto;

        registros = ObterDados()!;

        AtualizarContador();
    }

    protected abstract List<TEntidade>? ObterDados();

    public TEntidade ObterPorId(int id)
    {
        return registros.FirstOrDefault(i => i.Id == id)!;
    }

    public List<TEntidade> BuscarTodos()
    {
        return registros;
    }

    public virtual bool Cadastrar(TEntidade entidade)
    {
        entidade.Id = ++contadorId;

        registros.Add(entidade);

        contexto.GravarDadosNoArquivo();
        
        return true;
    }

    public virtual bool Editar(TEntidade entidade)
    {
        TEntidade entidadeParaEditar = ObterPorId(entidade.Id);

        entidadeParaEditar.Editar(entidade);

        contexto.GravarDadosNoArquivo();

        return true;
    }

    public bool Excluir(int id)
    {
       int index = registros.FindIndex(i => i.Id == id);

        registros.RemoveAt(index);

        contexto.GravarDadosNoArquivo();

        AtualizarContador();

        return true;    
    }

    private void AtualizarContador()
    {
        if (registros.Count > 0)
            contadorId = registros.Max(x => x.Id);
    }

}
