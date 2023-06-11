using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.InfraDados.ModuloCliente;

public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
{
    public RepositorioCliente(ContextoDados contexto) : base(contexto)
    {

    }

    protected override List<Cliente>? ObterDados()
    {
        return contexto.Clientes;
    }

    public override bool Cadastrar(Cliente cliente)
    {
        if (ObterDados()!.Any(i => i.Cpf == cliente.Cpf))
        {
            return false;
        }

        return base.Cadastrar(cliente);
    }

    public override bool Editar(Cliente cliente)
    {
        if (ObterDados()!.Any(i => i.Cpf == cliente.Cpf && i.Id != cliente.Id ))
        {
            return false;
        }

        return base.Editar(cliente);
    }
}
