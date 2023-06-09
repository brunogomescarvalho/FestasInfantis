namespace FestasInfantis.Dominio.ModuloCompartilhado;

public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
{
    TEntidade ObterPorId(int id);

    List<TEntidade> BuscarTodos();

    bool Cadastrar(TEntidade entidade);

    bool Editar(TEntidade entidade);

    bool Excluir(int id);
}

