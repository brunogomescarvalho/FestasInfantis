namespace FestasInfantis.Dominio.ModuloCompartilhado;

public abstract class EntidadeBase<TEntidade>
{
    public int Id { get; set; }

    public abstract void Editar(TEntidade entidade);

    public abstract string[] Validar();

}
