
namespace FestasInfantis.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string Nome { get; set; }
        public List<ItemTema> Itens { get; set; }
        public decimal ValorTotal { get => CalcularValorTotal(); }

        public Tema(string tema)
        {
            this.Nome = tema;

            this.Itens = new List<ItemTema>();
           
        }
        public Tema() { }

        public override void Editar(Tema temaAtualizado)
        {
            this.Nome = temaAtualizado.Nome; 
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (Nome.Trim() == string.Empty)
            {
                erros.Add("Por gentileza, informe o nome do tema!");
            }

            return erros.ToArray();

        }
        public override string ToString()
        {
            return $"{Nome}";
        }

        public bool AdicionarItemNoTema(ItemTema item)
        {
            bool jaCadastrado = Itens.Any(i => i.Nome.Equals(item.Nome));

            if (jaCadastrado)
            {
                return false;
            }
               
            Itens.Add(item);

            return true;
        }

        public decimal CalcularValorTotal()
        {
            return Itens == null || Itens.Count == 0? 0 : Itens.Sum(i => i.Valor);
        }
    }
}
