using System.Text.RegularExpressions;

namespace FestasInfantis.Dominio.ModuloCliente;

[Serializable]

public class Cliente : EntidadeBase<Cliente>
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }

    public Cliente(string nome, string telefone, string email, string cpf)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Cpf = cpf;
    }

    public Cliente() { }

 
    public override void Editar(Cliente entidade)
    {
        this.Nome = entidade.Nome;
        this.Telefone = entidade.Telefone;
        this.Email = entidade.Email;
        this.Cpf = entidade.Cpf;
    }

    public override string[] Validar()
    {
       List<string> erros = new List<string>();

        if( Nome.Trim() == string.Empty) 
        {
            erros.Add("Por gentileza, informe o nome do cliente!");
        }
        if (CpfEhValido(Cpf) == false)
        {
            erros.Add("CPF inválido, por gentileza use o padrão 123.456.890-12");
        }
        if (TelefoneEhValido(Telefone) == false)
        {
            erros.Add("Por gentileza, informe o telefone no formato 49 12345-6789 !");
        }
        if(EmailEhValido(Email) == false)
        {
            erros.Add("Email em formato inválido");
        }
        return erros.ToArray();
    }

    private static bool TelefoneEhValido(string telefone)
    {
        string padrao = @"^\(?[1-9]{2}\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$";

        return Regex.IsMatch(telefone, padrao);

    }

    private static bool EmailEhValido(string email)
    {
        string padrao = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.(?:com\.br|com)$";

        return Regex.IsMatch(email, padrao);
    }

    private static bool CpfEhValido(string cpf)
    {
        string padrao = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";

        return Regex.IsMatch(cpf, padrao);
    }

    public override string ToString()
    {
        return $"{Nome} {Telefone}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Cliente cliente &&
               Nome == cliente.Nome &&
               Telefone == cliente.Telefone &&
               Email == cliente.Email;
    }
}
