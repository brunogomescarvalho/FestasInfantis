namespace FestasInfantis.Dominio.ModuloTema
{
    public class ItemTema
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }

        public ItemTema() { }
    
        public ItemTema(decimal valor, string nome)
        {
            this.Valor = valor;
            this.Nome = nome;
        }

        public string[] Validar()
        {
            List<string> erros = new List<string>();
            
                if (Nome.Trim() == string.Empty)
                {
                    erros.Add("Por gentileza, informe o nome do item!");
                }
                if (Valor < 0)
                {
                    erros.Add("Por gentileza, informe um valor positivo!");
                }

            return erros.ToArray();
        }

        public override string ToString()
        {
            return $"{Nome} R${Valor}";
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTema tema &&
                   Valor == tema.Valor &&
                   Nome == tema.Nome;
        }
    }
}
